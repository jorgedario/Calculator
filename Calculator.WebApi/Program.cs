using Calculator.Core;
using Calculator.Core.Contracts;
using Calculator.Core.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<ICalculatorModule, CalculatorModule>();
builder.Services.AddTransient<ICalculatorFactory, CalculatorFactory>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Calculator", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Calculator.WebApi v1");
    c.RoutePrefix = "swagger.ui";
});

app.UseSwagger();

app.MapControllers();
app.UseExceptionHandler(builder=>

{
    builder.Run(async context =>
    {
        var exceptionHandlerPathFeature =
            context.Features.Get<IExceptionHandlerPathFeature>();
        var exception = exceptionHandlerPathFeature?.Error;
        var result = System.Text.Json.JsonSerializer.Serialize(new Calculator.WebApi.Models.Response<CalculatorResponse>  {Sucess=false, Message = exception?.Message });
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(result);
    });
})
;

app.Run();
