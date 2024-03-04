using AKM.Server.Library.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class PasswordController : Controller
    {
        private readonly IPasswordService _passwordService;

        public PasswordController (IPasswordService passwordService) => _passwordService = passwordService;

        [HttpGet]
        [Route("GetPasswords")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoGetPasswords()
        {
            try { }
            catch (Exception ex) { }
        }

        [HttpGet]
        [Route("GetPassword")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetPassword(Guid password)
        {
            try 
            {
                var response = await _passwordService.GetPasswordAsync(password);
                if (response == null) throw new Exception("Password is null");
                return Ok(response);
            }
            catch (Exception ex) 
            {
                return Problem(detail: ex.Message, statusCode: 400);
            }
        }

        [HttpPost]
        [Route("CreatePassword")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoCreatePassword()
        {
            try { }
            catch (Exception ex) { }
        }

        [HttpPut]
        [Route("ModifyPassword")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoModifyPassword()
        {
            try { }
            catch (Exception ex) { }
        }

    }
}
