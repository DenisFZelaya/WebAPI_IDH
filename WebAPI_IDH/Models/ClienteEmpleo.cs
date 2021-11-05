using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class ClienteEmpleo
    {
        public long Codempleo { get; set; }
        public string NombEmpleador { get; set; }
        public decimal Estatus { get; set; }
        public decimal TrabPrincipal { get; set; }
        public decimal Zipcode { get; set; }
        public decimal NumDepto { get; set; }
        public decimal CodCiud { get; set; }
        public string Dir1 { get; set; }
        public string Dir2 { get; set; }
        public DateTime FchIngreso { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Supervisor { get; set; }
        public string Cargo { get; set; }
        public decimal HoraSemana { get; set; }
        public decimal SueldoHora { get; set; }
        public decimal IngresoSemanal { get; set; }
        public decimal IngresoCatorcenal { get; set; }
        public decimal IngresoMensual { get; set; }
        public string Cliente { get; set; }
        public string EmpreSaf { get; set; }
        public string CreadoPor { get; set; }
        public decimal Idsesion { get; set; }
        public DateTime FchCreado { get; set; }
        public DateTime FchRetiro { get; set; }
        public string Email { get; set; }
        public decimal FrecuenciaTrab { get; set; }
    }
}
