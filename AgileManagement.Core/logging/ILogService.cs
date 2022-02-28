using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.logging
{
    public static class LogLevels
    {
        public const string Error = "Error";
        public const string Information = "Info";
        public const string Warning = "Warning";
        public const string Success = "Success";
    }
    /// <summary>
    /// yapılan işlemlere ait kayıtları izleyebilmek bu servisin log methodunu kullanacağız
    /// </summary>
    public interface ILogService
    {
        void Log(string message, string logLevel);
    }
}

