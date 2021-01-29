namespace Server.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromHeader] string source)
        {
            var response = $"Request from {source}. Response {DateTime.Now:O}";
            _logger.LogInformation(response);
            return response;
        }
    }
}