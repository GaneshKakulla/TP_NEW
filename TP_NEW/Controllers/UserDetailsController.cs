using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP_NEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hi how are you");
        }
    }
}
