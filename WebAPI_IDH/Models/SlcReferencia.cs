using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Models
{
    public partial class SlcReferencia
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public decimal? Familiar { get; set; }
        public string Telefono { get; set; }
        public string EmpreSaf { get; set; }
        public string Direccion { get; set; }
        public decimal? Tpreferencia { get; set; }
        public string Cuenta { get; set; }
        public string Lugar { get; set; }
        public string Relacion { get; set; }
        public decimal? SldoDep { get; set; }
        public decimal? SldoAdeuda { get; set; }
        public decimal? CuotaMes { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public decimal? Zipcode { get; set; }
        public string Tpresidencia { get; set; }
        public decimal? TiempoResidir { get; set; }
        public string TelTrabajo { get; set; }
        public decimal? Confirmada { get; set; }
        public string Observacion { get; set; }
        public string Codsolicitud { get; set; }
        public string CodsolicitudId { get; set; }
    }
}
