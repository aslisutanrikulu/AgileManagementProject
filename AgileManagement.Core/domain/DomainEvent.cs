using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.domain
{
    public class DomainEvent
    {
        public static IDomainEventDispatcher Dispatcher { get; set; }
        public static void Raise<TDomainEvent>(TDomainEvent @event) where TDomainEvent : IDomainEvent
        {

            Dispatcher.Dispatch(@event);


        }
    }
}
