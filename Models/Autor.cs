using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPowtorka.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        //relacje
        public ICollection<Ksiazka> Ksiazki { get; set; }
    }
}
