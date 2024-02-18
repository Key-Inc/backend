using System.IdentityModel.Tokens.Jwt;
using ClassroomBooking.Application.Common.Interfaces.Services;
using ClassroomBooking.Infrastructure.Options.Configurations;
using ClassroomBooking.Infrastructure.Services.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

namespace ClassroomBooking.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
        services.AddOptionConfigurations();
        services.AddHelpers();
        services.AddServices();
    }
    
    private static void AddOptionConfigurations(this IServiceCollection services)
    {
        services.ConfigureOptions<ConfigureJwtOptions>();
        services.ConfigureOptions<ConfigureJwtBearerOptions>();
    }

    private static void AddHelpers(this IServiceCollection services)
    {
        services.AddScoped<JwtSecurityTokenHandler>();
        services.AddScoped<JwtProvider>();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
    }
}