using ConsoleClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryConverterServiceClient client = new BinaryConverterServiceClient();

            // Используйте переменную "client", чтобы вызвать операции из службы.
            client.Open();
            Console.Write("Enter a number: ");
            string n = Console.ReadLine();
            int m = Int32.Parse(n);
            IAsyncResult result = client.BeginGetBinary(m, ar => {
                Console.WriteLine($"The binary of {m} is {client.EndGetBinary(ar)}.");
            }, null);
            while (!result.IsCompleted)
            {
                Thread.Sleep(200);
                Console.WriteLine("Client is working...");
            }
            Console.ReadKey();
            // Всегда закройте клиент.
            client.Close();
        }
    }
}
