using Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ExzampleProjectDb;Trusted_Connection=True;MultipleActiveResultSets=True");
        }


        public DbSet<Ogrenci>? ogrencis { get; set; }
    }
}
