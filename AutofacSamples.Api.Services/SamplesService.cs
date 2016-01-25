using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace AutofacSamples.Api.Services
{
  public class SamplesService : ISamplesService, IDisposable
  {
    #region Constructors

    public SamplesService()
    {
      Trace.WriteLine(MethodBase.GetCurrentMethod().DeclaringType + " ctor");
    }

    #endregion

    #region Apis

    public IEnumerable<Guid> Get()
    {
      return new List<Guid>(new [] {
        Guid.NewGuid()
      });
    }

    #endregion

    #region IDisposable
    
    public void Dispose()
    {
      Trace.WriteLine(MethodBase.GetCurrentMethod().DeclaringType + " Dispose");
    }

    #endregion
  }
}
