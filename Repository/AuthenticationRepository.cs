using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CryptSharp;
using Microsoft.AspNetCore.Mvc;
using TransportSystem.Interfaces;
using TransportSystem.Models;
using CryptSharp.Core.Utility;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;


namespace TransportSystem.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {

        private readonly IConfiguration _configuration;
        private readonly PublicTransportMonitoringContext _context;

        public AuthenticationRepository(PublicTransportMonitoringContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            var response = new ServiceResponse<int>();

            if (await UserExists(user.Username))
            {
                response.Success = false;
                response.Message = "User already exists";
                return response;
            }

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;   

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            response.Data = user.UserId;
            return response;
        }

        public async Task<ServiceResponse<string>> Login(string username, string password)
        {
            var response = new ServiceResponse<string>();

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Username.ToLower().Equals(username.ToLower()));

            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found";
            }
            else if (!VerifyPasswordHash(password, user.PasswordHash!, user.PasswordSalt!))
            {
                response.Success = false;
                response.Message = "Wrong password!";
            }
            else
            {
                response.Data = CreateToken(user);
            }

            return response;
        }

        public async Task<bool> UserExists(string username)
        {
            var exists = await _context.Users.AnyAsync(u => u.Username.Equals(username));
            return exists;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            const int workFactor = 1024;

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
            }
            passwordHash = SCrypt.ComputeDerivedKey(System.Text.Encoding.UTF8.GetBytes(password), passwordSalt, workFactor, 8, 1, null,
                128);
        }

        private bool VerifyPasswordHash(string password, in byte[] passwordHash, in byte[] passwordSalt)
        {
            const int workFactor = 1024;
            var computeHash = SCrypt.ComputeDerivedKey(System.Text.Encoding.UTF8.GetBytes(password), passwordSalt, workFactor, 8, 1, null,
                128);

            return computeHash.SequenceEqual(passwordHash);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>{
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.RoleName)
            };

            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token); // Token
        }
    }
}
