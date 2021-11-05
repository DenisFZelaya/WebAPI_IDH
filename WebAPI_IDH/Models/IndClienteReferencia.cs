using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class IndClienteReferencia
    {
        public decimal Idreferencia { get; set; }
        public string Cliente { get; set; }
        public decimal Tpreferencia { get; set; }
        public string Nombre { get; set; }
        public decimal EsFamiliar { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Relacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime FchCreado { get; set; }
        public string CreadoPor { get; set; }
        public string CedulaCliente { get; set; }
        public decimal Zipcode { get; set; }
        public string Email { get; set; }
        public string TelTrabajo { get; set; }
        public string Tpresidencia { get; set; }
        public decimal TiempoResidir { get; set; }
        public string NoCuenta { get; set; }
        public string Lugar { get; set; }
        public decimal Confirmada { get; set; }
    }
}
