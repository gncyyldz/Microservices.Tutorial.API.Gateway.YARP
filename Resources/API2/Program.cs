var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api2", () => "API 2");

app.Run();