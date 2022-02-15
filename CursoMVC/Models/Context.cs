using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
