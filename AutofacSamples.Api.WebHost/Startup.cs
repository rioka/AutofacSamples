using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutofacSamples.Api.Controllers;
using AutofacSamples.Api.Services;
using Owin;

namespace AutofacSamples.Api.WebHost
{
  public class Startup
  {
    #region Apis
    
    public void Configuration(IAppBuilder app)
    {
      var config = new HttpConfiguration();
      WebApiConfig.Register(config);

      var container = IoCSetup();
      config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
      app.UseAutofacMiddleware(container);
      app.UseAutofacWebApi(config);

      app.UseWebApi(config);
    } 

    #endregion

    #region Internals

    IContainer IoCSetup()
    {
      var builder = new ContainerBuilder();

      builder.RegisterApiControllers(typeof(SamplesController).Assembly);
      builder.RegisterType<SamplesService>()
             .As<ISamplesService>()
             .InstancePerRequest();

      return builder.Build();
    } 

    #endregion
  }
}