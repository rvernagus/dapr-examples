using Dapr.Client;
using System.Net.Http.Json;

var httpClient = DaprClient.CreateInvokeHttpClient();
var result = await httpClient.PostAsJsonAsync("http://greetservice/greet", new Person("Ray"));
Console.WriteLine($"Received ==> {result}");
Console.WriteLine($"Content  ==> {await result.Content.ReadAsStringAsync()}");

var daprClient = new DaprClientBuilder().Build();
var greeting = await daprClient.InvokeMethodAsync<Person, string>("greetservice", "greet", new Person("Ray"));
Console.WriteLine($"Received Greeting ==> {greeting}");

public record Person(string Name);
