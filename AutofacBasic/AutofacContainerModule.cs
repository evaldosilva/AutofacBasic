using Autofac;
using AutofacBasic.Data;
using AutofacBasic.Domain.Interfaces.Data;
using AutofacBasic.Domain.Interfaces.Services;
using AutofacBasic.Services;

namespace AutofacBasic.App
{
    public class AutofacContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ProductServices>().As<IProductServices>();
            builder.RegisterType<DataManagement>().As<IDataManagement>();
            builder.RegisterType<AutofacBasicAppServices>().As<IAutofacBasicAppServices>();
        }
    }
}