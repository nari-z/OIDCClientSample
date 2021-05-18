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
    public class TokenController : ControllerBase
    {
        private readonly ILogger<TokenController> _logger;

        public TokenController(ILogger<TokenController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(TokenRequest req)
        {
            Console.WriteLine($"Call Post /token. req: {req}");
            // TODO: request to keycloak
            // TODO: show result and token info.
            return;
        }
    }
}
