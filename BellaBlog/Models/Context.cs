using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBlog.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NMLSSPB\\SQLEXPRESS; database=BellaBlogDb; integrated security=true");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Place> Places { get; set; }

    }
}
