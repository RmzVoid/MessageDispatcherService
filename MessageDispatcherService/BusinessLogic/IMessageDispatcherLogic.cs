using CommonTypes;
using DatabaseLayer.DataTransferObjects;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IMessageDispatcherLogic
    {
        void BroadcastMessage(IEnumerable<UserDto> recipients, SeverityLevel severity, EventType type, string message);
    }
}
