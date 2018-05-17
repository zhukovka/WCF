using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinaryConverterServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryConverterServiceClient.ServiceReference1.BinaryConverterServiceClient client = new BinaryConverterServiceClient.ServiceReference1.BinaryConverterServiceClient();

            // Используйте переменную "client", чтобы вызвать операции из службы.
            client.Open();
            Console.Write("Enter a number: ");
            string n = Console.ReadLine();
            int m = Int32.Parse(n);
            IAsyncResult res = client.BeginGetBinary(m, ar =>
            {
                Console.WriteLine($"The binary of {m} is {client.EndGetBinary(ar)}");
            }, null);
            while (!res.IsCompleted)
            {
                Thread.Sleep(200);
                Console.WriteLine("Client is working");
            }
            // Всегда закройте клиент.
            client.Close();
        }
    }
}
