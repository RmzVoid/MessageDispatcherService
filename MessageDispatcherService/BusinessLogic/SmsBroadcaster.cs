using System;
using System.Collections.Generic;
using NLog;

namespace BusinessLogic
{
    public class SmsBroadcaster : IBroadcaster
    {
        public void Broadcast(IEnumerable<string> addresses, string message)
        {
            foreach (var address in addresses)
                _log.Info("Message sended to [" + address + "]: " + message);
        }

        private Logger _log = LogManager.GetLogger("SmsLogger");
    }
}
