using Microsoft.EntityFrameworkCore;
using main.db;
using functions.Endpoint;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddOpenApi();
builder.Services.AddValidation();
builder.Services.AddDbContext<OefenDB>(
    options => options.UseNpgsql(connectionString));


var app = builder.Build();

app.MapAllProjectsEndpoints();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
        options.SwaggerEndpoint("/openapi/v1.json", "oefendb"));

}


app.UseHttpsRedirection();




app.Run();

