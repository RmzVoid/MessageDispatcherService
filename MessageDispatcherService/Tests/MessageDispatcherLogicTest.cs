using System;
using System.Collections.Generic;
using NUnit.Framework;

using BusinessLogic;
using NSubstitute;
using DatabaseLayer.Interface;
using DatabaseLayer.DataTransferObjects;
using CommonTypes;

namespace Tests
{
    [TestFixture]
    public class MessageDispatcherLogicTest
    {
        [SetUp]
        public void SetUp()
        {
            _recipients = new List<UserDto>()
            {
                new UserDto() { Id=1, Name="John Carmack", Email="john_carmack@idsoftware.org", Phone = "+1 (972) 613-3589" }
            };

            _logic = new MessageDispatcherLogic();
        }

        [Test]
        public void MessageDispatcherLogic_Normal()
        {
            _logic.BroadcastMessage(_recipients, SeverityLevel.Critical, EventType.All, "Critical severity");
        }

        [Test]
        public void MessageDispatcherLogic_EmptyMessage()
        {

            NUnit.Framework.Assert.Throws<Exception>(() =>
            _logic.BroadcastMessage(_recipients, SeverityLevel.Critical, EventType.All, string.Empty)
            );
        }

        [Test]
        public void MessageDispatcherLogic_UnknownSeverity()
        {
            NUnit.Framework.Assert.Throws<Exception>(() =>
            _logic.BroadcastMessage(_recipients, (SeverityLevel)555, EventType.All, "Unknown severity")
            );
        }

        [Test]
        public void MessageDispatcherLogic_EmptyRecipientsList()
        {
            NUnit.Framework.Assert.Throws<Exception>(() =>
            _logic.BroadcastMessage(new List<UserDto>(), SeverityLevel.Low, EventType.Csharp, "Empty recipiets list")
            );
        }

        private IMessageDispatcherLogic _logic = null;
        private IEnumerable<UserDto> _recipients = null;
    }
}
