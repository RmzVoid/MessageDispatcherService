using DatabaseLayer.Interface;
using System.Collections.Generic;
using System.Linq;

using DatabaseLayer.DataTransferObjects;
using DatabaseLayer.Context;
using CommonTypes;

namespace DatabaseLayer
{
    public class Data : IData
    {
        public Data(DatabaseContext context)
        {
            _context = context;     // check for null required
        }

        // выбирает всех пользователей подписанный на событие eventType
        public IEnumerable<UserDto> GetSubscribersFor(EventType eventType)
        {
            return _context.Subscriptions
                .Where(s => s.Event.Name == eventType.ToString())
                .Select(e => new UserDto
                {
                    Id = e.User.Id,
                    Name = e.User.Name,
                    Phone = e.User.Phone,
                    Email = e.User.Email
                });
        }

        private DatabaseContext _context = null;
    }
}
