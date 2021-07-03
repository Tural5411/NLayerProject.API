using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NLayerProject.Core.Model;
using NLayerProject.Data.Configurations;
using NLayerProject.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Personal> Personals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonalConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1,2}));
            //modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
        }
    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("data source=DESKTOP-RJ4V287\\SQLEXPRESS;initial catalog=NlayerProject;integrated security=True;MultipleActiveResultSets=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
