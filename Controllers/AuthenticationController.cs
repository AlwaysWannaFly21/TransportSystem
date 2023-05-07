using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using TransportSystem.DTOs;
using TransportSystem.Interfaces;
using TransportSystem.Models;

namespace TransportSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationRepository _authRepo;

        public AuthenticationController(IAuthenticationRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
            );
            if (!response.Success)
                return BadRequest(response);
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);

            HttpResponseMessage respMessaage = new HttpResponseMessage();

            var cookieOptions = new CookieOptions
            {
                HttpOnly = false,
                Secure = false, // if using HTTPS
                SameSite = SameSiteMode.Strict
            };

            HttpContext.Response.Cookies.Append("jwtToken", response.Data, cookieOptions);

            if (!response.Success)
                return BadRequest(response);
            return Ok(response);
        }
    }
}
