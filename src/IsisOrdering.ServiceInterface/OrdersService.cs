using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IsisOrdering.ServiceModel.Dtos;
using IsisOrdering.ServiceModel.Operations;
using IsisOrdering.ServiceModel.Types;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.ServiceModel;

namespace IsisOrdering.ServiceInterface
{
    public class OrdersService : Service
    {
        public OrdersResponse Get(Orders request)
        {
            return new OrdersResponse { Orders = new List<OrdersDto>
                {
                    new OrdersDto {CustomerName="Test", CountItems = 10, TotalCost = 100}
                }};
        }
    }
}
