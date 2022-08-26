using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HttpTriggeredFunction
{
    public class ServiceBusTriggeredFunction
    {
        [FunctionName("ServiceBusTriggeredFunction")]
        public void Run([ServiceBusTrigger("q1", Connection = "ServiceBusConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"##### C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
