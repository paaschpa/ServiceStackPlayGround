using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using Counter.ServiceModel.Operations;
using Counter.ServiceModel.Types;
using ServiceStack.Common.Extensions;
using ServiceStack.Common.Web;
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
                var serviceAdvisors = new List<ServiceAdvisor>();
                using(var advisorsService = base.ResolveService<ServiceAdvisorsService>())
                {
                    serviceAdvisors = advisorsService.Get(new ServiceAdvisors()).ServiceAdvisors;
                }

                var repairOrders = dbConn.Select<RepairOrder>(q => q.Limit((request.Page.GetValueOrDefault(1) - 1) * PageCount, PageCount));
                foreach(var ro in repairOrders)
                {
                    ro.AdvisorName = serviceAdvisors.Where(x => x.Id == ro.Id).FirstOrDefault().Name;
                }

                return new RepairOrdersResponse {RepairOrders = repairOrders};
            }
        }

        public object Post(CreateRepairOrder request)
        {
            using (IDbConnection dbConn = DbConnectionFactory.OpenDbConnection())
            {
                var repairOrder = request.TranslateTo<RepairOrder>();
                dbConn.Insert<RepairOrder>(repairOrder);
                var repairOrderId = dbConn.GetLastInsertId();

                return new CreateRepairOrderResponse();
            }
        }
    }
}
