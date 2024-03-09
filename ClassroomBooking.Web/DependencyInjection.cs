using System.Text.Json.Serialization;
using ClassroomBooking.Web.Middlewares;

namespace ClassroomBooking.Web;

public static class DependencyInjection
{
    public static void AddPresentationLayer(this IServiceCollection services)
    {
        services.AddControllers()
            .AddJsonOptions(config => config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        
        services.AddMiddlewares();
        services.AddCors(options =>
        {
            options.AddPolicy(
                "MyCors",
                policy =>
                {
                    policy
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });
    }

    private static void AddMiddlewares(this IServiceCollection services)
    {
        services.AddSingleton<ExceptionHandlingMiddleware>();
    }
}