using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AfrimartTenants.Models
{
    public class MultiTenantContext : DbContext
    {
        public MultiTenantContext()
        {

        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Partner> Partners { get; set; }
    }
}