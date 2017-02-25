using System.ServiceModel;

using CommonTypes;

namespace ServiceInterface
{
    [ServiceContract]
    public interface IMessageDispatcherService
    {
        [OperationContract]
        void DispatchMessage(SeverityLevel severity, EventType type, string message);
    }
}
