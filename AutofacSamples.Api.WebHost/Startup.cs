﻿using System.Web.Http;
using Owin;

namespace AutofacSamples.Api.WebHost
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      var config = new HttpConfiguration();
      WebApiConfig.Register(config);
      
      app.UseWebApi(config);
    }
  }
}