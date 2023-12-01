using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Interview_Web_API.Models;

namespace Interview_Web_API.Database
{

    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }



    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Interview_Web_API_Connection");
            }
        }


            public DbSet<Project>Projects { get; set; }
            public DbSet<User> Users { get; set; }
    }
    
}
