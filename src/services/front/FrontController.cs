using Microsoft.AspNet.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
namespace WebApi
{
  [Route("api/[controller]")]
  public class FrontController
  {
    HttpClient _client = null;
    string _uri;
    FrontController()
    {
        _client = new HttpClient();
        _uri = "";
    }
    [HttpGet]
    public async Task<string> Get()
    {
        return await _client.GetStringAsync(_uri);
    }
  }
}