using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfrimartTenants
{
    public interface ITCache<T>
    { 
        
        T Get(string cacheKeyName, int cacheTimeOutSeconds, Func<T> func);
    }
}