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
        public async Task<object> PutAvales(string id, Avales avales)
        {
            try
            {
                if (id != avales.Aval)
                {
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "id Aval -> " + id + " no coincide con: " + avales.Aval,
                    };
                }

                _context.Entry(avales).State = EntityState.Modified;
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Actualizada
                    return new
                    {
                        accion = "actualizar",
                        estado = true,
                        mensaje = "Aval actualizado: " + avales.Aval,
                    };
                }
                else
                {
                    //No se puedo actualizar
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "No se puedo actualizar el aval: " + avales.Aval,
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    accion = "actualizar",
                    estado = false,
                    mensaje = ex.Message,
                };
            }

        }

        // POST: api/Avales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<Object> PostAvales(Avales avales)
        {
            try
            {
                _context.Avales.Add(avales);
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "Aval creado: " + avales.Aval,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear el aval: " + avales.Aval,
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
