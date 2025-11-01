using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;

namespace DDACAssignment.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}
