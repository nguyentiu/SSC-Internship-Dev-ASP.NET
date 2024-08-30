using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampleBackendApp.Repositories;
using SampleBackendApp.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using SampleBackendApp.Validators;
using SampleBackendApp.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<StudentValidator>());

// Register dependencies
builder.Services.AddTransient<IExampleService, ExampleService>();
builder.Services.AddScoped<IExampleRepository, ExampleRepository>();

// Enable Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<RequestLoggingMiddleware>(); // Ensure middleware is added
app.MapControllers();

app.Run();
