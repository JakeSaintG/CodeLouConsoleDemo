using ConsoleDBTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBTest;

public class GetFromDb : IGetFromDb
{
    private readonly SupContext _context;

    public GetFromDb(SupContext context)
    {
        _context = context;
    }

    public Superhero GetSupById(string id) { 
        var AllHeros = _context.Superheros.ToList();
        return _context.Superheros.SingleOrDefault(s => s.Id == id);
    }
}
