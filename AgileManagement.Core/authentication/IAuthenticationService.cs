using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.authentication
{
    public interface IAuthenticationService
    {
        Task AuthenticateAsync(string email, string password, bool persistance, string scheme = null);
    }
}
