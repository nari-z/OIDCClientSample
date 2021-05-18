using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OIDCClientSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallbackController : ControllerBase
    {
        private readonly ILogger<CallbackController> _logger;

        public CallbackController(ILogger<CallbackController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            // TODO: view callback.html
            // TODO: post to /token
            Console.WriteLine("Call Get /callback");
            return;
        }
    }
}
