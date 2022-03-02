using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Model
{
    public class Context : DbContext
    {
        private string _databasePath;

        public DbSet<EFlat> Flats { get; set; }
        public DbSet<EFlat> Disttricts { get; set; }

        public Context(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
