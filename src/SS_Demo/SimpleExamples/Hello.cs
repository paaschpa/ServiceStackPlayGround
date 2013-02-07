using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceInterface.ServiceModel;

namespace SS_Demo.SimpleExamples
{
    //Routes are created in the Configure method of AppHost.cs
    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
        public ResponseStatus ResponseStatus { get; set; } //Where Exceptions get auto-serialized
    }

    public class HelloService : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}