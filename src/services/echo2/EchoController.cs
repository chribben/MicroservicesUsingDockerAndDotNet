using Microsoft.Extensions.WebEncoders;
using Microsoft.AspNet.Mvc;
using System;

namespace Echo.Controllers
{
    public class EchoController : Controller
    {
        [Route("/"), HttpGet]
        public IActionResult Echo()
        {
            return Ok(DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}
