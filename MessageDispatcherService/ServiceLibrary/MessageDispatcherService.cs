using System;
using NLog;

using ServiceInterface;
using CommonTypes;
using BusinessLogic;
using System.ServiceModel;
using DatabaseLayer.Interface;
using System.Collections.Generic;
using DatabaseLayer.DataTransferObjects;

namespace ServiceLibrary
{
    public class MessageDispatcherService : IMessageDispatcherService, IService, IDisposable
    {
        public MessageDispatcherService(IMessageDispatcherLogic logic, IData data)
        {
            _logic = logic; // надо на нулл проверять
            _data = data;   //
            _log = LogManager.GetCurrentClassLogger();
        }

        public void DispatchMessage(SeverityLevel severity, EventType type, string message)
        {
            try
            {
                IEnumerable<UserDto> subscripers = _data.GetSubscribersFor(type);
                _logic.BroadcastMessage(subscripers, severity, type, message);
            }
            catch(Exception e)
            {
                _log.Error(e, "Error");
            }
        }

        public void Run()
        {
            // можно все вывести в конфиг, но не стал
            try
            {
                _host = new ServiceHost(this, new Uri("http://localhost:8888/Service"));
                _host.AddServiceEndpoint(typeof(IMessageDispatcherService), new WSHttpBinding(), "");
                _host.Description.Behaviors.Find<ServiceBehaviorAttribute>().InstanceContextMode = InstanceContextMode.Single;
                _host.Open();
            }
            catch(Exception e)
            {
                _log.Error(e, "Error");
            }
        }

        public void Dispose()
        {
            _host.Close();
        }

        private IMessageDispatcherLogic _logic = null;
        private IData _data = null;
        private ServiceHost _host = null;
        private Logger _log = null;
    }
}
