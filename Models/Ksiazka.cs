using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPowtorka.Models
{
    public class Ksiazka
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public int AutorId { get; set; }

        //relacje
        public Autor Autor { get; set; }
    }
}
