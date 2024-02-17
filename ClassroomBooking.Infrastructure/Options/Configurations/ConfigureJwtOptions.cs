using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ClassroomBooking.Infrastructure.Options.Configurations;

internal sealed class ConfigureJwtOptions(IConfiguration configuration) : IConfigureOptions<JwtOptions>
{
    private const string SectionName = "JwtOptions";

    public void Configure(JwtOptions options) => configuration.GetSection(SectionName).Bind(options);
}