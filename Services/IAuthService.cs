using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;

namespace DDACAssignment.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenRequestResponseDto?> LoginAsync(UserDto request);
        Task<TokenRequestResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}
