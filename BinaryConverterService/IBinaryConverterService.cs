using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BinaryConverterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBinaryConverterService" in both code and config file together.
    [ServiceContract]
    public interface IBinaryConverterService
    {
        [OperationContract]
        string GetBinary(int value);

        [OperationContract]
        int GetOneCount(int value);
    }
}
