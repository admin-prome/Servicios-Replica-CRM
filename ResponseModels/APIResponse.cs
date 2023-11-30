using System.Net;

namespace FogabaMailService.ResponseModels
{
    public class APIResponse
    {
        public APIResponse()
        {
            this.ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;

        public List<string> ErrorMessages { get; set; }

        public object Result { get; set; }
    }
}
