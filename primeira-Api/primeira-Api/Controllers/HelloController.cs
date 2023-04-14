using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace primeira_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        /* Tipos de interaçoes:
            Post
            Get
            Put
            Delete
        */

        public IActionResult Get()
        {
            return Ok("Ola mundo!\nEstou aprendendo a construir minha primeira API.");
        }

    }
}
