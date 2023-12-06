using FogabaMailService.Models;
using FogabaMailService.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Servicios_CRM_Replica.Services;
using System.Diagnostics;

namespace FogabaMailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportuintyBaseController : ControllerBase
    {
        private OpportunityBaseServices opportunityServices;

        public OpportuintyBaseController(ProvMicroOpContext provMicroOpContext)
        {
            this.opportunityServices = new OpportunityBaseServices(provMicroOpContext);
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetOpportunitiesFogabaDoc()
        {
            try
            {
                APIResponse response = new APIResponse();

                if (opportunityServices == null) {
                    throw new Exception("OpportunityBaseServices is not initialized");
                }

                response.Result = opportunityServices.getOpportunities(); //retorna json
                response.StatusCode = System.Net.HttpStatusCode.OK;

                Debug.WriteLine("Result: " + response.Result);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
