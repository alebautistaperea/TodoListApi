using Microsoft.EntityFrameworkCore;
using TodoListApi.Models;

namespace TodoListApi.Context
{
    public class CategoriaDBContext : DbContext {
        public CategoriaDBContext(DbContextOptions<CategoriaDBContext> options) : base(options) { }

        public DbSet<Categorias> Categoria { get; set; }
    }
    
}
