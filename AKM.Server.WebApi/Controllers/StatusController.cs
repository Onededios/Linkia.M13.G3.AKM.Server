using Microsoft.AspNetCore.Mvc;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class StatusController : Controller
    {
        [HttpGet]
        [Route("GetStatus")]
        public IActionResult GetStatus()
        {
            return Ok();
        }
    }
}
