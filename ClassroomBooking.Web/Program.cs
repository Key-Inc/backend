using ClassroomBooking.Application;
using ClassroomBooking.Infrastructure;
using ClassroomBooking.Persistence;
using ClassroomBooking.Web;
using ClassroomBooking.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

const string myAllowSpecificOrigins = "AppCors";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddInfrastructureLayer();
builder.Services.AddPresentationLayer();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(myAllowSpecificOrigins);
app.Services.AddAutoMigration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseExceptionHandling();
app.UseCors();
app.MapControllers();

app.Run();