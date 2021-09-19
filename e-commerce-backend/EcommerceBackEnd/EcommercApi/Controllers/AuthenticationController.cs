using EcommercApi.Models;
using EcommercApi.Models.ResponseModel;
using EcommercApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommercApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAuthenticationManager _authentication;
        public AuthenticationController(IConfiguration config, IAuthenticationManager authentication)
        {
            _config = config;
            _authentication = authentication;
        }
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody] UserModel login)
        {
            if (login.Username == _config["Jwt:Username"] && login.Password == _config["Jwt:Password"])
            {
                try
                {
                    var tokenString = _authentication.GenerateJsonToken(login);
                    return Ok(new AuthorizeModel
                    {
                        Code=2000,
                        Message="success",
                        Token=tokenString
                    });
                }
                catch (Exception ex)
                {
                    Log.Error("Something went while generate token " + ex);
                    return Ok(new AuthorizeModel
                    {
                        Code = 2001,
                        Message = "UnAuthorize",
                        Token = null
                    });
                }
            }
            return Ok(new AuthorizeModel
            {
                Code = 2001,
                Message = "UnAuthorize",
                Token = null
            });

        }
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new { value = "hello" });
        }
    }
}
