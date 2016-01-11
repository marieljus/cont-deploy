using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ServiceBusConfiguration();

            // Connection String Service Bus
            config.ConnectionString =
                "Endpoint=sb://testdemo-dev.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=VUyEwog5NpmezTHMZBT04NdqjsiXujP317NbcGDTwQw=";

            var jobHostConfiguration = new JobHostConfiguration();
            jobHostConfiguration.UseServiceBus(config);

            // Connection String / Primarey Key Web App
            jobHostConfiguration.DashboardConnectionString =
                "DefaultEndpointsProtocol=https;AccountName=enkeltftpdemo;AccountKey=vcnrOgpgVws1xfziK9unuUabmqaTAg2B+sH/8ndcFCNS7YTdlYklyiFcvZx6MplxFjELEEfY/YC1U38pwkHzfQ==";
            jobHostConfiguration.StorageConnectionString =
                "DefaultEndpointsProtocol=https;AccountName=enkeltftpdemo;AccountKey=vcnrOgpgVws1xfziK9unuUabmqaTAg2B+sH/8ndcFCNS7YTdlYklyiFcvZx6MplxFjELEEfY/YC1U38pwkHzfQ==";

            var jobhost = new JobHost(jobHostConfiguration);
            jobhost.RunAndBlock(); // Continous
        }
    }
}
