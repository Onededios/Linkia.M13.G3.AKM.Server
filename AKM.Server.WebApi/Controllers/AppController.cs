using AKM.Server.Library.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class AppController : Controller
    {
        private readonly IAppService _appService;
        public AppController(IAppService appService) => _appService = appService;

        [HttpGet]
        [Route("GetApplications")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetApplications()
        {
            try
            {
                var response = await _appService.GetAllAppsAsync();
                if (response == null) return BadRequest("There aren't apps");
                return Ok(response);
            }
            catch (Exception) { return StatusCode((int)HttpStatusCode.InternalServerError); }
        }
    }
}
