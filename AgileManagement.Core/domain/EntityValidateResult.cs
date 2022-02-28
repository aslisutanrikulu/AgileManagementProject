using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.domain
{
    public class EntityValidateResult
    {
        /// <summary>
        /// entity kayıt altına alınmadan önce kontrolden geçip geçemediğini kontrol eder.
        /// </summary>
        public bool IsValid { get; set; }
        /// <summary>
        /// eger isvalid değilse entity ile ilgili hata mesajlarını tutarız.
        /// </summary>
        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}
