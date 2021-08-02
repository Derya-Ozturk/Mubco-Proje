using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubco_Proje.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-CELPGIDF\\SQLEXPRESS; database=Mubco-Proje; " +
                "integrated security=true");

        }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Map> Maps { get; set; }
    }
}
