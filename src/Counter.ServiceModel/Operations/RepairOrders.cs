using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Counter.ServiceModel.Operations
{
    [Route("RepairOrders/{Page}")]
    public class RepairOrders : IReturn<RepairOrdersResponse>
    {
        public int? Page;
    }

    public class RepairOrdersResponse
    {
        public List<RepairOrder> RepairOrders { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
