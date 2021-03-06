﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using ModuleZeroSampleProject.Users;

namespace ModuleZeroSampleProject.Navigation
{
    public class MyNav:FullAuditedEntity<int,User>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
