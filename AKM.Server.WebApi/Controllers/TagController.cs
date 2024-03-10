using AKM.Server.Library.Contracts.DTOs;
using AKM.Server.Library.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;
        public TagController(ITagService tagService) => _tagService = tagService;

        [HttpGet]
        [Route("GetUserTags")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetUserTags(Guid id_user)
        {
            try
            {
                var response = await _tagService.GetTagsByUserAsync(id_user);
                return response != null ? Ok(response) : BadRequest(response);

            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpGet]
        [Route("GetTag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoGetTag(Guid id)
        {
            try
            {
                var response = await _tagService.GetTagAsync(id);
                return response != null ? Ok(response) : BadRequest(response);

            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPost]
        [Route("CreateTag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoCreateTag(TagDTO request)
        {
            try
            {
                var response = await _tagService.CreateTagAsync(request);
                return response ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }

        [HttpPut]
        [Route("ModifyTag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult> GoModifyTag(TagDTO request)
        {
            try
            {
                var response = await _tagService.UpdateTagAsync(request);
                return response ? Ok(response) : BadRequest(response);
            }
            catch (Exception ex) { return StatusCode((int)HttpStatusCode.InternalServerError, ex); }
        }
    }
}
