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
        public async Task<object> GetSlcReferencia(string id)
        {
            SlcReferencia slcReferencia = await _context.SlcReferencia.Where(c => c.CodsolicitudId == id).FirstOrDefaultAsync();
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
        [HttpPut("{codSol_Numero}")]
        public async Task<object> PutSlcReferencia(string codSol_Numero, SlcReferencia slcReferencia)
        {
            try
            {
                if (codSol_Numero != slcReferencia.CodsolicitudId)
                {
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "slcReferencia -> " + codSol_Numero + " no coincide con: " + slcReferencia.CodsolicitudId,
                    };
                }

                SlcReferencia slcSave = await _context.SlcReferencia.Where(c => c.CodsolicitudId == slcReferencia.CodsolicitudId).FirstOrDefaultAsync();
                slcReferencia.Id = slcSave.Id;

                _context.Entry(slcSave).State = EntityState.Detached;

                _context.Entry(slcReferencia).State = EntityState.Modified;
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Actualizada
                    return new
                    {
                        accion = "actualizar",
                        estado = true,
                        mensaje = "slcReferencia actualizada: " + slcReferencia.CodsolicitudId,
                    };
                }
                else
                {
                    //No se puedo actualizar
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "No se puedo actualizar la slcReferencia: " + slcReferencia.CodsolicitudId,
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

        // POST: api/SlcReferencias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostSlcReferencia(SlcReferencia slcReferencia)
        {
            try
            {
                _context.SlcReferencia.Add(slcReferencia);
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "slcReferencia creada: " + slcReferencia.CodsolicitudId,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear la slcReferencia: " + slcReferencia.CodsolicitudId,
                    };
                }
            }
            catch (Exception ex)
            {
                return new
                {
                    accion = "crear",
                    estado = false,
                    mensaje = ex,
                };
            }

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
