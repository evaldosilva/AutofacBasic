using AutofacBasic.Domain.Interfaces.Data;

namespace AutofacBasic.Data
{
    public class DataManagement : IDataManagement
    {
        public bool LoadData()
        {
            Console.WriteLine("Loading data...");
            return true;
        }

        public bool SaveData()
        {
            Console.WriteLine("Saving data...");
            return true;
        }
    }
}