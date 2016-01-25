using System;
using System.Collections.Generic;

namespace AutofacSamples.Api.Services
{
  public interface ISamplesService
  {
    #region Apis

    IEnumerable<Guid> Get(); 
    
    #endregion
  }

}
