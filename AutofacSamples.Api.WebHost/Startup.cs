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

      var container = IoCConfig.Register(config);

      app.UseAutofacMiddleware(container);
      app.UseAutofacWebApi(config);

      app.UseWebApi(config);
    } 

    #endregion
  }
}