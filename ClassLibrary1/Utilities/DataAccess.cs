using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}
