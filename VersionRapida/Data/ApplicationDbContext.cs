using Microsoft.EntityFrameworkCore;
using TechFixPro.Models;

using Microsoft.EntityFrameworkCore;
using TechFixPro.Models;

namespace TechFixPro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<OrdenServicio> OrdenesServicio { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}