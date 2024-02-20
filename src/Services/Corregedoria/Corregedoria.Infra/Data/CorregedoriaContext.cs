using Corregedoria.Domain.Entidades;
using Microsoft.EntityFrameworkCore;




namespace Corregedoria.Infra.Data
{
    public  class CorregedoriaContext : DbContext
    {
        public CorregedoriaContext(DbContextOptions <CorregedoriaContext> options):base (options) { }

        public DbSet<Instauracao> Instauracoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CorregedoriaContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
