using ClassroomBooking.Persistence;
using ClassroomBooking.Web;
using ClassroomBooking.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddPresentationLayer();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseExceptionHandling();

app.MapControllers();

app.Run();