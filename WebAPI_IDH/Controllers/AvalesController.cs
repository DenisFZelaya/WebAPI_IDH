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
    public class AvalesController : ControllerBase
    {
        private readonly appDbContext _context;

        public AvalesController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Avales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avales>>> GetAvales()
        {
            return await _context.Avales.ToListAsync();
        }

        // GET: api/Avales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Avales>> GetAvales(string id)
        {
            var avales = await _context.Avales.FindAsync(id);

            if (avales == null)
            {
                return NotFound();
            }

            return avales;
        }

        // GET: api/Avales/5
        [HttpGet("Existe/{Aval}")]
        public object GetClientesExiste(string Aval)
        {
            return new
            {
                existe = _context.Avales.Any(c => c.Aval == Aval)
            };
        }

        // PUT: api/Avales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvales(string id, Avales avales)
        {
            if (id != avales.Aval)
            {
                return BadRequest();
            }

            _context.Entry(avales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvalesExists(id))
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

        // POST: api/Avales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Avales>> PostAvales(Avales avales)
        {
            _context.Avales.Add(avales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAvales", new { id = avales.Aval }, avales);
        }

        // DELETE: api/Avales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Avales>> DeleteAvales(string id)
        {
            var avales = await _context.Avales.FindAsync(id);
            if (avales == null)
            {
                return NotFound();
            }

            _context.Avales.Remove(avales);
            await _context.SaveChangesAsync();

            return avales;
        }

        private bool AvalesExists(string id)
        {
            return _context.Avales.Any(e => e.Aval == id);
        }
    }
}
