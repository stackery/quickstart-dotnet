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
            var id = "1"; // modify with each invoke so the id does not repeat
            var content = "This is my content"; // modify content here
            Console.WriteLine("Adding item " + id + " to table " + tableName);
            // Write a new item to the ItemTable
            var request = new PutItemRequest()
            {
                TableName = tableName,
                Item = new Dictionary<string, AttributeValue>()
                {
                    { "id", new AttributeValue{S = id } },
                    { "content", new AttributeValue{S = content } }
                }
            };

            var response = client.PutItemAsync(request).Result;

            Console.WriteLine("Item added to table, done!");
            return response;
        }
    }
}
