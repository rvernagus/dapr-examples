using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/greet", (HttpRequest request, Person person) =>
{
    return $"Hello, {person.Name}!";
});

app.Run("http://localhost:3500");

public record Person(string Name);