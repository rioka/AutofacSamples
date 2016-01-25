using System.Web.Http;
using AutofacSamples.Api.Services;

namespace AutofacSamples.Api.Controllers
{
  public class SamplesController : ApiController
  {
    private readonly ISamplesService _samplesService;

    public SamplesController() : this(new SamplesService())
    {}

    public SamplesController(ISamplesService samplesService)
    {
      _samplesService = samplesService;
    }

    public IHttpActionResult Get()
    {
      return Ok(_samplesService.Get());
    }
  }
}