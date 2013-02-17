using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Operations;
using Counter.ServiceModel.Types;
using ServiceStack.OrmLite;
using ServiceStack.ServiceInterface;

namespace Counter.ServiceInterface
{
    public class MakeModelsService : Service
    {
        public IDbConnectionFactory DbConnectionFactory { get; set; }
        
        public MakeModelsResponse Get(MakeModels request)
        {
            using (var dbConn = DbConnectionFactory.OpenDbConnection())
            {
                var makeModels = dbConn.Select<MakeModel>();
                return new MakeModelsResponse { MakeModels = makeModels };
            }
        }
    }
}
