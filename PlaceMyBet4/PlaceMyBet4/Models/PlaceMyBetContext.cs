using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;

namespace PlaceMyBet4.Models
{
    public class PlaceMyBetContext : DbContext
    {
        internal object EventosExamen;

        public DbSet<Evento> Evento { get; set; } //Taula
        public DbSet<Mercado> Mercado { get; set; } //Taula
        public DbSet<Apuesta> Apuesta { get; set; } //Taula
        public DbSet<Usuario> Usuario { get; set; } //Taula
        public DbSet<Cuenta> Cuenta { get; set; } //Taula


        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
        }

        //Mètode de configuració
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=placemybet2;Uid=root;Pwd=''; SslMode = none");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia", "Madrid", DateTime.Now));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1000, 1.5, 1.9, 1.9, 50, 50, 1));
            modelBuilder.Entity<Usuario>().HasData(new Usuario(1, "Pau", "Monterde", 20));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(12, 1.5, 1.9, "over",20,DateTime.Now, 1,1000, 1));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(100, "Santander", 123456789, 1));
        
        }
    }
}