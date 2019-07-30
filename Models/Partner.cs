using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfrimartTenants.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public string Langauge { get; set; }
        public string Description { get; set; }

        public Tenant Tenant { get; set; } // we need to know what tenant this partner belongs to. // relationship or navigation property
    }
}