using EdiFabric.Examples.X12.Common;
using System;

namespace EdiFabric.Examples.X12.AcknowledgeEDI
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

            //  Generate 997 for valid group
            GenerateValid997.Run();

            //  Generate 997 for invalid group
            GenerateInvalid997.Run();

            //  Generate 997 for duplicates
            Generate997ForDuplicateTransaction.Run();
            Generate997ForDuplicateGroup.Run();
            Generate997ForDuplicateInterchange.Run();

            //  Generate 997 with explicit control numbers
            Generate997WithCustomControlNumbers.Run();

            Read997.Run();
        }
    }
}
