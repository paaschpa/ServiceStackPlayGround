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
    public class ServiceAdvisorsService : Service
    {
        public IDbConnectionFactory DbConnectionFactory { get; set; }

        public ServiceAdvisorsResponse Get(ServiceAdvisors request)
        {
            using (IDbConnection dbConn = DbConnectionFactory.OpenDbConnection())
            {
                var serviceAdvisors = dbConn.Select<ServiceAdvisor>();
                return new ServiceAdvisorsResponse { ServiceAdvisors = serviceAdvisors, TotalRecords = serviceAdvisors.Count};
            }
        }
    }
}
