using Scalar.AspNetCore;
using Weather.Api.EndPoints.Weather;
using Weather.Application;

var builder = WebApplication.CreateBuilder(args);

// apoblete: obtengo la configuraci�n de appsettings.json
var config = builder.Configuration;

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// apoblete: inyecto lo que necesito del Middle Application
builder.Services.AddApplication(config["WeatherAPISettings:APIKEY"]!, config["WeatherAPISettings:MapURL"]!);

//apoblete: habilito acceso SOLAMENTE para pruebas
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
        policy
            .WithOrigins(config["ReactClient"]!)
            .AllowAnyMethod()
            .AllowAnyOrigin()
    );
});

var app = builder.Build();

app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // apoblete: En Core 9 yo est� inclu�do Swagger por lo que deja de ser un est�ndar.
    // En su lugar implementt� el paxkage Scalar
    // Para ver la documenta�i�n del API generado basta con basta con ingresar a {URL APP}/scalar/v1
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

// apoblete: Mapeo los Endpoint de Weather
app.MapWeatherEndpoints();

app.Run();
