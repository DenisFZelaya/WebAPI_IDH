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
    public class ExcepcionesAppMovilsController : ControllerBase
    {
        private readonly appDbContext _context;

        public ExcepcionesAppMovilsController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/ExcepcionesAppMovils
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExcepcionesAppMovil>>> GetExcepcionesAppMovil()
        {
            return await _context.ExcepcionesAppMovil.ToListAsync();
        }

        // GET: api/ExcepcionesAppMovils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExcepcionesAppMovil>> GetExcepcionesAppMovil(long id)
        {
            var excepcionesAppMovil = await _context.ExcepcionesAppMovil.FindAsync(id);

            if (excepcionesAppMovil == null)
            {
                return NotFound();
            }

            return excepcionesAppMovil;
        }

        // PUT: api/ExcepcionesAppMovils/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExcepcionesAppMovil(long id, ExcepcionesAppMovil excepcionesAppMovil)
        {
            try
            {
                if (id != excepcionesAppMovil.Id)
                {
                    return BadRequest();
                }

                _context.Entry(excepcionesAppMovil).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExcepcionesAppMovilExists(id))
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
            catch (Exception)
            {
                return NoContent();
            }


        }

        // POST: api/ExcepcionesAppMovils
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExcepcionesAppMovil>> PostExcepcionesAppMovil(ExcepcionesAppMovil excepcionesAppMovil)
        {
            _context.ExcepcionesAppMovil.Add(excepcionesAppMovil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExcepcionesAppMovil", new { id = excepcionesAppMovil.Id }, excepcionesAppMovil);
        }

        // DELETE: api/ExcepcionesAppMovils/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExcepcionesAppMovil>> DeleteExcepcionesAppMovil(long id)
        {
            var excepcionesAppMovil = await _context.ExcepcionesAppMovil.FindAsync(id);
            if (excepcionesAppMovil == null)
            {
                return NotFound();
            }

            _context.ExcepcionesAppMovil.Remove(excepcionesAppMovil);
            await _context.SaveChangesAsync();

            return excepcionesAppMovil;
        }

        private bool ExcepcionesAppMovilExists(long id)
        {
            return _context.ExcepcionesAppMovil.Any(e => e.Id == id);
        }
    }
}
