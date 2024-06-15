using CrudAspNetCoreX.Data.Map;
using CrudAspNetCoreX.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAspNetCoreX.Data
{
    public class BancoContent : DbContext
    {
        public BancoContent(DbContextOptions<BancoContent> options) :
        base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
      //  public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
