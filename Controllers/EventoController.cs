using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EventoApi.Models;
using EventoApi.Models.Enuns;
using EventoApi.Data;

namespace EventoApi.Controllers
{
    [ApiController]
    [Route("eventos")]
    
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }
        private static List<Evento> eventos = new List<Evento>()
        {
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
        };

      
        [HttpGet]
        public IActionResult GetEventos()
        {
            return Ok(eventos);
        }

        
        [HttpGet("{id}")]
        public IActionResult GetEvento(int id)
        {
            var evento = eventos.Find(e => e.Id == id);

            if (evento == null)
            {
                return NotFound();
            }

            return Ok(evento);
        }

        
        [HttpPost]
        public IActionResult PostEvento([FromBody] Evento novoEvento)
        {
            if (novoEvento == null)
            {
                return BadRequest();
            }

            novoEvento.Id = eventos.Count + 1;
            eventos.Add(novoEvento);

            return CreatedAtAction(nameof(GetEvento), new { id = novoEvento.Id }, novoEvento);
        }

     
        [HttpPut("{id}")]
        public IActionResult PutEvento(int id, [FromBody] Evento eventoAtualizado)
        {
            if (eventoAtualizado == null || id != eventoAtualizado.Id)
            {
                return BadRequest();
            }

            var eventoExistente = eventos.Find(e => e.Id == id);

            if (eventoExistente == null)
            {
                return NotFound();
            }

            eventoExistente.Nome = eventoAtualizado.Nome;
            eventoExistente.Data = eventoAtualizado.Data;
            eventoExistente.Local = eventoAtualizado.Local;
            eventoExistente.Artista = eventoAtualizado.Artista;
            eventoExistente.Classe = eventoAtualizado.Classe;

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteEvento(int id)
        {
            var evento = eventos.Find(e => e.Id == id);

            if (evento == null)
            {
                return NotFound();
            }

            eventos.Remove(evento);

            return NoContent();
        }
    }
}
