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
    public class ClareForecastController : ControllerBase
    {
        private readonly ILogger<ClareForecastController> _logger;

        public ClareForecastController(ILogger<ClareForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello, I am Clare's weather forecast. It might rain, but you'll be OK. Skin is waterproof!";
        }
    }
}
