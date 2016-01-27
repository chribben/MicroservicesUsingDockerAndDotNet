using Microsoft.AspNet.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi
{
  [Route("api/[controller]")]
  public class FrontController : Controller
  {
    HttpClient _client = new HttpClient();
    string _uri = "http://127.0.0.1:8000/";

    [HttpGet]
    public async Task<string> Get()
    {
        var result = await _client.GetStringAsync(_uri);
        System.Console.WriteLine(result);
        return result;
    }
  }
}