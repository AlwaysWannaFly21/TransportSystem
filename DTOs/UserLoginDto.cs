using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransportSystem.DTOs
{
    public class UserLoginDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
