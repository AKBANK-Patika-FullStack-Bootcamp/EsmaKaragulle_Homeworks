using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.AuthModel
{
    public class LoginDto
    {
        [FromHeader]
        public string Username { get; set; } = string.Empty;
        [FromHeader]
        public string Password { get; set; } = string.Empty;
    }
}
