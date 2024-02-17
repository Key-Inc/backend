using System.IdentityModel.Tokens.Jwt;
using ClassroomBooking.Application.Common.Interfaces.Services;
using ClassroomBooking.Domain.Entities.Enums;
using ClassroomBooking.Infrastructure.Models;
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
        services.AddAuthorization();
        services.AddOptionConfigurations();
        services.AddHelpers();
        services.AddServices();
    }

    private static void AddAuthorization(this IServiceCollection services)
    {
        services.AddAuthorizationBuilder()
            .AddPolicy(Policy.Admin, policy => Policy.Configure(policy, UserRole.Admin))
            .AddPolicy(Policy.Dean, policy => Policy.Configure(policy, UserRole.Dean))
            .AddPolicy(Policy.Student, policy => Policy.Configure(policy, UserRole.Student))
            .AddPolicy(Policy.Teacher, policy => Policy.Configure(policy, UserRole.Teacher));
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