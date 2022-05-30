using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPowtorka.Models;

namespace TestPowtorka.DAL
{
    public class PowtorkaContext : DbContext
    {
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Autor> Autorzy { get; set; }

        public PowtorkaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor { Id = 1, Name = "Jacek", Surname = "Kowal"},
                new Autor { Id = 2, Name = "Franek", Surname = "Janosik"},
                new Autor { Id = 3, Name = "Michał", Surname = "Nowak"},
                new Autor { Id = 4, Name = "Bolesław", Surname = "Prus"}
                );

            modelBuilder.Entity<Ksiazka>().HasData(
                new Ksiazka { Id = 1, Title = "Groza", Description = "Horror z grozą", NumberOfPages = 100, AutorId = 1 },
                new Ksiazka { Id = 2, Title = "Mroz", Description = "Zimno", NumberOfPages = 150, AutorId = 2 },
                new Ksiazka { Id = 3, Title = "Pretty Woman", Description = "Dobra ksiazka", NumberOfPages = 200, AutorId = 3 },               
                new Ksiazka { Id = 4, Title = "Potop", Description = "Dużo wody", NumberOfPages = 300, AutorId = 4 },               
                new Ksiazka { Id = 5, Title = "Lalka", Description = "Zabawka dla dzieci", NumberOfPages = 200, AutorId = 3 }               
                );
        }
    }
}
