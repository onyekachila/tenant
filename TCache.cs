using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfrimartTenants
{
    public class TCache<T> : ITCache<T>
    {
        public T Get(string cacheKeyName, int cacheTimeOutSeconds, Func<T> func)
        {
            return new TCacheInternal<T>().Get(
                cacheKeyName, cacheTimeOutSeconds, func);
            //throw new NotImplementedException(); 
        }
    }
}