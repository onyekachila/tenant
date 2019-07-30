using AfrimartTenants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfrimartTenants.Controllers
{
    public class TenantController : Controller
    {
        // GET: Tenant
        public ActionResult Index()
        {
            var tenants = new List<Tenant>
            {
                new Tenant()
                {
                    Name = "Yala and Sada",
                    DomainName = "www.afrimart.com",
                    Id = 1,
                    Default = true
                },
                new Tenant()
                {
                    Name = "Ireene and co",
                    DomainName = "www.ireenefromegypt.org",
                    Id = 2,
                    Default = false
                },
                new Tenant()
                {
                    Name = "feels transaction tanzania",
                    DomainName = "www.tf.tz",
                    Id = 3,
                    Default = false
                }
            };
            return View(tenants);
        }
    }
}