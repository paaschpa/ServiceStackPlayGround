﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.DataAnnotations;

namespace Counter.ServiceModel.Types
{
    public class ServiceAdvisor
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
