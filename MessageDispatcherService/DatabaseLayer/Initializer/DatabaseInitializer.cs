using DatabaseLayer.Context;
using DatabaseLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DatabaseLayer.Initializer
{
    class DatabaseInitializer<T> : DropCreateDatabaseAlways<T>
        where T : DatabaseContext
    {
        protected override void Seed(T context)
        {
            List<EventType> eventTypes = new List<EventType>
            {
                new EventType() { Name = "Php" },
                new EventType() { Name = "Csharp" },
                new EventType() { Name = "All" },
            };

            List<User> users = new List<User>
            {
                new User() { Name = "ШарпАдмин", Email = "email001@mail.com", Phone = "+7 800 555 1111" },
                new User() { Name = "ШарпКодер", Email = "email002@mail.com", Phone = "+7 800 555 2222" },
                new User() { Name = "ШарпСтажер", Email = "email003@mail.com", Phone = "+7 800 555 3333" },
                new User() { Name = "ПхпАдмин", Email = "email004@mail.com", Phone = "+7 800 555 4444" },
                new User() { Name = "ПхпКодер", Email = "email005@mail.com", Phone = "+7 800 555 5555" },
                new User() { Name = "ПхпСтажер", Email = "email006@mail.com", Phone = "+7 800 555 6666" },
                new User() { Name = "Руководитель", Email = "email007@mail.com", Phone = "+7 800 555 7777" },
                new User() { Name = "Начальник", Email = "email008@mail.com", Phone = "+7 800 555 8888" },
                new User() { Name = "СтаршийПомошникМладшегоДворника", Email = "email009@mail.com", Phone = "+7 800 555 9999" }
            };

            context.EventTypes.AddRange(eventTypes);
            context.Users.AddRange(users);
            context.SaveChanges();

            List<Subscription> subscriptions = new List<Subscription>
            {
                // получатели сообщений для csharp
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Csharp").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ШарпАдмин").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Csharp").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ШарпКодер").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Csharp").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ШарпСтажер").Result
                },
                // получатели сообщений для php
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Php").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ПхпАдмин").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Php").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ПхпКодер").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "Php").Result,
                    User = context.Users.FirstAsync(u => u.Name == "ПхпСтажер").Result
                },
                // получатели сообщений для all
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "All").Result,
                    User = context.Users.FirstAsync(u => u.Name == "Руководитель").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "All").Result,
                    User = context.Users.FirstAsync(u => u.Name == "Начальник").Result
                },
                new Subscription() {
                    Event = context.EventTypes.FirstAsync(e => e.Name == "All").Result,
                    User = context.Users.FirstAsync(u => u.Name == "СтаршийПомошникМладшегоДворника").Result
                }
            };

            context.Subscriptions.AddRange(subscriptions);
            context.SaveChanges();
        }
    }
}
