using System;

using ServiceLibrary;
using ServerSideApp.AppController;
using ServiceInterface;
using BusinessLogic;
using DatabaseLayer.Interface;
using DatabaseLayer;

namespace ServerSideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // укажем где искать файл базы данных
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            IApplicationController controller = new ApplicationController()
                .RegisterType<IMessageDispatcherService, MessageDispatcherService>()
                .RegisterType<IMessageDispatcherLogic, MessageDispatcherLogic>()
                .RegisterType<IData, Data>();

            controller.Run<MessageDispatcherService>();

            // block app here
            Console.ReadKey(true);
        }
    }
}
