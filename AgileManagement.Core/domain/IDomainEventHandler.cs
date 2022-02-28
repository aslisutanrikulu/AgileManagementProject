using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.domain
{
    public interface IDomainEventHandler
    {
        void Handle(TDomainEvent @event);
    }
}
