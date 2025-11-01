﻿using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;
using DDACAssignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDACAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(AuthDto request)
        {
            var user = await authService.RegisterAsync(request);

            if (user is null)
                return BadRequest("Username is already exists!");

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDto>> Login(AuthDto request)
        {
            var result = await authService.LoginAsync(request);
            if (result is null)
                return BadRequest("Invalid username or password");

            return Ok(result);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDto>> RefreshToken(RefreshTokenRequestDto request)
        {
            var result = await authService.RefreshTokenAsync(request);

            if (result is null)
                return Unauthorized("Invalid Refresh Token");

            if (result.AccessToken is null)
                return Unauthorized("Invalid Refresh Token");

            if (result.RefreshToken is null)
                return Unauthorized("Invalid Refresh Token");

            return Ok(result);
        }
    }
}
