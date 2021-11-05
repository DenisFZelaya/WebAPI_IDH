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
    public class GarantiasController : ControllerBase
    {
        private readonly appDbContext _context;

        public GarantiasController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Garantias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Garantias>>> GetGarantias()
        {
            return await _context.Garantias.ToListAsync();
        }

        // GET: api/Garantias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Garantias>> GetGarantias(string id)
        {
            var garantias = await _context.Garantias.FindAsync(id);

            if (garantias == null)
            {
                return NotFound();
            }

            return garantias;
        }

        // GET: api/Existe/5
        [HttpGet("Existe/{aval}")]
        public object GetClientesExiste(string aval)
        {
            return new
            {
                existe = _context.Avales.Any(c => c.Aval == aval)
            };
        }

        // PUT: api/Garantias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGarantias(string id, Garantias garantias)
        {
            if (id != garantias.Aval)
            {
                return BadRequest();
            }

            _context.Entry(garantias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GarantiasExists(id))
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

        // POST: api/Garantias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Garantias>> PostGarantias(Garantias garantias)
        {
            _context.Garantias.Add(garantias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGarantias", new { id = garantias.Aval }, garantias);
        }

        // DELETE: api/Garantias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Garantias>> DeleteGarantias(string id)
        {
            var garantias = await _context.Garantias.FindAsync(id);
            if (garantias == null)
            {
                return NotFound();
            }

            _context.Garantias.Remove(garantias);
            await _context.SaveChangesAsync();

            return garantias;
        }

        private bool GarantiasExists(string id)
        {
            return _context.Garantias.Any(e => e.Aval == id);
        }
    }
}
