using System;
using Amazon.Lambda.Core;

namespace StackeryFunction
{
    public class Handler
    {
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public dynamic handler(dynamic eventTrigger)
        {
            Console.WriteLine(eventTrigger);

            return new {};
        }
    }
}
