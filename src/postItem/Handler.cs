using System;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2;

namespace StackeryFunction
{
    public class Handler
    {
        public dynamic handler(dynamic eventTrigger)
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

            var tableName = Environment.GetEnvironmentVariable("TABLE_NAME");

            var config = new DynamoDBContextConfig { Conversion = DynamoDBEntryConversion.V2 };
            this.DDBContext = new DynamoDBContext(new AmazonDynamoDBClient(), config);

            return new {};
        }
    }
}
