using AKM.Server.Library.Contracts.DTOs;
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
                if (response == null) return BadRequest("Password is null");
                return Ok(response);
            }
            catch (Exception) { return StatusCode((int)HttpStatusCode.InternalServerError); }
        }

        [HttpGet]
        [Route("GetUserPasswords")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetUserPasswords(Guid user)
        {
            try { 
                var response = await _passwordService.GetPasswordsByUserAsync(user);
                if (response == null) return BadRequest("User is null");
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        [Route("CreatePassword")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GoCreatePassword(CreatePasswordDTO request)
        {
            try {
                var result = await _passwordService.CreatePasswordAsync(request);
                if (result) return Ok(result);
                return BadRequest("Password creation failed");
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        [Route("ModifyPassword")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GoModifyPassword(UpdatePasswordDTO request)
        {
            try {
                var result = await _passwordService.UpdatePasswordAsync(request);
                if (result) return Ok(result);
                return BadRequest("Password update failed");
            }
            catch (Exception) 
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

    }
}
