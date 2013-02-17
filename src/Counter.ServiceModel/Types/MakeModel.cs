﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.DataAnnotations;

namespace Counter.ServiceModel.Types
{
    public class MakeModel
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
