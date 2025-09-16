var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

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
