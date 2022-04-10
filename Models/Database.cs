using Microsoft.EntityFrameworkCore;
using System;

namespace Models
{
    public class Database:DbContext
    {
        public DbSet<Armia> Armie { get; set; }
        public DbSet<Bron> Bronie { get; set; }
        public DbSet<Dywizja> Dywizje { get; set; }
        public DbSet<Model> Modele { get; set; }
        public DbSet<Stopien> Stopnie { get; set; }
        public DbSet<Zgloszenie> Zgloszenia { get; set; }
        public DbSet<Zolnierz> Zolnierze { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Mati\\source\\repos\\projektTAIIB\\Models\\database.db");
        }
    }
}
