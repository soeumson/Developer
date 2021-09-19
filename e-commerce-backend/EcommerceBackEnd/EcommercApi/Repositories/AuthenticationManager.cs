using EcommercApi.Models;
using EcommercApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommercApi.Repositories
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IConfiguration _config;
        public AuthenticationManager(IConfiguration config)
        {
            _config = config;
        }
        public string GenerateJsonToken(UserModel userInfo)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.Username),
                new Claim("DateOfJoing", DateTime.Today.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                                 _config["Jwt:Issuer"],
                                                claims,
                                                expires: DateTime.Now.AddMinutes(10),
                                                signingCredentials: credentials);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong while generate token" + ex);
            }
        }
    }
}
