using Microsoft.AspNet.Mvc;

namespace WebApi
{
  [Route("api/[controller]")]
  public class Controller
  {
    [HttpGet]
    public string Get()
    {
      return "Hello world!";
    }
  }
}