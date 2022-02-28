using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.authorization
{
    public interface IAuthorizationService
    {
        Task<bool> IsAuthorized(string email);
    }
}
