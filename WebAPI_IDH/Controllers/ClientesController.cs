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
    public class ClientesController : ControllerBase
    {
        private readonly appDbContext _context;

        public ClientesController(appDbContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> GetClientes(string id)
        {
            var clientes = await _context.Clientes.FindAsync(id);

            if (clientes == null)
            {
                return NotFound();
            }

            return clientes;
        }

        // GET: api/Existe/5
        [HttpGet("Existe/{cliente}")]
        public object GetClientesExiste(string cliente)
        {
            return new
            {
                existe = _context.Clientes.Any(c => c.Cliente == cliente)
            };
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<object>PutClientes(string id, Clientes clientes)
        {
            try
            {
                if (id != clientes.Cliente)
                {
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "id -> " + id + " no coincide con: " + clientes.Cliente,
                    };
                }

                _context.Entry(clientes).State = EntityState.Modified;
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Actualizada
                    return new
                    {
                        accion = "actualizar",
                        estado = true,
                        mensaje = "Cliente actualizado: " + clientes.Cliente,
                    };
                }
                else
                {
                    //No se puedo actualizar
                    return new
                    {
                        accion = "actualizar",
                        estado = false,
                        mensaje = "No se puedo actualizar el cliente: " + clientes.Cliente,
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

        // POST: api/Clientes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<object> PostClientes(Clientes clientes)
        {
            try
            {
                _context.Clientes.Add(clientes);
                if (await _context.SaveChangesAsync() > 0)
                {
                    //Crear
                    return new
                    {
                        accion = "crear",
                        estado = true,
                        mensaje = "Cliente creado: " + clientes.Cliente,
                    };
                }
                else
                {
                    return new
                    {
                        accion = "crear",
                        estado = false,
                        mensaje = "No se ha podido crear el cliente: " + clientes.Cliente,
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
            //return CreatedAtAction("GetClientes", new { id = clientes.Cliente }, clientes);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clientes>> DeleteClientes(string id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();

            return clientes;
        }

        private bool ClientesExists(string id)
        {
            return _context.Clientes.Any(e => e.Cliente == id);
        }
    }
}
