using System;
using System.Collections.Generic;



namespace WebAPI_IDH.Models
{
    public partial class Solicitud
    {
        public string CodSolicitud { get; set; }
        public string Codubi { get; set; }
        public string Cliente { get; set; }
        public string Carnetimprema { get; set; }
        public string Prestamo { get; set; }
        public decimal Clase { get; set; }
        public decimal Vlcuota { get; set; }
        public decimal NumCuotas { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDictamen { get; set; }
        public decimal NivelManejo { get; set; }
        public decimal CodEstado { get; set; }
        public string Aval1 { get; set; }
        public decimal Sueldoaval1 { get; set; }
        public string Aval2 { get; set; }
        public decimal Sueldoaval2 { get; set; }
        public string Aval3 { get; set; }
        public decimal Sueldoaval3 { get; set; }
        public decimal MontoSolicitado { get; set; }
        public decimal MontoAprobado { get; set; }
        public decimal SaldoAport { get; set; }
        public decimal NuevaAportacion { get; set; }
        public decimal SueldoNeto { get; set; }
        public decimal SueldoMensual { get; set; }
        public decimal Oficial { get; set; }
        public decimal Oficial2 { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Operador { get; set; }
        public decimal Formapgo { get; set; }
        public string EmpreSaf { get; set; }
        public string Observaciones { get; set; }
        public string PlanRet { get; set; }
        public decimal Anio { get; set; }
        public decimal Frec { get; set; }
        public decimal Tpcredito { get; set; }
        public string Aval1Tpobligacion { get; set; }
        public string Aval2Tpobligacion { get; set; }
        public string Aval3Tpobligacion { get; set; }
        public string Aval1Tpgarantia { get; set; }
        public string Aval2Tpgarantia { get; set; }
        public string Aval3Tpgarantia { get; set; }
        public string NivelE { get; set; }
        public string Tprenegociacion { get; set; }
        public decimal Tipos { get; set; }
        public string Tpoperacion { get; set; }
        public decimal Moneda { get; set; }
        public decimal AbonoPrev { get; set; }
        public decimal IntProme { get; set; }
        public decimal MontoOriginal { get; set; }
        public string Aval5Tpobligacion { get; set; }
        public string Aval4Tpgarantia { get; set; }
        public string Aval4Tpobligacion { get; set; }
        public string Aval4 { get; set; }
        public string Aval5Tpgarantia { get; set; }
        public string Aval5 { get; set; }
        public string Dictamen { get; set; }
        public DateTime? FchSldo { get; set; }
        public decimal? Sueldoaval4 { get; set; }
        public decimal? Sueldoaval5 { get; set; }
        public DateTime FchCreado { get; set; }
        public string Fondo { get; set; }
        public string Programa { get; set; }
        public decimal CodAct { get; set; }
        public decimal Tpaval1 { get; set; }
        public decimal Tpaval2 { get; set; }
        public decimal Tpaval3 { get; set; }
        public decimal Tpaval4 { get; set; }
        public decimal Tpaval5 { get; set; }
        public decimal Cobertura1 { get; set; }
        public decimal Cobertura2 { get; set; }
        public decimal Cobertura3 { get; set; }
        public decimal Cobertura4 { get; set; }
        public decimal Cobertura5 { get; set; }
        public decimal Area { get; set; }
        public DateTime FchAprobado { get; set; }
        public string AprobadoPor { get; set; }
        public decimal Quiebra { get; set; }
        public string QuiebraRazon { get; set; }
        public DateTime QuiebraFch { get; set; }
        public decimal Arrestado { get; set; }
        public string ArrestadoRazon { get; set; }
        public decimal MalCredito { get; set; }
        public string CreditoRazon { get; set; }
        public decimal Manutencion { get; set; }
        public string RazonManu { get; set; }
        public DateTime FchVencimiento { get; set; }
        public string Acta { get; set; }
        public decimal CodResultPrecal { get; set; }
        public string Origen { get; set; }
        public decimal Tasa { get; set; }
        public decimal? ActualizaDireccion { get; set; }
        public decimal? TprenegociaDias { get; set; }
        public string PrestamoRenegocia { get; set; }
        public decimal? ActualizaDatosclie { get; set; }
        public decimal? ActualizaDatosneg { get; set; }
        public long? EstadoSolic { get; set; }
    }
}
