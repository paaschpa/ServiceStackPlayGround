using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.DataAnnotations;

namespace IsisOrdering.ServiceModel.Types
{
    public class Order
    {
        [AutoIncrement]
        public int Id { get; set; } //OrmLite expects Id to primary key...can use [PrimaryKey] attribute or [Alias("DbFieldName"] 
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
        [AutoIncrement]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
