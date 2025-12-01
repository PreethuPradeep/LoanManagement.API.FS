using LoanManagement.Preethu.Api.Models;
using LoanManagement.Preethu.Api.Models.DTOs;
using LoanManagement.Preethu.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LoanManagement.Preethu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepo;
        private readonly IConfiguration config;
        public AuthController(IAuthRepository authRepo, IConfiguration config)
        {
            this.authRepo = authRepo;
            this.config = config;
        }
        //register
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var existing = await authRepo.FindByEmailAsync(dto.Email);
            if (existing != null)
            {
                var message = "Email is already registered!";
                return BadRequest(new { message });
            }
            var user = new UserProfile
            {
                UserName = dto.Email,
                Email = dto.Email,
                FullName = dto.FullName
            };
            var result = await authRepo.RegisterUserAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await authRepo.AddToRoleAsync(user, dto.Role);
            var msg = "User registered successfully!";
            return Ok(msg);
        }
        //login
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await authRepo.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                var msg = "Invalid Credentials!";
                return Unauthorized(msg);
            }
            bool CoorectPassword = await authRepo.CheckPasswordAsync(user, dto.Password);
            if (!CoorectPassword)
            {
                var msg = "Invalid Credentials!";
                return Unauthorized(msg);
            }
            var roles = await authRepo.GetRolesAsync(user);
            var token = GenerateJwtToken(user, roles);
            return Ok(new
            {
                token,
                userId = user.Id,
                fullName = user.FullName,
                email = user.Email,
                roles
            });
        }
        //generateToken
        private string GenerateJwtToken(UserProfile user, IList<string> roles)
        {
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(config["JwtSettings:SecretKey"])
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                new Claim(JwtRegisteredClaimNames.Email, user.Email ?? ""),
                new Claim("fullname", user.FullName ?? "")
            };

            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));

            var token = new JwtSecurityToken(
                issuer: config["JwtSettings:Issuer"],
                audience: config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(config["JwtSettings:ExpiryMinutes"])),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        //changePassword
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto dto)
        {
            var user = await authRepo.FindByIdAsync(dto.UserId);
            if (user == null)
            {
                string msg1 = "No such User Exists in Database!";
                return BadRequest(msg1);
            }
            var result = await authRepo.ChangePasswordAsync(user, dto.oldPassword, dto.newPassword);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            string msg = "ChangePassword Changed Successfully!";
            return Ok(msg);
        }
    }
}
