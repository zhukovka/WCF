using System;
using System.Collections.Generic;
using System.Linq;
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
                string addr = "192.168.1.106";
                Console.Write("Enter a number: ");
                string n = Console.ReadLine();
                int m = Int32.Parse(n);
                string res = lib.RequestToBinaryConverter(addr, m);
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
