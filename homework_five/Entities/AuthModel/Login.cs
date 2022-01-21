using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.AuthModel
{
    public class Login
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
