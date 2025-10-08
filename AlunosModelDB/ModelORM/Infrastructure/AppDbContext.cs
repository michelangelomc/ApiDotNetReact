using Microsoft.EntityFrameworkCore;
using ModelORM.Models;

namespace ModelORM.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<AlunoModel> AlunosSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoModel>(entity =>
            {
                entity.ToTable("Alunos");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd()
                      .IsRequired();
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Idade).IsRequired();
            });
        }
    }
}