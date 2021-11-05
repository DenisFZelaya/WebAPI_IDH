using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_IDH.Context;
using WebAPI_IDH.Models;

namespace WebAPI_IDH.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SlcReferenciasController : ControllerBase
    {
        private readonly appDbContext _context;

        public SlcReferenciasController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/SlcReferencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SlcReferencia>>> GetSlcReferencia()
        {
            return await _context.SlcReferencia.ToListAsync();
        }

        // GET: api/SlcReferencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SlcReferencia>> GetSlcReferencia(decimal id)
        {
            var slcReferencia = await _context.SlcReferencia.FindAsync(id);

            if (slcReferencia == null)
            {
                return NotFound();
            }

            return slcReferencia;
        }

        // GET: api/Existe/5
        [HttpGet("Existe/{Codsolicitud_Id}")]
        public object GetClientesExiste(string Codsolicitud_Id)
        {
            return new
            {
                existe = _context.SlcReferencia.Any(c => c.CodsolicitudId == Codsolicitud_Id)
            };
        }

        // PUT: api/SlcReferencias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlcReferencia(decimal id, SlcReferencia slcReferencia)
        {
            if (id != slcReferencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(slcReferencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlcReferenciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SlcReferencias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SlcReferencia>> PostSlcReferencia(SlcReferencia slcReferencia)
        {
            _context.SlcReferencia.Add(slcReferencia);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SlcReferenciaExists(slcReferencia.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSlcReferencia", new { id = slcReferencia.Id }, slcReferencia);
        }

        // DELETE: api/SlcReferencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SlcReferencia>> DeleteSlcReferencia(decimal id)
        {
            var slcReferencia = await _context.SlcReferencia.FindAsync(id);
            if (slcReferencia == null)
            {
                return NotFound();
            }

            _context.SlcReferencia.Remove(slcReferencia);
            await _context.SaveChangesAsync();

            return slcReferencia;
        }

        private bool SlcReferenciaExists(decimal id)
        {
            return _context.SlcReferencia.Any(e => e.Id == id);
        }
    }
}
