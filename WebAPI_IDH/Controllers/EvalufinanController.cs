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
    public class EvalufinanController : ControllerBase
    {
        private readonly appDbContext _context;

        public EvalufinanController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Evalufinan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evalufinan>>> GetEvalufinan()
        {
            return await _context.Evalufinan.ToListAsync();
        }

        // GET: api/Evalufinan/5
        [HttpGet("{id}")]
        public async Task<Evalufinan> GetEvalufinan(string id)
        {
            Evalufinan evalufinan = await _context.Evalufinan.Where(c => c.Codsolicitud == id).FirstOrDefaultAsync();
            return evalufinan;
        }

        [HttpGet("Existe/{codSolicitud}")]
        public object GetEvaluFinanExiste(string codSolicitud)
        {
            return new
            {
                existe = _context.Evalufinan.Any(c => c.Codsolicitud == codSolicitud)
            };
        }

        // PUT: api/Evalufinan/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<object> PutEvalufinan(string id, Evalufinan evalufinan)
        {
            

            if (id != evalufinan.Codsolicitud)
            {
                return new
                {
                    accion = "actualizar",
                    estado = false,
                    mensaje = "codEvaluacionFinanciera -> " + id + " no coincide con: " + evalufinan.Codsolicitud,
                };
            }

            Evalufinan evaluSaved  = await _context.Evalufinan.Where(c => c.Codsolicitud == evalufinan.Codsolicitud).FirstOrDefaultAsync();
            evalufinan.Idevalufin = evaluSaved.Idevalufin;

            _context.Entry(evaluSaved).State = EntityState.Detached;


            _context.Entry(evalufinan).State = EntityState.Modified;
            if (await _context.SaveChangesAsync() > 0)
            {
                //Actualizada
                return new
                {
                    accion = "actualizar",
                    estado = true,
                    mensaje = "Evaluacion Financiera actualizada: " + evalufinan.Codsolicitud,
                };
            }
            else
            {
                //No se puedo actualizar
                return new
                {
                    accion = "actualizar",
                    estado = false,
                    mensaje = "No se puedo actualizar la Evaluacion Financiera: " + evalufinan.Codsolicitud,
                };
            }
        }

        // POST: api/Evalufinan
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostEvalufinan(Evalufinan evalufinan)
        {
            _context.Evalufinan.Add(evalufinan);
            if (await _context.SaveChangesAsync() > 0)
            {
                //Crear
                return new
                {
                    accion = "crear",
                    estado = true,
                    mensaje = "Evalufinan creada: " + evalufinan.Codsolicitud,
                };
            }
            else
            {
                return new
                {
                    accion = "crear",
                    estado = false,
                    mensaje = "No se ha podido crear Evalufinan: " + evalufinan.Codsolicitud,
                };
            }
        }

        // DELETE: api/Evalufinan/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Evalufinan>> DeleteEvalufinan(string id)
        {
            var evalufinan = await _context.Evalufinan.FindAsync(id);
            if (evalufinan == null)
            {
                return NotFound();
            }

            _context.Evalufinan.Remove(evalufinan);
            await _context.SaveChangesAsync();

            return evalufinan;
        }

        private bool EvalufinanExists(long id)
        {
            return _context.Evalufinan.Any(e => e.Idevalufin == id);
        }
    }
}
