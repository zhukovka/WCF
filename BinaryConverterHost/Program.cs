using BinaryConverterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverterHost
{
    class Program
    {
        private static Uri serviceUrl = new Uri("http://localhost:51526/BinaryConverterService.svc");

        static void Main(string[] args)
        {
            // create Service Host 
            using (var serviceHost = new ServiceHost(
               typeof(BinaryConverterService.BinaryConverterService),
               serviceUrl))
            {

                // add the service endpoint 
                serviceHost.AddServiceEndpoint(
                            typeof(IBinaryConverterService),
                            new BasicHttpBinding(), "");
                serviceHost.Description.Behaviors.Add(
                            new ServiceMetadataBehavior
                            {
                                HttpGetEnabled = true
                            });

                // start the Service host 
                serviceHost.Open();

                Console.WriteLine("Service hosting time: " +
                                  DateTime.Now.ToString());
                Console.WriteLine();
                Console.WriteLine("Service Host is running...");
                Console.WriteLine("Press [Enter] key to stop the host...");
                Console.ReadLine();

                // close the Service host 
                serviceHost.Close();
            }
        }
    }
}
