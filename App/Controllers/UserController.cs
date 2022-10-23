﻿using System.Threading.Tasks;
using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            return await _userService.Login(request);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<int>> Create([FromBody] CreateUserRequest request)
        {
            return Ok(await _userService.Create(request));
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<int>> Delete([FromBody] DeleteUserRequest request)
        {
            await _userService.Delete(request);
            return Ok();
        }
    }
}

