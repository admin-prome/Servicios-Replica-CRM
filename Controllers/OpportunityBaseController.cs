using FogabaMailService.Models;
using FogabaMailService.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Servicios_CRM_Replica.Services;
using System.Diagnostics;

namespace FogabaMailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunityBaseController : ControllerBase
    {
        private OpportunityBaseServices opportunityServices;

        public OpportunityBaseController(ProvMicroOpContext provMicroOpContext)
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

                response.Result = opportunityServices.getOpportunities();

                if (response.Result == null)
                {
                    response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    return BadRequest("Empty result");
                }
                response.StatusCode = System.Net.HttpStatusCode.OK;

                return response;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
