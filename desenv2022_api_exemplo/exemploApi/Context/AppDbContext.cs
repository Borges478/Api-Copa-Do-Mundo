
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploApi.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext()
        { }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Confederacao> Confederacao { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Pote> Pote { get; set; }
        public virtual DbSet<PotePais> PotePais { get; set;}
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<ParticipantesGrupo> ParticipantesGrupo { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
