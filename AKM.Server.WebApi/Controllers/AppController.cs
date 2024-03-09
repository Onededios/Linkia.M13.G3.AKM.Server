using AKM.Server.Library.Contracts.DTOs;
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
        [Route("GetApplication")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetApplication(Guid id)
        {
            try
            {
                var response = await _appService.GetAppAsync(id);
                return response != null ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

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
                return response != null ? Ok(response) : BadRequest(response);

            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPost]
        [Route("CreateApplication")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoCreateApplication(AppCreateDTO dto)
        {
            try
            {
                var response = await _appService.CreateAppAsync(dto);
                return response != null ? Ok(response) : BadRequest(response);

            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPut]
        [Route("ModifyApplication")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoModifyApplication(AppUpdateDTO dto)
        {
            try
            {
                var response = await _appService.UpdateAppAsync(dto);
                return response ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }
    }
}
