using Microsoft.AspNetCore.Mvc;

namespace Say_Hello___Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {

        [HttpGet]
        [Route("SayHello/{name}")]

        public string AddName(string name)
        {
            return "Hello, " + name;
        }
    }
}
