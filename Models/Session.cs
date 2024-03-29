﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfrimartTenants.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }

        public List<Speaker> Speakers { get; set; }
        
        public virtual Tenant Tenant { get; set; }

    }
}