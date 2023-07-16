using ConsoleDBTest;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

var services = CreateServiceCollection();

Console.WriteLine("Superhero catchphrases:");

var getter = services.GetService<IGetFromDb>();

var Spidey = getter.GetSupById("123123123123");
var Superman = getter.GetSupById("123123123456");

Console.WriteLine($"{Spidey.Name} says: {Spidey.CatchPhrase}");
Console.WriteLine($"{Superman.Name} says: {Superman.CatchPhrase}");

static IServiceProvider CreateServiceCollection()
{
    return new ServiceCollection()
        .AddTransient<IGetFromDb, GetFromDb>()
        .AddDbContext<SupContext>()
        .BuildServiceProvider();
}