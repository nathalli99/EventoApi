using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventoApi.Models.Enuns;

namespace EventoApi.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Local { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public EventoEnum Classe { get; set;}
    }
}