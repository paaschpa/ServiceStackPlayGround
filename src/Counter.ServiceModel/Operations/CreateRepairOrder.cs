using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Counter.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.ServiceModel;

namespace Counter.ServiceModel.Operations
{
    [Route("RepairOrder", "POST")]
    public class CreateRepairOrder : IReturn<CreateRepairOrderResponse>
    {
        public string CustomerName { get; set; }
        public string Code { get; set; }
        public int AdvisorId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    public class CreateRepairOrderResponse
    {
        public CreateRepairOrderResponse()
        {
            this.ResponseStatus = new ResponseStatus();
        }

        public ResponseStatus ResponseStatus { get; set; }
    }
}
