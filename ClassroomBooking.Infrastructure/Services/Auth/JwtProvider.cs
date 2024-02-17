using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Infrastructure.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ClassroomBooking.Infrastructure.Services.Auth;

internal sealed class JwtProvider
{
    private readonly JwtOptions _jwtOptions;
    private readonly JwtSecurityTokenHandler _tokenHandler;

    public JwtProvider(IOptions<JwtOptions> jwtOptions, JwtSecurityTokenHandler tokenHandler)
    {
        _jwtOptions = jwtOptions.Value;
        _tokenHandler = tokenHandler;
    }

    public string GenerateToken(User user)
    {
        var token = new JwtSecurityToken(
            issuer: _jwtOptions.Issuer,
            audience: _jwtOptions.Audience,
            claims: GetClaims(user),
            expires: DateTime.UtcNow.AddHours(_jwtOptions.LifetimeInHours),
            signingCredentials: GetSigningCredentials());
        
        var serializedToken = _tokenHandler.WriteToken(token);
        return serializedToken;
    }

    private SigningCredentials GetSigningCredentials()
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));
        return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
    }

    private static IEnumerable<Claim> GetClaims(User user) =>
    [
        new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
        new Claim(JwtRegisteredClaimNames.Email, user.Email),
        new Claim(JwtRegisteredClaimNames.Gender, user.Gender.ToString()),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    ];
}