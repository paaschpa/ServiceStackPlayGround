using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Counter.ServiceModel.Operations
{
    [Route("MakeModels")]
    public class MakeModels : IReturn<MakeModelsResponse>
    {
    }

    public class MakeModelsResponse
    {
        public MakeModelsResponse()
        {
            this.MakeModels = new List<MakeModel>();
            this.ResponseStatus = new ResponseStatus();
        }

        public List<MakeModel> MakeModels { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
