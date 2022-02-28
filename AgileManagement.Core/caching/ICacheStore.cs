using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core.caching
{
    public interface ICacheStore<TModel>
    {
        void Set(string cacheKey, TModel model);
        /// <summary>
        /// cache göre key getirir
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        TModel Get(string cacheKey);
        /// <summary>
        /// Cahce temizler
        /// </summary>
        /// <param name="cacheKey"></param>
        void Clear(string cacheKey);
    }
}
