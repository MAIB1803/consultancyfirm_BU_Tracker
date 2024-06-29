using System.Threading.Tasks;
using ConsultancyFirm.Application.DTOs;
using ConsultancyFirm.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultancyFirm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);

            if (result == null)
            {
                return Unauthorized();
            }

            return Ok(result);
        }

        [HttpPost("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterDto registerDto)
        {
            var result = await _authService.RegisterAdminAsync(registerDto);

            if (string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }

            return Ok(new { UserId = result });
        }

        [HttpPost("register-partner")]
        public async Task<IActionResult> RegisterPartner([FromBody] RegisterDto registerDto)
        {
            var result = await _authService.RegisterPartnerAsync(registerDto);

            if (string.IsNullOrEmpty(result))
            {
                return BadRequest(result);
            }

            return Ok(new { UserId = result });
        }
    }
}
