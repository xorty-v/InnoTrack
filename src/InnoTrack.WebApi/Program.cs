using InnoTrack.WebApi;
using InnoTrack.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddService();
services.AddPersistence(configuration);

services.AddEndpointsApiExplorer();
services.AddExceptionHandler<DefaultGlobalExceptionHandler>();

services.AddProblemDetails();
services.AddSwaggerGen();

services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

app.UseCors("AllowAll");
app.UseRouting();
app.MapControllers();

app.Run();