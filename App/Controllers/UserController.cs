using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("login")]
        public LoginResponse Login([FromBody] LoginRequest request)
        {
            //mocks
            if (request.Username.Equals("admin"))
            {
                return new LoginResponse()
                {
                    Username = request.Username,
                    Role = "admin"
                };
            } else if (request.Username.Equals("user"))
            {
                return new LoginResponse()
                {
                    Username = request.Username,
                    Role = "user"
                };
            } else
            {
                throw new Exception();
            }
        }
    }
}

