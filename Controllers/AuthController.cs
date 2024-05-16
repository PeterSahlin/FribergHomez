using FribergHomez.Const;
using FribergHomez.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FribergHomez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<RealEstateAgent> userManager;
        private readonly IConfiguration config;

        public AuthController(UserManager<RealEstateAgent> userManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.config = config;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<AuthResponse>> Login(LoginDTO loginDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(loginDto.Email);
                var passwordValid = await userManager.CheckPasswordAsync(user, loginDto.Password);
                if (user == null || passwordValid == false)
                {
                    return NotFound();
                }
                string tokenString = await GenerateToken(user);
                var response = new AuthResponse
                {
                    Email = loginDto.Email,
                    Token = tokenString,
                    UserId = user.Id
                };
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        private async Task<string> GenerateToken(RealEstateAgent user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                config["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();
            var userClaims = await userManager.GetClaimsAsync(user);
            var claims = new List<Claim>
            {
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName), new Claim(
                JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(CustomClaimTypes.Uid, user.Id)
            }
            .Union(roleClaims)
            .Union(userClaims);

            var token = new JwtSecurityToken(
                issuer: config["JwtSettings:Issuer"],
                audience: config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(config["JwtSettings: DurationInMinutes"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
