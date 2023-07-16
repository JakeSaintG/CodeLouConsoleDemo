using ConsoleDBTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBTest;

internal interface IGetFromDb
{
    Superhero GetSupById(string id); 
}
