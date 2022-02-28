using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.domain
{
    public class IDomainEvent
    {
        public string Name { get; set; }
    }
    public class UserRegisteredEvent : IDomainEvent
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
    public class UserRegisterHandler : IDomainEventHandler<UserRegisteredEvent>
    {
        public void Handle(UserRegisteredEvent @event)
        {

            throw new NotImplementedException();
        }
    }
}
