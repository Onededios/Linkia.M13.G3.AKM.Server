using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) => _userService = userService;

        [HttpPost]
        [Route("SignIn")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoSignIn(UserSignInDTO request)
        {
            try
            {
                var response = await _userService.SignInAsync(request);
                return response != null ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPost]
        [Route("SignUp")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoSignUp(UserSignUpDTO request)
        {
            try
            {
                var response = await _userService.SignUpAsync(request);
                return response ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPut]
        [Route("ModifyUser")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoModifyUser(UserUpdateDTO request)
        {
            try
            {
                var response = await _userService.UpdateUserAsync(request);
                return response ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }
    }
}
