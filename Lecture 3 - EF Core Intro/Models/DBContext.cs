using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class AppDbConnect : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = database.db");
        }

        public DbSet<Patient> Patients {get;set;} = null!;
    }
}