using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class IndClienteResidencia
    {
        public string Cliente { get; set; }
        public decimal Agua { get; set; }
        public decimal AguasNegras { get; set; }
        public decimal Luz { get; set; }
        public decimal Cable { get; set; }
        public decimal Ladrillo { get; set; }
        public decimal Bloque { get; set; }
        public decimal Adobe { get; set; }
        public decimal Otros { get; set; }
        public decimal Miembros { get; set; }
        public decimal CntTrabajan { get; set; }
        public DateTime FchRecidir { get; set; }
        public DateTime FchAlquilar { get; set; }
        public decimal PagoMensual { get; set; }
        public decimal MonedaPago { get; set; }
        public string CreadoPor { get; set; }
        public DateTime FchCreado { get; set; }
        public string EmpreSaf { get; set; }
        public decimal Madera { get; set; }
        public decimal IdDir { get; set; }
    }
}
