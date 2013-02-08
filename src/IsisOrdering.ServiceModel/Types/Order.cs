using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsisOrdering.ServiceModel.Types
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
