using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.ServiceModel;

namespace SS_Demo.SimpleExamples
{
    //Overview
    //- Simple Example of Request/Response
    //- One Service per Request - Uncomment HelloServiceBad class and run to view the error message
    //- Routing done in AppHostBase.Routes or using Route Attribute - https://github.com/ServiceStack/ServiceStack/wiki/Routing contains Routing Resolution Order

    //Routes are created in the Configure method of AppHost.cs or can use [Route("/Hello")]
    //access via /api/Hello/
    //[Route("/GoodBye")] **This would be found first and take precedence over lower route because of 'Order of Registration'
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
        public ResponseStatus ResponseStatus { get; set; } //Where Exceptions get auto-serialized
    }

    [Route("/GoodBye")]
    [Route("/GoodBye/{Name*}")]
    public class Goodbye : IReturn<GoodbyeResponse>
    {
        public string Name { get; set; }
    }

    public class GoodbyeResponse
    {
        public string Result { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }

    //Reference for New API https://github.com/ServiceStack/ServiceStack/wiki/New-Api
    //Service class is a convenience concrete which contains easy access to ServiceStack's providers
    //Service class implements IService which is a marker class that ServiceStack uses to find, register and auto-wire your existing services 
    public class HelloService : Service 
    {
        public object Get(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }

        public object Get(Goodbye request)
        {
            return new GoodbyeResponse {Result = "Goodbye, " + request.Name};
        }

        public GetErrorResponse Any(GetError request)
        {
            throw new Exception("Bad Things"); //find me in the ResponseStatus https://github.com/ServiceStack/ServiceStack/wiki/Validation
        }
    }

    [Route("/GetError")]
    public class GetError
    {}

    public class GetErrorResponse
    {
        public ResponseStatus ResponseStatus { get; set; }
    }

    //**Uncomment to trigger error when a the request (Hello) is registered to multiple services
    //public class HelloServiceBad : Service
    //{
    //    public object Any (Hello request)
    //    {
    //        return new HelloResponse {Result = "I cause Error [Could not register x with service as it has already been assigned by another Service"};
    //    }
    //}
}