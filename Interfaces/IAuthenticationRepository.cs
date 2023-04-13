using Microsoft.AspNetCore.Mvc;
using TransportSystem.Models;

namespace TransportSystem.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}