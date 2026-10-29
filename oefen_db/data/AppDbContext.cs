using Microsoft.EntityFrameworkCore;
using Models.project;



namespace main.db;
public sealed class OefenDB : DbContext
{
         public OefenDB(DbContextOptions<OefenDB> options) : base(options) {}
         public DbSet<Project> Projects => Set<Project>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(project =>
        {
        project.ToTable("Projects");
        project.HasKey(p => p.Id);
        project.Property(p => p.Repo_link).IsRequired();
        project.Property(p => p.Title).IsRequired();
        project.Property(p => p.Img_alt).IsRequired();
        project.Property(p => p.Img_src).IsRequired();
        project.Property(p => p.Description).IsRequired();


        });
    }
}