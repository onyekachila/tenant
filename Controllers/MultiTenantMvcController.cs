﻿using AfrimartTenants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfrimartTenants.Controllers
{
    public class MultiTenantMvcController : Controller
    {
        public Tenant Tenant
        {
            get
            {
                object multiTenant;
                if (!Request.GetOwinContext().Environment.TryGetValue("MultiTenant",
                    out multiTenant))
                {
                    throw new ApplicationException("Could not find Tenant");
                }

                return (Tenant)multiTenant;
            }
        }
    }
}