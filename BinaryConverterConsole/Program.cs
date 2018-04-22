using BinaryConverterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IBinaryConverterService> factory = null;
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                EndpointAddress
                address = new EndpointAddress("http://192.168.1.106/MyApp/BinaryConverterService.svc");
                factory = new ChannelFactory<IBinaryConverterService>(binding, address);
                IBinaryConverterService channel = factory.CreateChannel();
                Console.Write("Enter a number: ");
                string n = Console.ReadLine();
                int m = Int32.Parse(n);
                string binary = channel.GetBinary(m);
                int oneCount = channel.GetOneCount(m);
                Console.WriteLine($"Binary of {m} is {binary}. It has {oneCount} of 1");
                factory.Close();
            }
            catch (CommunicationException)
            {
                if (factory != null)
                {
                    factory.Abort();
                }
            }
            catch (TimeoutException)
            {
                if (factory != null)
                {
                    factory.Abort();
                }
            }
            catch (Exception ex)
            {
                if (factory != null)
                {
                    factory.Abort();
                }
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
