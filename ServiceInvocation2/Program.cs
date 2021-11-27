using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/greet", (Person person) => $"Hello, {person.Name}!");

app.Run("http://localhost:3500");

public record Person(string Name);