using DDACAssignment.Dtos.TokenRequest;
using DDACAssignment.Dtos.User;
using DDACAssignment.Models;

namespace DDACAssignment.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(AuthDto request);
        Task<TokenResponseDto?> LoginAsync(AuthDto request);
        Task<TokenResponseDto?> RefreshTokenAsync(RefreshTokenRequestDto request);
    }
}
