using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.API.Models
{
    public class Evento
    {
        public int Id { get; set;}
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public string Tema { get; set; }
        public int Participantes { get; set; }
        public string Lote { get; set; }
        public string ImageURL { get; set; }

    }
}