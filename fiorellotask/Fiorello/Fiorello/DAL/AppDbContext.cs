using Fiorello.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Expertt> Expertts { get; set; }
        public DbSet<ExpertPosition> ExpertPositions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Carusel> Carusels { get; set; }
    }
}
