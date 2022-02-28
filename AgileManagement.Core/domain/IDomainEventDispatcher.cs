using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.domain
{
    public interface IDomainEventDispatcher
    {
        void Dispatch<TDomainEvent>(TDomainEvent @event) where TDomainEvent : IDomainEvent;
    }
}
