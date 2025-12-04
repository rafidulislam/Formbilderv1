
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Formbilderv1.Models
{
    // Fix: Inherit from DbContext to satisfy EF Core requirements and constructor signature
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FormModel> Forms { get; set; }
        public DbSet<FormField> Fields { get; set; }
        public DbSet<FormOption> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<FormModel>()
                .HasMany(f => f.Fields)
                .WithOne(f => f.FormModel)
                .HasForeignKey(f => f.FormModelId)
                .OnDelete(DeleteBehavior.Cascade);

            model.Entity<FormField>()
                .HasMany(f => f.Options)
                .WithOne(o => o.FormField)
                .HasForeignKey(o => o.FormFieldId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

}
