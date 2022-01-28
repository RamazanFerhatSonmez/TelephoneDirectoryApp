using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Plain.RabbitMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Report.Microservice
{
    public class ReportDataCollector : IHostedService
    {
        private readonly ISubscriber subscriber;
        public ReportDataCollector(ISubscriber subscriber)
        {
            this.subscriber = subscriber;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            subscriber.Subscribe(ProcessMessage);
            return Task.CompletedTask;
        }
        private bool ProcessMessage(string message, IDictionary<string, object> headers)
        {
            var response = JsonConvert.DeserializeObject(message);
            if (message.Contains("UUID"))
            {

            }
            else
            {

            }
            return true;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
   
    
    
}
