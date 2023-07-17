using ConsoleDBTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBTest;

public class DBReaderWriter : IDBReaderWriter
{
    private readonly SupContext _context;

    public DBReaderWriter(SupContext context)
    {
        _context = context;
    }

    public void ShowAllCatchPhrases() 
    {
        Console.WriteLine("Showing all saved catchphrases:");
        _context.Superheros.ToList().ForEach(h => { 
            Console.WriteLine($"- {h.Name} once said: {h.CatchPhrase}");
        });
    }

    public Superhero GetHeroById(string id) 
    { 
        return _context.Superheros.SingleOrDefault(s => s.Id == id);
    }

    public void AddSuperHero() 
    {
        Superhero hero = new Superhero();
        hero.Id = Guid.NewGuid().ToString();

        Console.WriteLine("What's this hero's name?");

        string heroName = Console.ReadLine();
        if (heroName.Length > 40)
        {
            Console.WriteLine("That's an awfully long hero name...why don't we try again.");
            return;
        }

        Console.WriteLine("What's their catch phrase?");

        string heroCatchPhrase = Console.ReadLine();

        hero.Id = Guid.NewGuid().ToString();
        hero.Name = heroName;
        hero.CatchPhrase = heroCatchPhrase;

        _context.Superheros.Add(hero);
        _context.SaveChanges();
    }
}
