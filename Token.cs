using System;

namespace OIDCClientSample
{
    public class TokenRequest
    {
        public string GrantType { get; set; }

        public string Code { get; set; }

        public string RefreshToken { get; set; }
    }
}
