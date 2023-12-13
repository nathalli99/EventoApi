using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventoApi.Models;
using EventoApi.Models.Enuns;

namespace EventoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Evento> TB_EVENTOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>().HasData
            (
            new Evento() { Id = 1, Nome = "Neo City: The Link Tour", Data = new DateTime(2023, 01, 18), Local = "São Paulo, Vibra", Artista = "NCT 127", Classe = EventoEnum.Show },
            new Evento() { Id = 2, Nome = "The Dream Show II: In A Dream", Data = new DateTime(2023, 07, 04), Local = "São Paulo, Vibra", Artista = "NCT DREAM", Classe = EventoEnum.Show },
            new Evento() { Id = 3, Nome = "The Fellowship: Break the Wall Tour", Data = new DateTime(2023, 08, 26), Local = "São Paulo, Allianz Parque", Artista = "ATEEZ", Classe = EventoEnum.Show },
            new Evento() { Id = 4, Nome = "THE TOWN", Data = new DateTime(2023, 09, 02), Local = "São Paulo, Autódromo de Interlagos", Artista = "Bruno Mars, Post Malone...", Classe = EventoEnum.Festival },
            new Evento() { Id = 5, Nome = "Synk: Hyper Line Tour", Data = new DateTime(2023, 09, 11), Local = "São Paulo, Espaço Unimed", Artista = "aespa", Classe = EventoEnum.Show },
            new Evento() { Id = 6, Nome = "South American Tour", Data = new DateTime(2023, 10, 21), Local = "São Paulo, Allianz Parque", Artista = "Evanescence", Classe = EventoEnum.Show },
            new Evento() { Id = 7, Nome = "Soy Rebelde Tour", Data = new DateTime(2023, 11, 17), Local = "São Paulo, Allianz Parque", Artista = "RBD", Classe = EventoEnum.Show },
            new Evento() { Id = 8, Nome = "The Eras Tour", Data = new DateTime(2023, 11, 25), Local = "São Paulo, Allianz Parque", Artista = "Taylor Swift", Classe = EventoEnum.Show },
            new Evento() { Id = 9, Nome = "Ready To Be", Data = new DateTime(2024, 02, 07), Local = "São Paulo, Allianz Parque", Artista = "TWICE", Classe = EventoEnum.Show },
            new Evento() { Id = 10, Nome = "SHOW WHAT I HAVE", Data = new DateTime(2024, 06, 26), Local = "São Paulo, Espaço Unimed", Artista = "IVE", Classe = EventoEnum.Show }
            );
        }





    }
}