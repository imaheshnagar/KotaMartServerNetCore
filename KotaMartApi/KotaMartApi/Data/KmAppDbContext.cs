using KotaMartApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace KotaMartApi.Data
{
    public class KmAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\KmDatabase\\KotaMartDb.db");
        }

        public DbSet<KmAppUser> AppUser { get; set; }
    
    }
}
