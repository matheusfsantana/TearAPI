using LoomAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LoomAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Tear> Teares { get; set; }
        public DbSet<Erro> Erros { get; set; }
    }
}
