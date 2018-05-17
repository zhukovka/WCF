using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using BinaryConverterService;
namespace BinaryConverterWindowsService
{
    class Service
    {


        public class ConverterWindowsService : ServiceBase
        {
            public ServiceHost serviceHost = null;
            public ConverterWindowsService()
            {
                // Name the Windows Service
                ServiceName = "BinaryConverterWCFWindowsService";
            }

            public static void Main()
            {
                ServiceBase.Run(new ConverterWindowsService());
            }

            // Start the Windows service.
            protected override void OnStart(string[] args)
            {
                if (serviceHost != null)
                {
                    serviceHost.Close();
                }

                // Create a ServiceHost for the BinaryConverterService type and 
                // provide the base address.
                serviceHost = new ServiceHost(typeof(BinaryConverterService.BinaryConverterService));

                // Open the ServiceHostBase to create listeners and start 
                // listening for messages.
                serviceHost.Open();
            }

            protected override void OnStop()
            {
                if (serviceHost != null)
                {
                    serviceHost.Close();
                    serviceHost = null;
                }
            }

        }
    }
}
