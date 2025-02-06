using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {   
            _context = context;
        }

        // GET: api/eventos
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var eventos = await _context.Eventos.AsNoTracking().ToListAsync();
                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }

        // GET: api/eventos/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var evento = await _context.Eventos.AsNoTracking().FirstOrDefaultAsync(e => e.EventoId == id);

                if (evento == null) return NotFound($"Evento com ID {id} não encontrado.");

                return Ok(evento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno: {ex.Message}");
            }
        }

        // POST: api/eventos
        [HttpPost]
        public async Task<IActionResult> Post(Evento evento)
        {
            try
            {
                _context.Eventos.Add(evento);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetById), new { id = evento.EventoId }, evento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar evento: {ex.Message}");
            }
        }
    }
}
