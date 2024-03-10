namespace ClassroomBooking.Infrastructure.Options;

internal sealed class JwtOptions
{
    public required string Key { get; set; }
    public required double LifetimeInHours { get; set; }
    
    public required string Issuer { get; set; }
    public required string Audience { get; set; }
}