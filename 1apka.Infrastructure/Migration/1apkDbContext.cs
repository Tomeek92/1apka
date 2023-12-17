using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1apka.Infrastructure.Migration
{
    public class _1apkDbContext : DbContext
    {
        public DbSet<Domain.Entities._1apka> _1apkaa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=1apka;Trusted_Connection=True;");
        }


    }
}
