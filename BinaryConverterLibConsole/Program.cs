using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverterLibConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BinaryConverterLib.BinaryConverterLib lib = new BinaryConverterLib.BinaryConverterLib();
                string myIP = lib.getMyIP();
                Console.WriteLine("Your IP Address is :" + myIP);

                Console.Write("Enter a number: ");
                string n = Console.ReadLine();
                int m = Int32.Parse(n);
                string res = lib.RequestToBinaryConverter(myIP, m);
                Console.WriteLine($"Binary of {m} is: {res}");
                Console.ReadKey();
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
