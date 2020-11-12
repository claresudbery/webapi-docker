using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi_docker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShinyController : ControllerBase
    {
        private readonly ILogger<ShinyController> _logger;

        public ShinyController(ILogger<ShinyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello, I am Clare's shiny new endpoint!";
        }
    }
}
