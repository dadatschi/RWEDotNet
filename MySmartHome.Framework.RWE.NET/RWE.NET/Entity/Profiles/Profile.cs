﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RWE.NET.Entity.Profiles
{
    [XmlInclude(typeof(RuleProfile))]
    [XmlInclude(typeof(TimeProfile))]
    [XmlInclude(typeof(EventProfile))]
    public class Profile
    {
        public virtual Guid Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String State { get; set; }
        public virtual Guid LocationId { get; set; }
    }
}