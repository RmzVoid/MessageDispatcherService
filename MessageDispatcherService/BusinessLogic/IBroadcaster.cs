using System.Collections.Generic;

using CommonTypes;

namespace BusinessLogic
{
    public interface IBroadcaster
    {
        void Broadcast(IEnumerable<string> addresses, string message);
    }
}
