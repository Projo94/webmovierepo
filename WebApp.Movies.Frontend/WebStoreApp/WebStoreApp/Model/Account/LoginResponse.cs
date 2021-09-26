using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model.Account
{
    public class LoginResponse
    {
        public string Token { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Id { get; set; }

        public DateTime Expiration { get; set; }

    }
}
