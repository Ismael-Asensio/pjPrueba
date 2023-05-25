using Microsoft.EntityFrameworkCore;
using pjPrueba.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPrueba.Data
{
    internal class Context : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Details> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ToString());
        }
    }
}
