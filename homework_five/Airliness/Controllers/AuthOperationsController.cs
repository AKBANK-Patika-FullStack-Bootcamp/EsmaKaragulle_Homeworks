
using DataAccess.Abstract;
using Entities.AuthModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airliness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthOperationsController : ControllerBase
    {
        public static Login login = new Login();
        private readonly IConfiguration _configuration;
        private MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        private IAPIAuthorityDal _context;



        public AuthOperationsController(IConfiguration configuration, IAPIAuthorityDal context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("create")]
        public bool loginCreate(APIAuthority _user)
        {
            _user.Password = MD5Hash(_user.Password);
            _context.CreateLogin(_user);
            return true;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromHeader] LoginDto request)
        {
            APIAuthority tokenUser = new APIAuthority();
            tokenUser.UserName = request.Username;
            tokenUser.Password = MD5Hash(request.Password);

            APIAuthority result = _context.GetLogin(tokenUser);

            if (result != null)
            {
                string token = CreateToken(login);
                return Ok(token);

            }
            else
            {
                return BadRequest("Kullanıcı yok ya da şifre hatalı.");
            }

        }


        private string CreateToken(Login login)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, login.Username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        public string MD5Hash(string _input)
        {

            byte[] dizi = Encoding.UTF8.GetBytes(_input);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
