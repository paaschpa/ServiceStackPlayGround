﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter.ServiceModel.Types
{
    public enum Status
    {
        Open,
        Working,
        Finished,
        Invoiced
    }

    public class RepairOrder
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Code { get; set; }
        public int AdvisorId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public DateTime PromiseDate { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
