using Autofac;
using AutofacBasic.App;
using AutofacBasic.Domain.Interfaces.Services;

var container = AutofacContainerConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    var app = scope.Resolve<IAutofacBasicAppServices>();
    app.Run("Papaya");
}