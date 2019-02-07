using System;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options) : base(options)
        {
            
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
