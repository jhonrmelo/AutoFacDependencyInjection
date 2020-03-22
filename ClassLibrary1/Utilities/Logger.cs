using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine($"Logging {Message}");
        }
    }
}
