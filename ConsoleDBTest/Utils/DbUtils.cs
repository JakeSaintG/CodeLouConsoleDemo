using ConsoleDBTest.Models;

namespace ConsoleDBTest.Utils;

public class DbUtils : IDbUtils
{
    private readonly SupContext _context;

    public DbUtils(SupContext context)
    {
        _context = context;
    }

    public void EnsureDbExists()
    {
        string path = Environment.CurrentDirectory.ToString() + "\\Superhero.db";

        if (!File.Exists(path))
        {
            _context.Database.EnsureCreated();

            Superhero Spiderman = new Superhero() 
            {
                Id = "3898e7f1-e13b-4ba9-89ea-d0d280aab581",
                Name = "Spider-Man",
                CatchPhrase = "With great power, comes great responsibility."
            };

            _context.Add(Spiderman);
            _context.SaveChanges();
        }
    }
}
