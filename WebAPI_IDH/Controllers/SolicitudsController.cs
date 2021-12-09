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
    public class SolicitudsController : ControllerBase
    {
        private readonly appDbContext _context;

        public SolicitudsController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Solicituds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Solicitud>>> GetSolicitud()
        {
            return await _context.Solicitud.ToListAsync();
        }

        // GET: api/Solicituds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Solicitud>> GetSolicitud(string id)
        {
            var solicitud = await _context.Solicitud.FindAsync(id);

            if (solicitud == null)
            {
                return NotFound();
            }

            return solicitud;
        }

        // GET: api/Existe/5
        [HttpGet("Existe/{Codsolicitud}")]
        public object GetClientesExiste(string Codsolicitud)
        {
            return new
            {
                existe = _context.Solicitud.Any(c => c.CodSolicitud == Codsolicitud)
            };
        }

        // PUT: api/Solicituds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<object> PutSolicitud(string id, Solicitud solicitud)
        {
            try
            {
                if (id != solicitud.CodSolicitud)
                {
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "codSolicitud -> " + id + " no coincide con: " + solicitud.CodSolicitud,
                    };
                }

                _context.Entry(solicitud).State = EntityState.Modified;
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Actualizada
                    return new
                    {
                        accion = "actualizar",
                        estado = true,
                        mensaje = "Solicitud actualizada: " + solicitud.CodSolicitud,
                    };
                }
                else
                {
                    //No se puedo actualizar
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "No se puedo actualizar la solicitud: " + solicitud.CodSolicitud,
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

        // POST: api/Solicituds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostSolicitud(Solicitud solicitud)
        {
            try
            {
                _context.Solicitud.Add(solicitud);
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "Solicitud creada: " + solicitud.CodSolicitud,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear la solicitud: " + solicitud.CodSolicitud,
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

        // DELETE: api/Solicituds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Solicitud>> DeleteSolicitud(string id)
        {
            var solicitud = await _context.Solicitud.FindAsync(id);
            if (solicitud == null)
            {
                return NotFound();
            }

            _context.Solicitud.Remove(solicitud);
            await _context.SaveChangesAsync();

            return solicitud;
        }

        private bool SolicitudExists(string id)
        {
            return _context.Solicitud.Any(e => e.CodSolicitud == id);
        }
    }
}
