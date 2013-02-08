using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using IsisOrdering.ServiceModel.Types;
using ServiceStack.OrmLite;
using ServiceStack.WebHost.Endpoints;

namespace SS_Demo
{
    public class DataSeeder
    {
        public void Seed()
        {
            var dbFactory = AppHostBase.Resolve<IDbConnectionFactory>();
            using(IDbConnection dbConn = dbFactory.OpenDbConnection())
            {
                dbConn.DropAndCreateTable<Order>();
                dbConn.DropAndCreateTable<OrderDetail>();

                dbConn.Insert(new Order {CustomerName="Woodhouse"});
                var orderId = (int)dbConn.GetLastInsertId();
                var orderDetail = new OrderDetail {OrderId = orderId, ItemId = 1, Quantity = 10, UnitPrice = 25};
                dbConn.Insert(orderDetail);

                var orders = dbConn.Select<Order>();
                var details = dbConn.Select<OrderDetail>();
            }
        }
    }
}