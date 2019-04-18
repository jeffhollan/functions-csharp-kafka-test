using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.Kafka;

namespace Company.Function
{
    public static class KafkaTriggerCSharp
    {
        [FunctionName("KafkaTriggerCSharp")]
        public static void Run(
            [KafkaTrigger("jehollankore-cp-kafka-headless:9092", "twitter", ConsumerGroup = "functions")] string events,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogInformation("Got event: " + events);
        }
    }
}
