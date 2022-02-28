using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.notification
{
    public interface IEmailService
    {
        Task SendSingleEmailAsync(string to, string subject, string message);
    }
}
