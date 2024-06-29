using System.Threading.Tasks;
using ConsultancyFirm.Application.DTOs;

namespace ConsultancyFirm.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
        Task<string> RegisterAdminAsync(RegisterDto registerDto);
        Task<string> RegisterPartnerAsync(RegisterDto registerDto);
    }
}
