using BinaryConverterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverterLib
{
    public class BinaryConverterLib
    {
        public string RequestToBinaryConverter(string addr, int n)
        {
            string response = "";

            ChannelFactory<IBinaryConverterService> factory = null;
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                //http://192.168.1.106/MyApp/BinaryConverterService.svc
                EndpointAddress address = new EndpointAddress("http://" + addr + "/MyApp/BinaryConverterService.svc");
                factory = new ChannelFactory<IBinaryConverterService>(binding, address);
                IBinaryConverterService channel = factory.CreateChannel();
                response = channel.GetBinary(n);
                factory.Close();
            }
            catch (Exception ex)
            {
                if (factory != null)
                {
                    factory.Abort();
                }
                response = ex.ToString();
            }
            return response;
        }
    }
}
