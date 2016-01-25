using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutofacSamples.Api.Controllers;
using AutofacSamples.Api.Services;

namespace AutofacSamples.Api.WebHost
{
  public class IoCConfig
  {
    public static IContainer Register(HttpConfiguration config)
    {
      var builder = new ContainerBuilder();

      builder.RegisterApiControllers(typeof(SamplesController).Assembly);
      builder.RegisterType<SamplesService>()
             .As<ISamplesService>()
             .InstancePerRequest();

      var container = builder.Build();
      config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

      return container;
    }
  }
}