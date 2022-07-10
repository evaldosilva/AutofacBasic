using AutofacBasic.Domain.Interfaces.Services;

namespace AutofacBasic.Services
{
    public class AutofacBasicAppServices : IAutofacBasicAppServices
    {
        private readonly IProductServices _productServices;

        public AutofacBasicAppServices(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public bool Run(string productName)
        {
            return _productServices.AddProduct(productName);
        }
    }
}