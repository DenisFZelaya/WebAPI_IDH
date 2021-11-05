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
    public class SlcDestinosController : ControllerBase
    {
        private readonly appDbContext _context;

        public SlcDestinosController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/SlcDestinos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SlcDestinos>>> GetSlcDestinos()
        {
            return await _context.SlcDestinos.ToListAsync();
        }

        // GET: api/SlcDestinos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SlcDestinos>> GetSlcDestinos(string id)
        {
            var slcDestinos = await _context.SlcDestinos.FindAsync(id);

            if (slcDestinos == null)
            {
                return NotFound();
            }

            return slcDestinos;
        }

        // GET: api/Existe/5
        [HttpGet("Existe/{codSolicitud}")]
        public object GetClientesExiste(string codSolicitud)
        {
            return new
            {
                existe = _context.SlcDestinos.Any(c => c.CodSolicitud == codSolicitud)
            };
        }

        // PUT: api/SlcDestinos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlcDestinos(string id, SlcDestinos slcDestinos)
        {
            if (id != slcDestinos.CodSolicitud)
            {
                return BadRequest();
            }

            _context.Entry(slcDestinos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlcDestinosExists(id))
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

        // POST: api/SlcDestinos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SlcDestinos>> PostSlcDestinos(SlcDestinos slcDestinos)
        {
            _context.SlcDestinos.Add(slcDestinos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SlcDestinosExists(slcDestinos.CodSolicitud))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSlcDestinos", new { id = slcDestinos.CodSolicitud }, slcDestinos);
        }

        // DELETE: api/SlcDestinos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SlcDestinos>> DeleteSlcDestinos(string id)
        {
            var slcDestinos = await _context.SlcDestinos.FindAsync(id);
            if (slcDestinos == null)
            {
                return NotFound();
            }

            _context.SlcDestinos.Remove(slcDestinos);
            await _context.SaveChangesAsync();

            return slcDestinos;
        }

        private bool SlcDestinosExists(string id)
        {
            return _context.SlcDestinos.Any(e => e.CodSolicitud == id);
        }
    }
}
