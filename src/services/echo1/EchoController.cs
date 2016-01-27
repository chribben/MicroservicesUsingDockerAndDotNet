using Microsoft.Extensions.WebEncoders;
using Microsoft.AspNet.Mvc;

namespace Echo.Controllers
{
    public class EchoController : Controller
    {
        [Route("/"), HttpPost]
        public IActionResult Echo([FromBody] string input)
        {
            return Ok($"Echo server: {input}\n");
        }
    }
}
