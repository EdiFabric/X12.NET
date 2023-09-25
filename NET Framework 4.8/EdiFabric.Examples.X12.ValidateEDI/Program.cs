using EdiFabric.Examples.X12.Common;
using System;

namespace EdiFabric.Examples.X12.ValidateEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Validate custom EDI codes
            //ValidateCustomEDICodes.Run();
            //ValidateCustomEDICodes.Run2();

            //  Validate transactions after reading
            ValidateEDITransationsAfterRead.Run();

            //  Validate transactions before writing them out
            ValidateEDITransationsBeforeWrite.Run();

            //  Validate transactions with custom code
            ValidateEDITransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Basic();
            ValidateDataElementTypes.Extended();

            //  Validate control segments, ISA and GS
            ValidateISAorGS.Run();

            //  Validate sample transactions
            Validate810.Run();
            Validate850.Run();
            Validate837P.Run();

            //  Validate async
            ValidateEDITransationsAsync.Run();
        }
    }
}
