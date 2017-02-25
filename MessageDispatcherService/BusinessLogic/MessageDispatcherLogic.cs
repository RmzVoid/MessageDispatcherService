using System;
using System.Linq;
using System.Collections.Generic;
using NLog;

using CommonTypes;
using DatabaseLayer.Interface;
using DatabaseLayer.DataTransferObjects;

namespace BusinessLogic
{
    public class MessageDispatcherLogic : IMessageDispatcherLogic
    {
        public void BroadcastMessage(IEnumerable<UserDto> recipients, SeverityLevel severity, EventType type, string message)
        {
            if (recipients.Count() <= 0)
                throw new Exception(string.Format("No recipients for event type {0}", type));

            if (string.IsNullOrWhiteSpace(message))
                throw new Exception("Tried to send empty message");

            string finalMessage = "[" + type.ToString() + "] " + message;

            switch (severity)
            {
                case SeverityLevel.Low:
                    BroadcastUsing<EmailBroadcaster>(recipients.Select<UserDto, string>(e => e.Email), finalMessage);
                    break;

                case SeverityLevel.Middle:
                    BroadcastUsing<SmsBroadcaster>(recipients.Select<UserDto, string>(e => e.Phone), finalMessage);
                    break;

                case SeverityLevel.Critical:
                    BroadcastUsing<SmsBroadcaster>(recipients.Select<UserDto, string>(e => e.Phone), finalMessage);
                    BroadcastUsing<EmailBroadcaster>(recipients.Select<UserDto, string>(e => e.Email), finalMessage);
                    break;

                default:
                    throw new Exception(string.Format("No routes defined for severity level {0}", severity));
            }
        }

        private void BroadcastUsing<TBroadcaster>(IEnumerable<string> addresses, string message)
            where TBroadcaster : class, IBroadcaster, new()
        {
            TBroadcaster broadcaster = new TBroadcaster();

            broadcaster.Broadcast(addresses, message);
        }

        private Logger _log = LogManager.GetCurrentClassLogger();
    }
}
