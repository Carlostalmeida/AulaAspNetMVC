using LanchesKing.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesKing.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) :base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
