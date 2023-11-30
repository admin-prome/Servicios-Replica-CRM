using FogabaMailService.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace FogabaMailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportuintyBaseController : ControllerBase
    {

        public async Task<ActionResult<APIResponse>> GetOpportunitiesFogabaDoc()
        {
            try
            {
                return Ok("response ok");
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
