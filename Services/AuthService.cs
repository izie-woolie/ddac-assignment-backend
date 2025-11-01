using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;

namespace DDACAssignment.Services
{
    public class AuthService : IAuthService
    {
        Task<TokenRequestResponseDto?> IAuthService.LoginAsync(UserDto request)
        {
            throw new NotImplementedException();
        }

        Task<TokenRequestResponseDto?> IAuthService.RefreshTokenAsync(RefreshTokenRequestDto request)
        {
            throw new NotImplementedException();
        }

        Task<User?> IAuthService.RegisterAsync(UserDto request)
        {
            throw new NotImplementedException();
        }
    }
}
