using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDBTest.Models;

public class Superhero
{
    [Key]
    public String Id { get; set; }
    public string? Name { get; set; }
    public string? CatchPhrase { get; set; }
}
