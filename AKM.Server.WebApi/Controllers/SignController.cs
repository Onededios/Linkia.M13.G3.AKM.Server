using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using AKM.Server.Library.Impl.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class SignController : Controller
    {
        private readonly ISignService _signService;
        public SignController(ISignService signService) => _signService = signService;

        [HttpPost]
        [Route("SignIn")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoSignIn(SignInDTO request)
        {
            try
            {
                var response = await _signService.SignIn(request);
                if (response == null) return BadRequest("User is null");
                return Ok(response);
            }
            catch (Exception) { return StatusCode((int)HttpStatusCode.InternalServerError); }
        }

        [HttpPost]
        [Route("SignUp")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoSignUp(SignUpDTO request)
        {
            try
            {
                var result = await _signService.SignUp(request);
                if (result) return Ok(result);
                return BadRequest("User creation failed");
            }
            catch (Exception) { return StatusCode((int)HttpStatusCode.InternalServerError); }
        }
    }
}
