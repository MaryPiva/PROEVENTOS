using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        private readonly DataContext context;
      
        public EventoController(DataContext context)
        {   
            this.context = context;
            this.Context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> get(){
            return _Context.Eventos;
        }

        [HttpGet ("{id}")]
        public IEnumerable<Evento> getById(int id){
            return _Context.Eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost ]  

        public string Post(){
            return "Exemplo Post";
        }
    }
}
