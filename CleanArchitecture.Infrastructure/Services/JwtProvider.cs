using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Infrastructure.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitecture.Infrastructure.Services
{
    internal sealed class JwtProvider(
    IOptions<JwtOptions> options, UserManager<AppUser> userManager) : IJwtProvider
    {
        public async Task<string> CreateTokenAsync(AppUser user, string password, CancellationToken cancellationToken = default)
        {
            var roles = await userManager.GetRolesAsync(user);
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim("Username", user.UserName ?? string.Empty),
                new Claim("FullName", user.Ad)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var expires = DateTime.Now.AddDays(1);

            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(options.Value.SecretKey));
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512);

            JwtSecurityToken securityToken = new(
                issuer: options.Value.Issuer,
                audience: options.Value.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: signingCredentials);

            JwtSecurityTokenHandler handler = new();

            string token = handler.WriteToken(securityToken);

            return token;
        }
    }
}
