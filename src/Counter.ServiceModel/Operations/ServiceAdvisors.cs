using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Counter.ServiceModel.Operations
{
    [Route("ServiceAdvisors", "GET")]
    public class ServiceAdvisors : IReturn<ServiceAdvisorsResponse>
    {
    }

    public class ServiceAdvisorsResponse
    {
        public ServiceAdvisorsResponse()
        {
            this.ServiceAdvisors = new List<ServiceAdvisor>();
            this.ResponseStatus = new ResponseStatus();
        }

        public List<ServiceAdvisor> ServiceAdvisors { get; set; }
        public int TotalRecords { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
