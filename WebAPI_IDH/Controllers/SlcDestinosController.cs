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
        public async Task<object> PutSlcDestinos(string id, SlcDestinos slcDestinos)
        {
            try
            {
                if (id != slcDestinos.CodSolicitud)
                {
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "slc_destino -> " + id + " no coincide con: " + slcDestinos.CodSolicitud,
                    };
                }

                _context.Entry(slcDestinos).State = EntityState.Modified;
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Actualizada
                    return new
                    {
                        accion = "actualizar",
                        estado = true,
                        mensaje = "slc_destino actualizada: " + slcDestinos.CodSolicitud,
                    };
                }
                else
                {
                    //No se puedo actualizar
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "No se puedo actualizar la slc_destino: " + slcDestinos.CodSolicitud,
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

        // POST: api/SlcDestinos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostSlcDestinos(SlcDestinos slcDestinos)
        {
            try
            {
                _context.SlcDestinos.Add(slcDestinos);
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "slc_destino creado: " + slcDestinos.CodSolicitud,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear el slc_destino: " + slcDestinos.CodSolicitud,
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
