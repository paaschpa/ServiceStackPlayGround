using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Operations;
using Counter.ServiceModel.Types;
using ServiceStack.OrmLite;
using ServiceStack.ServiceInterface;

namespace Counter.ServiceInterface
{
    public class RepairOrdersService : Service
    {
        public IDbConnectionFactory DbConnectionFactory { get; set; }
        private int PageCount = 20;

        public RepairOrdersResponse Get(RepairOrders request)
        {
            using (IDbConnection dbConn = DbConnectionFactory.OpenDbConnection())
            {
                var repairOrders = dbConn.Select<RepairOrder>(q => q.Limit((request.Page.GetValueOrDefault(1) - 1) * PageCount, PageCount));
                return new RepairOrdersResponse {RepairOrders = repairOrders};
            }
        }
    }
}
