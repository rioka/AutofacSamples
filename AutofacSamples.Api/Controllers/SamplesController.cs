using System.Web.Http;
using AutofacSamples.Api.Services;

namespace AutofacSamples.Api.Controllers
{
  public class SamplesController : ApiController
  {
    #region Data

    private readonly ISamplesService _samplesService; 
    
    #endregion

    #region Constructors

    public SamplesController(ISamplesService samplesService)
    {
      _samplesService = samplesService;
    } 

    #endregion

    #region Apis
    
    public IHttpActionResult Get()
    {
      return Ok(_samplesService.Get());
    } 

    #endregion
  }
}