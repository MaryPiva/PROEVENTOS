using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
                {
           
                }

        [HttpGet]
        public string Get()
        {
            return "Exemplo de get";
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id={id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id={id}";
        }

     
    }
}
