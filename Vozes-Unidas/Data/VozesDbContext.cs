using Microsoft.EntityFrameworkCore;
using Vozes_Unidas.Models;

namespace Vozes_Unidas.Data
{
    public class VozesDbContext : DbContext
    {
        public VozesDbContext(DbContextOptions<VozesDbContext> options) : base(options) { }

        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Especialistas> Especialistas { get; set; }
        public DbSet<Forum> Forum { get; set; }
        public DbSet<MaterialDidatico> MaterialDidatico { get; set; }
        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<Pretendente> Pretendente { get; set; }
        public DbSet<VagasEmprego> VagasEmprego { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentarios>().ToTable("tbComentarios");
            modelBuilder.Entity<Empresa>().ToTable("tbEmpresa");
            modelBuilder.Entity<Especialistas>().ToTable("tbEspecialistas");
            modelBuilder.Entity<Forum>().ToTable("tbForum");
            modelBuilder.Entity<MaterialDidatico>().ToTable("tbMaterialDidatico");
            modelBuilder.Entity<Noticias>().ToTable("tbNoticias");
            modelBuilder.Entity<Pretendente>().ToTable("tbPretendente");
            modelBuilder.Entity<VagasEmprego>().ToTable("tbVagasEmprego");
            modelBuilder.Entity<ApplicationUser>().ToTable("tbApplicationUser");
        }

    }
}
