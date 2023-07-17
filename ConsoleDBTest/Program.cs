using ConsoleDBTest;
using Microsoft.Extensions.DependencyInjection;
using ConsoleDBTest.Utils;
using ConsoleDBTest.Repositories;

var services = CreateServiceCollection();

IDbUtils? utils = services.GetService<IDbUtils>();
IDBReaderWriter? dBReaderWriter = services.GetService<IDBReaderWriter>();

utils.EnsureDbExists();
bool run = true;

Console.WriteLine("=====================================");
Console.WriteLine("===Welcome to Hero Catchphrase DB!===");
Console.WriteLine("=====================================");

while (run)
{
    Console.WriteLine("Would you like to add to the DB or see what we have saved?");
    Console.WriteLine("-> Press 1 to add");
    Console.WriteLine("-> Press 2 to view");
    Console.WriteLine("-> Press 3 to exit");

    string input = Console.ReadLine();
    Console.WriteLine("");

    switch (input)
    {
        case "1":
            dBReaderWriter.AddSuperHero();
            break;
        case "2":
            Console.WriteLine("");
            dBReaderWriter.ShowAllCatchPhrases();
            break;
        case "3":
            Console.WriteLine("Quitting...");
            run = false;
            break;
        default:
            Console.WriteLine("Please try again.");
            break;
    }

    Console.WriteLine("");
}

//Leaving in Program.cs for now but could be moved elsewhere.
static IServiceProvider CreateServiceCollection()
{
    return new ServiceCollection()
        .AddTransient<IDBReaderWriter, DBReaderWriter>()
        .AddTransient<IDbUtils, DbUtils>()
        .AddDbContext<SupContext>()
        .BuildServiceProvider();
}