using EdiFabric.Rules.Vda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Sdk.Helpers.Vda
{
    public class TransactionBuilders
    {
        /// <summary>
        /// Build delivery instruction.
        /// Original from 
        /// </summary>
        public static TS4905 BuildDeliveryInstruction()
        {
            var result = new TS4905();

            result.S511 = new S511();
           // result.S511.RecordType_01 = "";

            return result;
        }
    }
}
