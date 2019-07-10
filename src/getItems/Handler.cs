using System;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace StackeryFunction
{
    public class Handler
    {
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public dynamic handler(dynamic eventTrigger)
        {
            Console.WriteLine(eventTrigger);
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

            var tableName = Environment.GetEnvironmentVariable("TABLE_NAME"); // get the table name from the automatically populated environment variables

            // Use dynamodb to get items from the Item table
            var request = new ScanRequest()
            {
                TableName = tableName
            };

            var response = client.ScanAsync(request).Result.Items;

            return response;
        }
    }
}
