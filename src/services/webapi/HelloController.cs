using Microsoft.AspNet.Mvc;

namespace WebApi
{
  [Route("api/[controller]")]
  public class HelloController
  {
    [HttpGet]
    public string Get()
    {
      return "Hello world!";
    }
  }
}