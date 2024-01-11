using Letsgo.Model;
using Microsoft.EntityFrameworkCore;

namespace Letsgo.Data{

    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<LetsTodos> Letsgo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
            modelBuilder.Entity<LetsTodos>().HasData(
                new LetsTodos { Id = 1, Name = "Brasília", Genre = "590", Price = 159.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/brasilia2.jpg" },
                new LetsTodos { Id = 2, Name = "São Paulo", Genre = "3.340", Price = 119.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/saopaulo2.jpg" },
                new LetsTodos { Id = 3, Name = "Curitiba", Genre = "610", Price = 109.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/Curitiba3.jpg" },
                new LetsTodos { Id = 4, Name = "Londrina", Genre = "590", Price = 99.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/londrina2.jpg" },
                new LetsTodos { Id = 5, Name = "Manaus", Genre = "188", Price = 99.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/manaus2.jpg" },
                new LetsTodos { Id = 6, Name = "Rio de Janeiro", Genre = "3.430", Price = 109.99M, letsURL = "https://agencialetsgo2.netlify.app/imagens/rio-de-janeiro2.jpg" }
            );
        }
    }
}