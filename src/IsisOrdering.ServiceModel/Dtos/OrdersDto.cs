using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsisOrdering.ServiceModel.Dtos
{
    public class OrdersDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int CountItems { get; set; }
        public int TotalCost { get; set; }
    }
}
