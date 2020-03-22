using ClassLibrary;
using ClassLibrary.Utilities;
using System;

namespace DependencyInjection
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Starting the processs of data");
            Console.WriteLine();
            Console.WriteLine("Processing Data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            _logger.Log("Finished processing of the data");
            Console.WriteLine();

        }
    }
}
