using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HttpTriggeredFunction
{
    public class QueueTriggeredFunction
    {
        [FunctionName("QueueTriggeredFunction")]
        public void Run([QueueTrigger("xyz", Connection = "QueueConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
