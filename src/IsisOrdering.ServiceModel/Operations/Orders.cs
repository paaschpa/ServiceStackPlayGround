using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IsisOrdering.ServiceModel.Dtos;
using IsisOrdering.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace IsisOrdering.ServiceModel.Operations
{
    [Route("/Orders/Page/{Page}")]
    public class Orders : IReturn<OrdersResponse>
    {
        public int? Page { get; set; }
    }

    public class OrdersResponse 
    {
        public List<OrdersDto> Orders { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
