using System;
using System.Collections.Generic;

namespace AutofacSamples.Api.Services
{
  public interface ISamplesService
  {
    IEnumerable<Guid> Get();
  }

}
