using System;
using System.Collections;
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
    public class LoginController : ControllerBase
    {
        private readonly appDbContext _context;
        List<Aldeas> LAldea = new List<Aldeas>();
        List<Lugarpoblado> LlugarPoblado = new List<Lugarpoblado>();

        public LoginController(appDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public object Index([FromForm] Usuarios usuario)
        {
            var userValid = _context.Usuarios
                .FirstOrDefault(u => u.Usu == usuario.Usu && u.Contrasena == usuario.Contrasena);

            if (userValid == null)
                return new
                {
                    login_valido = false
                };

            var agencia = _context.Agencia.Where(b => b.Codagencia == userValid.Codagencia).FirstOrDefault();

            return new
            {
                login_valido = true,
                usuario = userValid.Nombre,
                usu = userValid.Usu,
                tipousuario = userValid.Tipousuario.ToString(),
                nivelusuario = userValid.Nivelusuario.ToString(),
                codasesor = userValid.Codasesor.ToString(),
                estado = userValid.Estado.ToString(),
                email = userValid.Email,
                codagencia = userValid.Codagencia,
                nombreagencia = agencia.Nombreagencia,
                actualizar_tablas = true
            };
        }

        #region APICARGAINICIAL
        [HttpPost("CargaInicial")]
        public async Task<Object> CargaInicial([FromForm] Usuarios usuario)
        {
            if (usuario.Usu == null || usuario.Contrasena == null)
            {
                return new
                {
                    response = "Datos incorrectos"
                };
            }

            var userValido = _context.Usuarios
                .FirstOrDefault(u => u.Usu == usuario.Usu && u.Contrasena == usuario.Contrasena);

            if (userValido == null)
                return new
                {
                    login_valido = false
                };

            //Data locations
            var agencia = await _context.Agencia.Where(b => b.Codagencia == userValido.Codagencia).FirstOrDefaultAsync();
            var ciudad = await _context.Ciudades.Where(d => d.CodCiud == decimal.Parse(agencia.Codciudad)).FirstOrDefaultAsync();
            var aldeas = await _context.Aldeas.Where(d => d.CodCiud == decimal.Parse(ciudad.CodCiud.ToString())).FirstOrDefaultAsync();
            var depto = await _context.Deptos.Where(d => d.NumDepto == decimal.Parse(ciudad.NumDepto.ToString())).FirstOrDefaultAsync();

            //Get data from db
            List<Tpclientes> tpclientes = await _context.Tpclientes.ToListAsync();
            List<Identificacion> identificacion = await _context.Identificacion.ToListAsync();
            List<Paises> paises = await _context.Paises.ToListAsync();
            List<SectorEcono> sectorEcono = await _context.SectorEcono.ToListAsync();
            List<Ocupacion> ocupaciones = await _context.Ocupacion.ToListAsync();
            List<GrpEcon> grpEcon = await _context.GrpEcon.ToListAsync();
            List<Estadociv> estadociv = await _context.Estadociv.ToListAsync();
            List<Agencia> LAgencia = await _context.Agencia.Where(b => b.Codagencia == userValido.Codagencia).ToListAsync();
            List<Deptos> LDepto = await _context.Deptos.Where(d => d.NumDepto == decimal.Parse(ciudad.NumDepto.ToString())).ToListAsync();
            List<Ciudades> LCiudad = await _context.Ciudades.Where(d => d.NumDepto == depto.NumDepto).ToListAsync();

            LCiudad.ForEach((ciu) =>
            {
                List<Aldeas> aldeasOfCiud = _context.Aldeas.Where(ald => ald.CodCiud == ciu.CodCiud).ToList();
                LAldea.AddRange(aldeasOfCiud);
            });

            LAldea.ForEach((aldea) =>
            {
                List<Lugarpoblado> lgPoblado = _context.Lugarpoblado.Where(lp => lp.CodAldea == aldea.CodAldea).ToList();
                LlugarPoblado.AddRange(lgPoblado);
            });

            List<Clases> LClases = await _context.Clases.ToListAsync();
            List<Destinos> LDestinos = await _context.Destinos.Where(c => c.Destino != c.DestinoPadre).Where(c => c.DestinoPadre != " ").OrderBy(c => c.Destino).ToListAsync();
            List<Tpoperaciones> LtpOperaciones = await _context.Tpoperaciones.ToListAsync();
            List<ActividadFin> LactFin = await _context.ActividadFin.ToListAsync();
            List<Frecuenc> LFrecuencia = await _context.Frecuenc.ToListAsync();
            List<Tpgarantias> LTpGarantias = await _context.Tpgarantias.ToListAsync();
            List<Fondos> LFondos = await _context.Fondos.ToListAsync();
            List<Programa> LPrograma = await _context.Programa.ToListAsync();
            List<ClaseFondoProg> LCFP = await _context.ClaseFondoProg.ToListAsync();
            List<ClasesPlazo> LClasesPlazo = await _context.ClasesPlazo.ToListAsync();

            //Add data to body json
            Dictionary<string, IEnumerable> CICuerpo = new Dictionary<string, IEnumerable>();
            CICuerpo.Add("tpcliente", tpclientes);
            CICuerpo.Add("identificacion", identificacion);
            CICuerpo.Add("paises", paises);
            CICuerpo.Add("sector_econo", sectorEcono);
            CICuerpo.Add("t_ocupacion", ocupaciones);
            CICuerpo.Add("grp_economico", grpEcon);
            CICuerpo.Add("t_estadociv", estadociv);
            CICuerpo.Add("agencia", LAgencia);
            CICuerpo.Add("ciudad", LCiudad);
            CICuerpo.Add("departamento", LDepto);
            CICuerpo.Add("aldeas", LAldea);
            CICuerpo.Add("clases", LClases);
            CICuerpo.Add("destinos", LDestinos);
            CICuerpo.Add("tpoperaciones", LtpOperaciones);
            CICuerpo.Add("actividad_fin", LactFin);
            CICuerpo.Add("frecuencia", LFrecuencia);
            CICuerpo.Add("tp_garantias", LTpGarantias);
            CICuerpo.Add("fondos", LFondos);
            CICuerpo.Add("programa", LPrograma);
            CICuerpo.Add("lugar_poblado", LlugarPoblado);
            CICuerpo.Add("clase_fondo_programa", LCFP);
            CICuerpo.Add("clases_plazo", LClasesPlazo);

            return new
            {
                cargainicial = CICuerpo
            };
        }
        #endregion
    }
}
