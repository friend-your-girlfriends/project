﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication.Api.Services;
using WebApplication.Shared;
using WebApplication.Shared.User;

namespace WebApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // "AspNetUser" database table.
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        // /api/auth/register.
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.RegisterUserAsync(model);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid.");
        }

        // /api/auth/login
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.LoginUserAsync(model);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid.");
        }

        [HttpGet("Info")]
        public async Task<IActionResult> UserInfo()
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.UserInfoAsync();

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("some properties are not valid.");
        }
    }
}
