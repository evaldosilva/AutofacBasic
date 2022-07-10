using AutofacBasic.Domain.Interfaces.Data;
using AutofacBasic.Domain.Interfaces.Services;

namespace AutofacBasic.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IDataManagement _dataManagement;

        public ProductServices(IDataManagement dataManagement)
        {
            _dataManagement = dataManagement;
        }

        public bool AddProduct(string name)
        {
            _dataManagement.LoadData();
            Console.WriteLine($"Adding a new product: {name}");
            _dataManagement.SaveData();
            Console.WriteLine($"New product created: {name}");
            return true;
        }
    }
}