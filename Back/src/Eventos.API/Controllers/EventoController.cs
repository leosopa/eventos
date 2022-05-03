using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : Controller
    {

        private IEnumerable<Evento> _eventos = new Evento[]
            {
                new Evento(){
                    Id =1,
                    Tema = "Angular e .NET",
                    Local = "State College",
                    Lote = "1 Lote",
                    Participantes = 250,
                    Data = DateTime.Now.AddDays(5),
                },

                new Evento(){
                    Id =2,
                    Tema = "Mais um evento",
                    Local = "State College",
                    Lote = "4 Lote",
                    Participantes = 150,
                    Data = DateTime.Now.AddDays(10),
                }
            };
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            
            return _eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int Id){
            return _eventos.Where(e => e.Id == Id).FirstOrDefault();
        }

        [HttpPost]
        public string Post(){
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int Id){

            return $"Exemplo de put {Id}";

        }

        [HttpDelete("{id}")]
        public string Delete(int Id){
            return $"Delete {Id}";
        }

    }
}