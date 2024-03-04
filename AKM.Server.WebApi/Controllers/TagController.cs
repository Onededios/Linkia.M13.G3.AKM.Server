using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AKM.Server.WebApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    [Produces("application/json")]
    public class TagController : Controller
    {
        [HttpGet]
        [Route("GetTags")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoGetTags()
        {
            try { }
            catch (Exception ex) { }
        }

        [HttpPost]
        [Route("CreateTag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoCreateTag()
        {
            try { }
            catch (Exception ex) { }
        }

        [HttpPut]
        [Route("ModifyTag")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType ((int)HttpStatusCode.InternalServerError)]
        [Produces("application/json")]
        public async Task GoModifyTag(Guid tagId)
        {
            try { }
            catch (Exception ex) { }
        }
    }
}
