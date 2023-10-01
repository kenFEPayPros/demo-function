using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace DemoFunction
{
    public class Demo
    {
        private readonly ILogger _logger;

        public Demo(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Demo>();
        }

        [Function("Demo")]
        public HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] 
            HttpRequestData req)
        {


            var response = req.CreateResponse(HttpStatusCode.OK);

            return response;
        }
    }
}
