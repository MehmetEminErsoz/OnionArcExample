using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        DbContextOptions options;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> _options) : base(_options)
        {
            options = _options;
        }
        
        public DbSet<Product> products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Product>()
            //    .HasData
          
        }

       
    }
}
