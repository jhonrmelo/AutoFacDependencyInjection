using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Utilities
{
    public interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}
