using Autofac;

namespace AutofacBasic.App
{
    public class AutofacContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // This can have data, services or other modules
            builder.RegisterModule<AutofacContainerModule>();

            return builder.Build();
        }
    }
}