using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<GameDto>

app.MapGet("/", () => "Hello World!");

app.Run();
