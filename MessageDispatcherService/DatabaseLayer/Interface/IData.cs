using System.Collections.Generic;

using DatabaseLayer.DataTransferObjects;
using CommonTypes;

namespace DatabaseLayer.Interface
{
    public interface IData
    {
        // возможно использование энумератора здесь ошибка
        IEnumerable<UserDto> GetSubscribersFor(EventType eventType);
    }
}
