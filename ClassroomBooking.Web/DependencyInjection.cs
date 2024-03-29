using System.Text.Json.Serialization;
using ClassroomBooking.Web.Middlewares;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ClassroomBooking.Web;

public static class DependencyInjection
{
    public static void AddPresentationLayer(this IServiceCollection services)
    {
        services.AddControllers(options =>
            {
                options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
            })
            .AddJsonOptions(config => config.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
        
        services.AddMiddlewares();
    }

    private static void AddMiddlewares(this IServiceCollection services)
    {
        services.AddSingleton<ExceptionHandlingMiddleware>();
    }
}