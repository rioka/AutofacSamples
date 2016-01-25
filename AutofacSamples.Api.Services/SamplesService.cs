using System;
using System.Collections.Generic;

namespace AutofacSamples.Api.Services
{
  public class SamplesService : ISamplesService
  {
    public IEnumerable<Guid> Get()
    {
      return new List<Guid>(new [] {
        Guid.NewGuid()
      });
    }
  }
}
