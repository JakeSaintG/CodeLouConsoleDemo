using ConsoleDBTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBTest;

internal interface IDBReaderWriter
{
    Superhero GetHeroById(string id);
    void AddSuperHero();
    void ShowAllCatchPhrases();
}
