using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoodBlog.Models
{
    public class FoodBlogDbContext : DbContext
    {
        public FoodBlogDbContext()
        {
        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=FoodBlog;uid=root;pwd=root;");
        }

        public FoodBlogDbContext(DbContextOptions<FoodBlogDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
