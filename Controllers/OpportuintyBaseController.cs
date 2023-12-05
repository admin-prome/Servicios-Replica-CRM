using FogabaMailService.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Servicios_CRM_Replica.Services;

namespace FogabaMailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportuintyBaseController : ControllerBase
    {
        private OpportunityBaseServices opportunityServices;
        public async Task<ActionResult<APIResponse>> GetOpportunitiesFogabaDoc()
        {
            try
            {
                APIResponse response = new APIResponse();

                response.Result = opportunityServices.getOpportunities(); //retorna json
                response.StatusCode = System.Net.HttpStatusCode.OK;

                return Ok(response);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
