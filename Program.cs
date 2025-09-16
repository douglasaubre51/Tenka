using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Tenka.Data;
using Tenka.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string conn_string = "server=localhost;user=root;database=tenka;password=chancellor66;";
// add postgres db
builder.Services.AddDbContext<ApplicationDbContext>((options) =>
	options.UseMySql(conn_string,ServerVersion.AutoDetect(conn_string))
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

// endpoints
app.MapGet(
	"/api/hello",
	() => {
		Console.WriteLine("clients says hello!");
		return Results.Ok();
	}
);

app.Run();
