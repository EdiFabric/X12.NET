using System;
using System.IO;

namespace EdiFabric.Examples.X12.Common
{
    public class SerialKey
    {
        private static string _serialKey = null;
        static SerialKey()
        {
            // To get a free serial key go to https://sowl.co/oApEt
            var serialKeyPath = @"../../../../../edifabric/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.X12.Common, file SerialKey.cs!");

            _serialKey = File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }

        public static string Get()
        {
            return _serialKey;
        }
    }
}
