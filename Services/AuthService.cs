using System.Runtime.InteropServices.JavaScript;
using DDACAssignment.Data;
using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DDACAssignment.Services
{
    public class AuthService(DDACDbContext context) : IAuthService
    {
        Task<TokenRequestResponseDto?> IAuthService.LoginAsync(UserDto request)
        {
            throw new NotImplementedException();
        }

        Task<TokenRequestResponseDto?> IAuthService.RefreshTokenAsync(RefreshTokenRequestDto request)
        {
            throw new NotImplementedException();
        }

        async Task<User?> IAuthService.RegisterAsync(UserDto request)
        {
            if (await context.Users.AnyAsync(u => u.Username == request.Username))
                return null;

            var user = new User();

            var hashedPassword = new PasswordHasher<User>()
                .HashPassword(user, request.Password);

            user.Username = request.Username;
            user.PasswordHash = hashedPassword;
            user.Email = request.Email;

            context.Users.Add(user);

            await context.SaveChangesAsync();
            return user;
        }
    }
}
