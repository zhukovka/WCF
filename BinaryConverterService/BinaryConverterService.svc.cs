using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BinaryConverterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BinaryConverterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BinaryConverterService.svc or BinaryConverterService.svc.cs at the Solution Explorer and start debugging.
    public class BinaryConverterService : IBinaryConverterService
    {

        public string GetBinary(int value)
        {
            return Convert.ToString(value, 2);
        }

        public int GetOneCount(int value)
        {
            string binary = GetBinary(value);
            return binary.Count(b => b == '1');
        }
    }
}
