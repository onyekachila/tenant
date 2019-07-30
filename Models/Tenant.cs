using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfrimartTenants.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DomainName { get; set; }
        public bool Default { get; set; } // we only allow one tenant to be true which is the master tenant. Afrimart.com in our case 
    }
}