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
    public class ConsulcentralesController : ControllerBase
    {
        private readonly appDbContext _context;

        public ConsulcentralesController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Consulcentrales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Consulcentrales>>> GetConsulcentrales()
        {
            return await _context.Consulcentrales.ToListAsync();
        }

        // GET: api/Consulcentrales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Consulcentrales>> GetConsulcentrales(int id)
        {
            var consulcentrales = await _context.Consulcentrales.FindAsync(id);

            if (consulcentrales == null)
            {
                return NotFound();
            }

            return consulcentrales;
        }

        // PUT: api/Consulcentrales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsulcentrales(int id, Consulcentrales consulcentrales)
        {
            if (id != consulcentrales.Idconsulta)
            {
                return BadRequest();
            }

            _context.Entry(consulcentrales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsulcentralesExists(id))
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

        // POST: api/Consulcentrales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostConsulcentrales(Consulcentrales consulcentrales)
        {
            try
            {
                _context.Consulcentrales.Add(consulcentrales);

                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "consulcentrales creada: " + consulcentrales.CedulaClie,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear consulcentrales: " + consulcentrales.CedulaClie,
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    accion = "crear",
                    estado = false,
                    mensaje = ex.Message,
                };
            }

            ////////////
            _context.Consulcentrales.Add(consulcentrales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsulcentrales", new { id = consulcentrales.Idconsulta }, consulcentrales);
        }

        // DELETE: api/Consulcentrales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Consulcentrales>> DeleteConsulcentrales(int id)
        {
            var consulcentrales = await _context.Consulcentrales.FindAsync(id);
            if (consulcentrales == null)
            {
                return NotFound();
            }

            _context.Consulcentrales.Remove(consulcentrales);
            await _context.SaveChangesAsync();

            return consulcentrales;
        }

        private bool ConsulcentralesExists(int id)
        {
            return _context.Consulcentrales.Any(e => e.Idconsulta == id);
        }
    }
}
