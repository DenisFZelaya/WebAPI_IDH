using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAPI_IDH.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IDH.Context
{
    public partial class appDbContext : DbContext
    {
        public appDbContext()
        {
        }

        public appDbContext(DbContextOptions<appDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActividadFin> ActividadFin { get; set; }
        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<Aldeas> Aldeas { get; set; }
        public virtual DbSet<AppMovil> AppMovil { get; set; }
        public virtual DbSet<Archivos> Archivos { get; set; }
        public virtual DbSet<Avales> Avales { get; set; }
        public virtual DbSet<Bancadeudahistoria> Bancadeudahistoria { get; set; }
        public virtual DbSet<BandSolicitud> BandSolicitud { get; set; }
        public virtual DbSet<Bandeuda> Bandeuda { get; set; }
        public virtual DbSet<Bandeudaanterior> Bandeudaanterior { get; set; }
        public virtual DbSet<Bandeudaatrasos24meses> Bandeudaatrasos24meses { get; set; }
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Calculates> Calculates { get; set; }
        public virtual DbSet<Candidateinfo> Candidateinfo { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClaseFondoProg> ClaseFondoProg { get; set; }
        public virtual DbSet<Clases> Clases { get; set; }
        public virtual DbSet<ClasesPlazo> ClasesPlazo { get; set; }
        public virtual DbSet<ClienteEmpleo> ClienteEmpleo { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Comportamientoobligaciones> Comportamientoobligaciones { get; set; }
        public virtual DbSet<Comportamientopago> Comportamientopago { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<Confcorreo> Confcorreo { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Consultatransunion> Consultatransunion { get; set; }
        public virtual DbSet<Controlreporte> Controlreporte { get; set; }
        public virtual DbSet<Correo> Correo { get; set; }
        public virtual DbSet<Datosgenerales> Datosgenerales { get; set; }
        public virtual DbSet<Deptos> Deptos { get; set; }
        public virtual DbSet<Destinos> Destinos { get; set; }
        public virtual DbSet<Deucomer> Deucomer { get; set; }
        public virtual DbSet<Deucomeranterior> Deucomeranterior { get; set; }
        public virtual DbSet<Deucomerhistorico> Deucomerhistorico { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Direccione> Direccione { get; set; }
        public virtual DbSet<Direcciones> Direcciones { get; set; }
        public virtual DbSet<Equifax> Equifax { get; set; }
        public virtual DbSet<Estadociv> Estadociv { get; set; }
        public virtual DbSet<Evalufinan> Evalufinan { get; set; }
        public virtual DbSet<ExcepcionesAppMovil> ExcepcionesAppMovil { get; set; }
        public virtual DbSet<Factordecambio> Factordecambio { get; set; }
        public virtual DbSet<Fiadorescomercio> Fiadorescomercio { get; set; }
        public virtual DbSet<Fondos> Fondos { get; set; }
        public virtual DbSet<Frecuenc> Frecuenc { get; set; }
        public virtual DbSet<Garantias> Garantias { get; set; }
        public virtual DbSet<GrpEcon> GrpEcon { get; set; }
        public virtual DbSet<Identificacion> Identificacion { get; set; }
        public virtual DbSet<Identificacionsujeto> Identificacionsujeto { get; set; }
        public virtual DbSet<Imgservidor> Imgservidor { get; set; }
        public virtual DbSet<IndClienteNegocio> IndClienteNegocio { get; set; }
        public virtual DbSet<IndClienteReferencia> IndClienteReferencia { get; set; }
        public virtual DbSet<IndClienteResidencia> IndClienteResidencia { get; set; }
        public virtual DbSet<IscIndVar> IscIndVar { get; set; }
        public virtual DbSet<IscIndicador> IscIndicador { get; set; }
        public virtual DbSet<IscOperadores> IscOperadores { get; set; }
        public virtual DbSet<IscVariable> IscVariable { get; set; }
        public virtual DbSet<Lugarpoblado> Lugarpoblado { get; set; }
        public virtual DbSet<Modelosprod> Modelosprod { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Nivelusuario> Nivelusuario { get; set; }
        public virtual DbSet<Obligacionescerradas> Obligacionescerradas { get; set; }
        public virtual DbSet<Obligacionesvigentes> Obligacionesvigentes { get; set; }
        public virtual DbSet<Ocupacion> Ocupacion { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<Programa> Programa { get; set; }
        public virtual DbSet<Prueba1> Prueba1 { get; set; }
        public virtual DbSet<RiesgoactividadDestino> RiesgoactividadDestino { get; set; }
        public virtual DbSet<Riesgoagencia> Riesgoagencia { get; set; }
        public virtual DbSet<Riesgobitacora> Riesgobitacora { get; set; }
        public virtual DbSet<Riesgocategorizacion> Riesgocategorizacion { get; set; }
        public virtual DbSet<Riesgoclientes> Riesgoclientes { get; set; }
        public virtual DbSet<Riesgodepartamentos> Riesgodepartamentos { get; set; }
        public virtual DbSet<Riesgoestadocivil> Riesgoestadocivil { get; set; }
        public virtual DbSet<Riesgogenero> Riesgogenero { get; set; }
        public virtual DbSet<Riesgoinfornet> Riesgoinfornet { get; set; }
        public virtual DbSet<Riesgoinstrumentomonetario> Riesgoinstrumentomonetario { get; set; }
        public virtual DbSet<Riesgomunicipio> Riesgomunicipio { get; set; }
        public virtual DbSet<Riesgoofac> Riesgoofac { get; set; }
        public virtual DbSet<Riesgoonu> Riesgoonu { get; set; }
        public virtual DbSet<RiesgoorigenSector> RiesgoorigenSector { get; set; }
        public virtual DbSet<Riesgopeps> Riesgopeps { get; set; }
        public virtual DbSet<Riesgoprofesionoficio> Riesgoprofesionoficio { get; set; }
        public virtual DbSet<Riesgos> Riesgos { get; set; }
        public virtual DbSet<Riesgosector> Riesgosector { get; set; }
        public virtual DbSet<Riesgosparametros> Riesgosparametros { get; set; }
        public virtual DbSet<Riesgotipopersona> Riesgotipopersona { get; set; }
        public virtual DbSet<Riesgotipos> Riesgotipos { get; set; }
        public virtual DbSet<Riesgousuarios> Riesgousuarios { get; set; }
        public virtual DbSet<Scoreactual> Scoreactual { get; set; }
        public virtual DbSet<Scorehistorico> Scorehistorico { get; set; }
        public virtual DbSet<SectorEcono> SectorEcono { get; set; }
        public virtual DbSet<Sincronizacion> Sincronizacion { get; set; }
        public virtual DbSet<SlcDestinos> SlcDestinos { get; set; }
        public virtual DbSet<SlcEstado> SlcEstado { get; set; }
        public virtual DbSet<SlcReferencia> SlcReferencia { get; set; }
        public virtual DbSet<SldoPmo> SldoPmo { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Tardeuda> Tardeuda { get; set; }
        public virtual DbSet<Tardeudaanterior> Tardeudaanterior { get; set; }
        public virtual DbSet<Tardeudaextrafinanciamiento> Tardeudaextrafinanciamiento { get; set; }
        public virtual DbSet<Tardeudahistorica> Tardeudahistorica { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<Telefonotransunion> Telefonotransunion { get; set; }
        public virtual DbSet<Tpclientes> Tpclientes { get; set; }
        public virtual DbSet<Tpgarantias> Tpgarantias { get; set; }
        public virtual DbSet<Tpoperaciones> Tpoperaciones { get; set; }
        public virtual DbSet<Transunion> Transunion { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VContar> VContar { get; set; }
        public virtual DbSet<Validsession> Validsession { get; set; }
        public virtual DbSet<Vectorhistorico> Vectorhistorico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=192.168.11.3;port=5432;Username=postgres;Password=IDHsistemas*10;Database=DigitaliPrb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActividadFin>(entity =>
            {
                entity.HasKey(e => e.CodAct)
                    .HasName("actividad_fin_pkey");

                entity.ToTable("actividad_fin");

                entity.Property(e => e.CodAct)
                    .HasColumnName("cod_act")
                    .HasColumnType("numeric");

                entity.Property(e => e.DescAct)
                    .IsRequired()
                    .HasColumnName("desc_act");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasColumnName("sigla");
            });

            modelBuilder.Entity<Agencia>(entity =>
            {
                entity.HasKey(e => e.Codagencia)
                    .HasName("agencia_pkey");

                entity.ToTable("agencia");

                entity.Property(e => e.Codagencia).HasColumnName("codagencia");

                entity.Property(e => e.Codciudad)
                    .IsRequired()
                    .HasColumnName("codciudad");

                entity.Property(e => e.Nombreagencia)
                    .IsRequired()
                    .HasColumnName("nombreagencia");

                entity.Property(e => e.Nombreciudad)
                    .IsRequired()
                    .HasColumnName("nombreciudad");

                entity.Property(e => e.Region).HasColumnName("region");
            });

            modelBuilder.Entity<Aldeas>(entity =>
            {
                entity.HasKey(e => e.CodAldea)
                    .HasName("aldeas_pkey");

                entity.ToTable("aldeas");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)");

                entity.Property(e => e.Aldea)
                    .IsRequired()
                    .HasColumnName("aldea")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.EsCabecera)
                    .HasColumnName("es_cabecera")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.EsRural)
                    .HasColumnName("es_rural")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<AppMovil>(entity =>
            {
                entity.ToTable("app_movil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualizarTablas).HasColumnName("actualizar_tablas");
            });

            modelBuilder.Entity<Archivos>(entity =>
            {
                entity.HasKey(e => e.Idarchivo)
                    .HasName("archivos_pkey");

                entity.ToTable("archivos");

                entity.Property(e => e.Idarchivo)
                    .HasColumnName("idarchivo")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Codsolicitud)
                    .IsRequired()
                    .HasColumnName("codsolicitud");

                entity.Property(e => e.Fchcreado)
                    .IsRequired()
                    .HasColumnName("fchcreado");

                entity.Property(e => e.Idconcepto).HasColumnName("idconcepto");

                entity.Property(e => e.Nombrearchivo)
                    .IsRequired()
                    .HasColumnName("nombrearchivo");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("ubicacion");
            });

            modelBuilder.Entity<Avales>(entity =>
            {
                entity.HasKey(e => e.Aval)
                    .HasName("avales_pkey");

                entity.ToTable("avales");

                entity.Property(e => e.Aval)
                    .HasColumnName("aval")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.AnioConstitucion)
                    .HasColumnName("anio_constitucion")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Claseg)
                    .HasColumnName("claseg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ClsAval)
                    .HasColumnName("cls_aval")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cobertura)
                    .HasColumnName("cobertura")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodAldeaNac)
                    .HasColumnName("cod_aldea_nac")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodDeptoNac)
                    .HasColumnName("cod_depto_nac")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodLugpob)
                    .HasColumnName("cod_lugpob")
                    .HasColumnType("numeric(12,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Codubi)
                    .HasColumnName("codubi")
                    .HasDefaultValueSql("'0100'::text");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CreadoPor)
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DatosLaborales)
                    .HasColumnName("datos_laborales")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estado_civil")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchAdq)
                    .HasColumnName("fch_adq")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchEscritura)
                    .HasColumnName("fch_escritura")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FolioConstitucion)
                    .HasColumnName("folio_constitucion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FuenteIngreso)
                    .HasColumnName("fuente_ingreso")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.GiroEmpleo)
                    .HasColumnName("giro_empleo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.GpsLatitud)
                    .HasColumnName("gps_latitud")
                    .HasDefaultValueSql("'14.0839154'::text");

                entity.Property(e => e.GpsLongitud)
                    .HasColumnName("gps_longitud")
                    .HasDefaultValueSql("'-87.205376'::text");

                entity.Property(e => e.Idcl)
                    .HasColumnName("idcl")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Ingreso)
                    .HasColumnName("ingreso")
                    .HasColumnType("numeric(11,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NegocioPropio)
                    .HasColumnName("negocio_propio")
                    .HasDefaultValueSql("'P'::text");

                entity.Property(e => e.NoConstitucion)
                    .HasColumnName("no_constitucion")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NombComer)
                    .HasColumnName("nomb_comer")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Notaria)
                    .HasColumnName("notaria")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumCiudNac)
                    .HasColumnName("num_ciud_nac")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operador)
                    .HasColumnName("operador")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.PaisDeId)
                    .HasColumnName("pais_de_id")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.Profesion)
                    .HasColumnName("profesion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ReferCedula)
                    .HasColumnName("refer_cedula")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ReferPersonal)
                    .HasColumnName("refer_personal")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ReferTelFijo)
                    .HasColumnName("refer_tel_fijo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ReferTelMovil)
                    .HasColumnName("refer_tel_movil")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RegProFolio)
                    .HasColumnName("reg_pro_folio")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RegProToma)
                    .HasColumnName("reg_pro_toma")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlCodAldea)
                    .HasColumnName("rl_cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("80101");

                entity.Property(e => e.RlCodDepto)
                    .HasColumnName("rl_cod_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.RlDir1)
                    .HasColumnName("rl_dir1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlFchNac)
                    .HasColumnName("rl_fch_nac")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.RlGenero)
                    .HasColumnName("rl_genero")
                    .HasDefaultValueSql("'N'::text");

                entity.Property(e => e.RlId)
                    .HasColumnName("rl_id")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlLugarNac)
                    .HasColumnName("rl_lugar_nac")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlNacionalidad)
                    .HasColumnName("rl_nacionalidad")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.RlNombre)
                    .HasColumnName("rl_nombre")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlNumCiud)
                    .HasColumnName("rl_num_ciud")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("801");

                entity.Property(e => e.RlProfesion)
                    .HasColumnName("rl_profesion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RlTipoId)
                    .HasColumnName("rl_tipo_id")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Rtn)
                    .HasColumnName("rtn")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Sector)
                    .HasColumnName("sector")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Secuencia)
                    .HasColumnName("secuencia")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasDefaultValueSql("'N'::text");

                entity.Property(e => e.TelMovil)
                    .HasColumnName("tel_movil")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TipoDeId)
                    .HasColumnName("tipo_de_id")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.TipoIdentificacion)
                    .HasColumnName("tipo_identificacion")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpaval)
                    .HasColumnName("tpaval")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpegdivisa)
                    .HasColumnName("tpegdivisa")
                    .HasDefaultValueSql("'ZZ'::text");

                entity.Property(e => e.Tprelacion)
                    .HasColumnName("tprelacion")
                    .HasDefaultValueSql("'Z'::text");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ZipcodeRl)
                    .HasColumnName("zipcode_rl")
                    .HasColumnType("numeric(5,0)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Bancadeudahistoria>(entity =>
            {
                entity.HasKey(e => e.Bandeudahistoricaid)
                    .HasName("bancadeudahistoria_pkey");

                entity.ToTable("bancadeudahistoria");

                entity.Property(e => e.Bandeudahistoricaid)
                    .HasColumnName("bandeudahistoricaid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CodiFnte).HasColumnName("codi_fnte");

                entity.Property(e => e.FechOtor).HasColumnName("fech_otor");

                entity.Property(e => e.NumeLine).HasColumnName("nume_line");

                entity.Property(e => e.NumeRefe).HasColumnName("nume_refe");

                entity.Property(e => e.PeriActu).HasColumnName("peri_actu");

                entity.Property(e => e.PeriLine).HasColumnName("peri_line");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.TipoCred).HasColumnName("tipo_cred");
            });

            modelBuilder.Entity<BandSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("band_solicitud_pkey");

                entity.ToTable("band_solicitud");

                entity.Property(e => e.IdSolicitud).HasColumnName("id_solicitud");

                entity.Property(e => e.CodAgencia)
                    .IsRequired()
                    .HasColumnName("cod_agencia");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.IdClase)
                    .IsRequired()
                    .HasColumnName("id_clase");

                entity.Property(e => e.IdCliente)
                    .IsRequired()
                    .HasColumnName("id_cliente");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Monto)
                    .IsRequired()
                    .HasColumnName("monto");
            });

            modelBuilder.Entity<Bandeuda>(entity =>
            {
                entity.ToTable("bandeuda");

                entity.Property(e => e.Bandeudaid)
                    .HasColumnName("bandeudaid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Actividadeconomica).HasColumnName("actividadeconomica");

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Categoriariesgo).HasColumnName("categoriariesgo");

                entity.Property(e => e.Codigoestado).HasColumnName("codigoestado");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.Codigomoneda).HasColumnName("codigomoneda");

                entity.Property(e => e.Codigosucursal).HasColumnName("codigosucursal");

                entity.Property(e => e.Conteo00).HasColumnName("conteo00");

                entity.Property(e => e.Conteo120).HasColumnName("conteo120");

                entity.Property(e => e.Conteo150).HasColumnName("conteo150");

                entity.Property(e => e.Conteo180).HasColumnName("conteo180");

                entity.Property(e => e.Conteo30).HasColumnName("conteo30");

                entity.Property(e => e.Conteo60).HasColumnName("conteo60");

                entity.Property(e => e.Conteo90).HasColumnName("conteo90");

                entity.Property(e => e.Conteoce).HasColumnName("conteoce");

                entity.Property(e => e.Conteocfm).HasColumnName("conteocfm");

                entity.Property(e => e.Conteoi).HasColumnName("conteoi");

                entity.Property(e => e.Conteoii).HasColumnName("conteoii");

                entity.Property(e => e.Conteoiii).HasColumnName("conteoiii");

                entity.Property(e => e.Conteoiv).HasColumnName("conteoiv");

                entity.Property(e => e.Conteov).HasColumnName("conteov");

                entity.Property(e => e.CredEspe).HasColumnName("cred_espe");

                entity.Property(e => e.CredRefi).HasColumnName("cred_refi");

                entity.Property(e => e.Diasatraso).HasColumnName("diasatraso");

                entity.Property(e => e.FechCanc).HasColumnName("fech_canc");

                entity.Property(e => e.FechGene).HasColumnName("fech_gene");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechaotorgamiento).HasColumnName("fechaotorgamiento");

                entity.Property(e => e.Fechavencimiento).HasColumnName("fechavencimiento");

                entity.Property(e => e.Formapago).HasColumnName("formapago");

                entity.Property(e => e.HoraGene).HasColumnName("hora_gene");

                entity.Property(e => e.HoraInfo).HasColumnName("hora_info");

                entity.Property(e => e.MontCuot).HasColumnName("mont_cuot");

                entity.Property(e => e.Montooriginal).HasColumnName("montooriginal");

                entity.Property(e => e.MoraBiginte).HasColumnName("mora_biginte");

                entity.Property(e => e.MoraCapi).HasColumnName("mora_capi");

                entity.Property(e => e.Numerooperacion).HasColumnName("numerooperacion");

                entity.Property(e => e.OrigFond).HasColumnName("orig_fond");

                entity.Property(e => e.Periodogracia).HasColumnName("periodogracia");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.SaldComi).HasColumnName("sald_comi");

                entity.Property(e => e.Saldobiginteresescobrar).HasColumnName("saldobiginteresescobrar");

                entity.Property(e => e.Saldobiginteresessuspenso).HasColumnName("saldobiginteresessuspenso");

                entity.Property(e => e.Saldocastigado).HasColumnName("saldocastigado");

                entity.Property(e => e.Saldocontingente).HasColumnName("saldocontingente");

                entity.Property(e => e.Saldoejecucion).HasColumnName("saldoejecucion");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");

                entity.Property(e => e.Saldovencido).HasColumnName("saldovencido");

                entity.Property(e => e.Saldovigente).HasColumnName("saldovigente");

                entity.Property(e => e.Tasabiginteres).HasColumnName("tasabiginteres");

                entity.Property(e => e.Tipocredito).HasColumnName("tipocredito");

                entity.Property(e => e.Tipodeudor).HasColumnName("tipodeudor");

                entity.Property(e => e.Tipogarantia).HasColumnName("tipogarantia");

                entity.Property(e => e.Tipooperacion).HasColumnName("tipooperacion");

                entity.Property(e => e.Tipopersonabancos).HasColumnName("tipopersonabancos");

                entity.Property(e => e.UbicGeog).HasColumnName("ubic_geog");

                entity.Property(e => e.Valorgarantia).HasColumnName("valorgarantia");
            });

            modelBuilder.Entity<Bandeudaanterior>(entity =>
            {
                entity.HasKey(e => e.Idbandeudaanterior)
                    .HasName("bandeudaanterior_pkey");

                entity.ToTable("bandeudaanterior");

                entity.Property(e => e.Idbandeudaanterior)
                    .HasColumnName("idbandeudaanterior")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.ActiEcon).HasColumnName("acti_econ");

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CateRies).HasColumnName("cate_ries");

                entity.Property(e => e.CodiEsta).HasColumnName("codi_esta");

                entity.Property(e => e.CodiFnte).HasColumnName("codi_fnte");

                entity.Property(e => e.CodiMone).HasColumnName("codi_mone");

                entity.Property(e => e.CodiSucu).HasColumnName("codi_sucu");

                entity.Property(e => e.CredEspe).HasColumnName("cred_espe");

                entity.Property(e => e.CredRefi).HasColumnName("cred_refi");

                entity.Property(e => e.DiasAtra).HasColumnName("dias_atra");

                entity.Property(e => e.FechGene).HasColumnName("fech_gene");

                entity.Property(e => e.FechInfo).HasColumnName("fech_info");

                entity.Property(e => e.FechOtor).HasColumnName("fech_otor");

                entity.Property(e => e.FechVenc).HasColumnName("fech_venc");

                entity.Property(e => e.FormPago).HasColumnName("form_pago");

                entity.Property(e => e.HoraGene).HasColumnName("hora_gene");

                entity.Property(e => e.HoraInfo).HasColumnName("hora_info");

                entity.Property(e => e.MontOrig).HasColumnName("mont_orig");

                entity.Property(e => e.MoraBiginte).HasColumnName("mora_biginte");

                entity.Property(e => e.MoraCapi).HasColumnName("mora_capi");

                entity.Property(e => e.Noc).HasColumnName("noc");

                entity.Property(e => e.NumeOper).HasColumnName("nume_oper");

                entity.Property(e => e.OrigFond).HasColumnName("orig_fond");

                entity.Property(e => e.PeriGrac).HasColumnName("peri_grac");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.RegiImpu).HasColumnName("regi_impu");

                entity.Property(e => e.SaldBigintc).HasColumnName("sald_bigintc");

                entity.Property(e => e.SaldBigints).HasColumnName("sald_bigints");

                entity.Property(e => e.SaldCast).HasColumnName("sald_cast");

                entity.Property(e => e.SaldComi).HasColumnName("sald_comi");

                entity.Property(e => e.SaldCont).HasColumnName("sald_cont");

                entity.Property(e => e.SaldEjec).HasColumnName("sald_ejec");

                entity.Property(e => e.SaldMora).HasColumnName("sald_mora");

                entity.Property(e => e.SaldVenc).HasColumnName("sald_venc");

                entity.Property(e => e.SaldVige).HasColumnName("sald_vige");

                entity.Property(e => e.TasaBiginte).HasColumnName("tasa_biginte");

                entity.Property(e => e.TipoCred).HasColumnName("tipo_cred");

                entity.Property(e => e.TipoDeud).HasColumnName("tipo_deud");

                entity.Property(e => e.TipoGara).HasColumnName("tipo_gara");

                entity.Property(e => e.TipoOper).HasColumnName("tipo_oper");

                entity.Property(e => e.TipoPerb).HasColumnName("tipo_perb");

                entity.Property(e => e.UbicGeog).HasColumnName("ubic_geog");

                entity.Property(e => e.Valorgarantia).HasColumnName("valorgarantia");
            });

            modelBuilder.Entity<Bandeudaatrasos24meses>(entity =>
            {
                entity.ToTable("bandeudaatrasos24meses");

                entity.Property(e => e.Bandeudaatrasos24mesesid)
                    .HasColumnName("bandeudaatrasos24mesesid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.Maxdias).HasColumnName("maxdias");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("bitacora_pkey");

                entity.ToTable("bitacora");

                entity.Property(e => e.IdBitacora)
                    .HasColumnName("id_bitacora")
                    .HasIdentityOptions(null, null, null, 99999L, null, null);

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.FchRegistro)
                    .IsRequired()
                    .HasColumnName("fch_registro");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Opcion)
                    .IsRequired()
                    .HasColumnName("opcion");
            });

            modelBuilder.Entity<Calculates>(entity =>
            {
                entity.ToTable("calculates");

                entity.Property(e => e.Calculatesid)
                    .HasColumnName("calculatesid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BeCalificacionActual).HasColumnName("be_calificacion_actual");

                entity.Property(e => e.BeContCalifCfm12mBan).HasColumnName("be_cont_calif_cfm_12m_ban");

                entity.Property(e => e.BeContCalifCfm12mTar).HasColumnName("be_cont_calif_cfm_12m_tar");

                entity.Property(e => e.BeContCalifCfm24mBan).HasColumnName("be_cont_calif_cfm_24m_ban");

                entity.Property(e => e.BeContCalifCfm24mTar).HasColumnName("be_cont_calif_cfm_24m_tar");

                entity.Property(e => e.BeContCalifCfm36mBan).HasColumnName("be_cont_calif_cfm_36m_ban");

                entity.Property(e => e.BeContCalifCfm36mTar).HasColumnName("be_cont_calif_cfm_36m_tar");

                entity.Property(e => e.BeContCalifI12mBan).HasColumnName("be_cont_calif_i_12m_ban");

                entity.Property(e => e.BeContCalifI12mTar).HasColumnName("be_cont_calif_i_12m_tar");

                entity.Property(e => e.BeContCalifI24mBan).HasColumnName("be_cont_calif_i_24m_ban");

                entity.Property(e => e.BeContCalifI24mTar).HasColumnName("be_cont_calif_i_24m_tar");

                entity.Property(e => e.BeContCalifI36mBan).HasColumnName("be_cont_calif_i_36m_ban");

                entity.Property(e => e.BeContCalifI36mTar).HasColumnName("be_cont_calif_i_36m_tar");

                entity.Property(e => e.BeContCalifIi12mBan).HasColumnName("be_cont_calif_ii_12m_ban");

                entity.Property(e => e.BeContCalifIi12mTar).HasColumnName("be_cont_calif_ii_12m_tar");

                entity.Property(e => e.BeContCalifIi24mBan).HasColumnName("be_cont_calif_ii_24m_ban");

                entity.Property(e => e.BeContCalifIi24mTar).HasColumnName("be_cont_calif_ii_24m_tar");

                entity.Property(e => e.BeContCalifIi36mBan).HasColumnName("be_cont_calif_ii_36m_ban");

                entity.Property(e => e.BeContCalifIi36mTar).HasColumnName("be_cont_calif_ii_36m_tar");

                entity.Property(e => e.BeContCalifIii12mBan).HasColumnName("be_cont_calif_iii_12m_ban");

                entity.Property(e => e.BeContCalifIii12mTar).HasColumnName("be_cont_calif_iii_12m_tar");

                entity.Property(e => e.BeContCalifIii24mBan).HasColumnName("be_cont_calif_iii_24m_ban");

                entity.Property(e => e.BeContCalifIii24mTar).HasColumnName("be_cont_calif_iii_24m_tar");

                entity.Property(e => e.BeContCalifIii36mBan).HasColumnName("be_cont_calif_iii_36m_ban");

                entity.Property(e => e.BeContCalifIii36mTar).HasColumnName("be_cont_calif_iii_36m_tar");

                entity.Property(e => e.BeContCalifIv12mBan).HasColumnName("be_cont_calif_iv_12m_ban");

                entity.Property(e => e.BeContCalifIv12mTar).HasColumnName("be_cont_calif_iv_12m_tar");

                entity.Property(e => e.BeContCalifIv24mBan).HasColumnName("be_cont_calif_iv_24m_ban");

                entity.Property(e => e.BeContCalifIv24mTar).HasColumnName("be_cont_calif_iv_24m_tar");

                entity.Property(e => e.BeContCalifIv36mBan).HasColumnName("be_cont_calif_iv_36m_ban");

                entity.Property(e => e.BeContCalifIv36mTar).HasColumnName("be_cont_calif_iv_36m_tar");

                entity.Property(e => e.BeContCalifV12mBan).HasColumnName("be_cont_calif_v_12m_ban");

                entity.Property(e => e.BeContCalifV12mTar).HasColumnName("be_cont_calif_v_12m_tar");

                entity.Property(e => e.BeContCalifV24mBan).HasColumnName("be_cont_calif_v_24m_ban");

                entity.Property(e => e.BeContCalifV24mTar).HasColumnName("be_cont_calif_v_24m_tar");

                entity.Property(e => e.BeContCalifV36mBan).HasColumnName("be_cont_calif_v_36m_ban");

                entity.Property(e => e.BeContCalifV36mTar).HasColumnName("be_cont_calif_v_36m_tar");

                entity.Property(e => e.BeContMorahist120d12mBan).HasColumnName("be_cont_morahist_120d_12m_ban");

                entity.Property(e => e.BeContMorahist120d12mCom).HasColumnName("be_cont_morahist_120d_12m_com");

                entity.Property(e => e.BeContMorahist120d12mImf).HasColumnName("be_cont_morahist_120d_12m_imf");

                entity.Property(e => e.BeContMorahist120d12mTar).HasColumnName("be_cont_morahist_120d_12m_tar");

                entity.Property(e => e.BeContMorahist120d12mTelco).HasColumnName("be_cont_morahist_120d_12m_telco");

                entity.Property(e => e.BeContMorahist120d24mBan).HasColumnName("be_cont_morahist_120d_24m_ban");

                entity.Property(e => e.BeContMorahist120d24mCom).HasColumnName("be_cont_morahist_120d_24m_com");

                entity.Property(e => e.BeContMorahist120d24mImf).HasColumnName("be_cont_morahist_120d_24m_imf");

                entity.Property(e => e.BeContMorahist120d24mTar).HasColumnName("be_cont_morahist_120d_24m_tar");

                entity.Property(e => e.BeContMorahist120d24mTelco).HasColumnName("be_cont_morahist_120d_24m_telco");

                entity.Property(e => e.BeContMorahist120d36mBan).HasColumnName("be_cont_morahist_120d_36m_ban");

                entity.Property(e => e.BeContMorahist120d36mCom).HasColumnName("be_cont_morahist_120d_36m_com");

                entity.Property(e => e.BeContMorahist120d36mImf).HasColumnName("be_cont_morahist_120d_36m_imf");

                entity.Property(e => e.BeContMorahist120d36mTar).HasColumnName("be_cont_morahist_120d_36m_tar");

                entity.Property(e => e.BeContMorahist120d36mTelco).HasColumnName("be_cont_morahist_120d_36m_telco");

                entity.Property(e => e.BeContMorahist120d6mBan).HasColumnName("be_cont_morahist_120d_6m_ban");

                entity.Property(e => e.BeContMorahist120d6mCom).HasColumnName("be_cont_morahist_120d_6m_com");

                entity.Property(e => e.BeContMorahist120d6mImf).HasColumnName("be_cont_morahist_120d_6m_imf");

                entity.Property(e => e.BeContMorahist120d6mTar).HasColumnName("be_cont_morahist_120d_6m_tar");

                entity.Property(e => e.BeContMorahist120d6mTelco).HasColumnName("be_cont_morahist_120d_6m_telco");

                entity.Property(e => e.BeContMorahist150d12mBan).HasColumnName("be_cont_morahist_150d_12m_ban");

                entity.Property(e => e.BeContMorahist150d12mCom).HasColumnName("be_cont_morahist_150d_12m_com");

                entity.Property(e => e.BeContMorahist150d12mImf).HasColumnName("be_cont_morahist_150d_12m_imf");

                entity.Property(e => e.BeContMorahist150d12mTar).HasColumnName("be_cont_morahist_150d_12m_tar");

                entity.Property(e => e.BeContMorahist150d12mTelco).HasColumnName("be_cont_morahist_150d_12m_telco");

                entity.Property(e => e.BeContMorahist150d24mBan).HasColumnName("be_cont_morahist_150d_24m_ban");

                entity.Property(e => e.BeContMorahist150d24mCom).HasColumnName("be_cont_morahist_150d_24m_com");

                entity.Property(e => e.BeContMorahist150d24mImf).HasColumnName("be_cont_morahist_150d_24m_imf");

                entity.Property(e => e.BeContMorahist150d24mTar).HasColumnName("be_cont_morahist_150d_24m_tar");

                entity.Property(e => e.BeContMorahist150d24mTelco).HasColumnName("be_cont_morahist_150d_24m_telco");

                entity.Property(e => e.BeContMorahist150d36mBan).HasColumnName("be_cont_morahist_150d_36m_ban");

                entity.Property(e => e.BeContMorahist150d36mCom).HasColumnName("be_cont_morahist_150d_36m_com");

                entity.Property(e => e.BeContMorahist150d36mImf).HasColumnName("be_cont_morahist_150d_36m_imf");

                entity.Property(e => e.BeContMorahist150d36mTar).HasColumnName("be_cont_morahist_150d_36m_tar");

                entity.Property(e => e.BeContMorahist150d36mTelco).HasColumnName("be_cont_morahist_150d_36m_telco");

                entity.Property(e => e.BeContMorahist150d6mBan).HasColumnName("be_cont_morahist_150d_6m_ban");

                entity.Property(e => e.BeContMorahist150d6mCom).HasColumnName("be_cont_morahist_150d_6m_com");

                entity.Property(e => e.BeContMorahist150d6mImf).HasColumnName("be_cont_morahist_150d_6m_imf");

                entity.Property(e => e.BeContMorahist150d6mTar).HasColumnName("be_cont_morahist_150d_6m_tar");

                entity.Property(e => e.BeContMorahist150d6mTelco).HasColumnName("be_cont_morahist_150d_6m_telco");

                entity.Property(e => e.BeContMorahist180d12mBan).HasColumnName("be_cont_morahist_180d_12m_ban");

                entity.Property(e => e.BeContMorahist180d12mCom).HasColumnName("be_cont_morahist_180d_12m_com");

                entity.Property(e => e.BeContMorahist180d12mImf).HasColumnName("be_cont_morahist_180d_12m_imf");

                entity.Property(e => e.BeContMorahist180d12mTar).HasColumnName("be_cont_morahist_180d_12m_tar");

                entity.Property(e => e.BeContMorahist180d12mTelco).HasColumnName("be_cont_morahist_180d_12m_telco");

                entity.Property(e => e.BeContMorahist180d24mBan).HasColumnName("be_cont_morahist_180d_24m_ban");

                entity.Property(e => e.BeContMorahist180d24mCom).HasColumnName("be_cont_morahist_180d_24m_com");

                entity.Property(e => e.BeContMorahist180d24mImf).HasColumnName("be_cont_morahist_180d_24m_imf");

                entity.Property(e => e.BeContMorahist180d24mTar).HasColumnName("be_cont_morahist_180d_24m_tar");

                entity.Property(e => e.BeContMorahist180d24mTelco).HasColumnName("be_cont_morahist_180d_24m_telco");

                entity.Property(e => e.BeContMorahist180d36mBan).HasColumnName("be_cont_morahist_180d_36m_ban");

                entity.Property(e => e.BeContMorahist180d36mCom).HasColumnName("be_cont_morahist_180d_36m_com");

                entity.Property(e => e.BeContMorahist180d36mImf).HasColumnName("be_cont_morahist_180d_36m_imf");

                entity.Property(e => e.BeContMorahist180d36mTar).HasColumnName("be_cont_morahist_180d_36m_tar");

                entity.Property(e => e.BeContMorahist180d36mTelco).HasColumnName("be_cont_morahist_180d_36m_telco");

                entity.Property(e => e.BeContMorahist180d6mBan).HasColumnName("be_cont_morahist_180d_6m_ban");

                entity.Property(e => e.BeContMorahist180d6mCom).HasColumnName("be_cont_morahist_180d_6m_com");

                entity.Property(e => e.BeContMorahist180d6mImf).HasColumnName("be_cont_morahist_180d_6m_imf");

                entity.Property(e => e.BeContMorahist180d6mTar).HasColumnName("be_cont_morahist_180d_6m_tar");

                entity.Property(e => e.BeContMorahist180d6mTelco).HasColumnName("be_cont_morahist_180d_6m_telco");

                entity.Property(e => e.BeContMorahist30d12mBan0).HasColumnName("be_cont_morahist_30d_12m_ban_0");

                entity.Property(e => e.BeContMorahist30d12mBan1000).HasColumnName("be_cont_morahist_30d_12m_ban_1000");

                entity.Property(e => e.BeContMorahist30d12mCom0).HasColumnName("be_cont_morahist_30d_12m_com_0");

                entity.Property(e => e.BeContMorahist30d12mCom1000).HasColumnName("be_cont_morahist_30d_12m_com_1000");

                entity.Property(e => e.BeContMorahist30d12mImf0).HasColumnName("be_cont_morahist_30d_12m_imf_0");

                entity.Property(e => e.BeContMorahist30d12mImf1000).HasColumnName("be_cont_morahist_30d_12m_imf_1000");

                entity.Property(e => e.BeContMorahist30d12mTar0).HasColumnName("be_cont_morahist_30d_12m_tar_0");

                entity.Property(e => e.BeContMorahist30d12mTar1000).HasColumnName("be_cont_morahist_30d_12m_tar_1000");

                entity.Property(e => e.BeContMorahist30d12mTelco0).HasColumnName("be_cont_morahist_30d_12m_telco_0");

                entity.Property(e => e.BeContMorahist30d12mTelco1000).HasColumnName("be_cont_morahist_30d_12m_telco_1000");

                entity.Property(e => e.BeContMorahist30d24mBan0).HasColumnName("be_cont_morahist_30d_24m_ban_0");

                entity.Property(e => e.BeContMorahist30d24mBan1000).HasColumnName("be_cont_morahist_30d_24m_ban_1000");

                entity.Property(e => e.BeContMorahist30d24mCom0).HasColumnName("be_cont_morahist_30d_24m_com_0");

                entity.Property(e => e.BeContMorahist30d24mCom1000).HasColumnName("be_cont_morahist_30d_24m_com_1000");

                entity.Property(e => e.BeContMorahist30d24mImf0).HasColumnName("be_cont_morahist_30d_24m_imf_0");

                entity.Property(e => e.BeContMorahist30d24mImf1000).HasColumnName("be_cont_morahist_30d_24m_imf_1000");

                entity.Property(e => e.BeContMorahist30d24mTar0).HasColumnName("be_cont_morahist_30d_24m_tar_0");

                entity.Property(e => e.BeContMorahist30d24mTar1000).HasColumnName("be_cont_morahist_30d_24m_tar_1000");

                entity.Property(e => e.BeContMorahist30d24mTelco0).HasColumnName("be_cont_morahist_30d_24m_telco_0");

                entity.Property(e => e.BeContMorahist30d24mTelco1000).HasColumnName("be_cont_morahist_30d_24m_telco_1000");

                entity.Property(e => e.BeContMorahist30d36mBan0).HasColumnName("be_cont_morahist_30d_36m_ban_0");

                entity.Property(e => e.BeContMorahist30d36mBan1000).HasColumnName("be_cont_morahist_30d_36m_ban_1000");

                entity.Property(e => e.BeContMorahist30d36mCom0).HasColumnName("be_cont_morahist_30d_36m_com_0");

                entity.Property(e => e.BeContMorahist30d36mCom1000).HasColumnName("be_cont_morahist_30d_36m_com_1000");

                entity.Property(e => e.BeContMorahist30d36mImf0).HasColumnName("be_cont_morahist_30d_36m_imf_0");

                entity.Property(e => e.BeContMorahist30d36mImf1000).HasColumnName("be_cont_morahist_30d_36m_imf_1000");

                entity.Property(e => e.BeContMorahist30d36mTar0).HasColumnName("be_cont_morahist_30d_36m_tar_0");

                entity.Property(e => e.BeContMorahist30d36mTar1000).HasColumnName("be_cont_morahist_30d_36m_tar_1000");

                entity.Property(e => e.BeContMorahist30d36mTelco1000).HasColumnName("be_cont_morahist_30d_36m_telco_1000");

                entity.Property(e => e.BeContMorahist30d6mBan0).HasColumnName("be_cont_morahist_30d_6m_ban_0");

                entity.Property(e => e.BeContMorahist30d6mBan1000).HasColumnName("be_cont_morahist_30d_6m_ban_1000");

                entity.Property(e => e.BeContMorahist30d6mCom0).HasColumnName("be_cont_morahist_30d_6m_com_0");

                entity.Property(e => e.BeContMorahist30d6mCom1000).HasColumnName("be_cont_morahist_30d_6m_com_1000");

                entity.Property(e => e.BeContMorahist30d6mImf0).HasColumnName("be_cont_morahist_30d_6m_imf_0");

                entity.Property(e => e.BeContMorahist30d6mImf1000).HasColumnName("be_cont_morahist_30d_6m_imf_1000");

                entity.Property(e => e.BeContMorahist30d6mTar0).HasColumnName("be_cont_morahist_30d_6m_tar_0");

                entity.Property(e => e.BeContMorahist30d6mTar1000).HasColumnName("be_cont_morahist_30d_6m_tar_1000");

                entity.Property(e => e.BeContMorahist30d6mTelco0).HasColumnName("be_cont_morahist_30d_6m_telco_0");

                entity.Property(e => e.BeContMorahist30d6mTelco1000).HasColumnName("be_cont_morahist_30d_6m_telco_1000");

                entity.Property(e => e.BeContMorahist60d12mBan0).HasColumnName("be_cont_morahist_60d_12m_ban_0");

                entity.Property(e => e.BeContMorahist60d12mBan1000).HasColumnName("be_cont_morahist_60d_12m_ban_1000");

                entity.Property(e => e.BeContMorahist60d12mCom0).HasColumnName("be_cont_morahist_60d_12m_com_0");

                entity.Property(e => e.BeContMorahist60d12mCom1000).HasColumnName("be_cont_morahist_60d_12m_com_1000");

                entity.Property(e => e.BeContMorahist60d12mImf0).HasColumnName("be_cont_morahist_60d_12m_imf_0");

                entity.Property(e => e.BeContMorahist60d12mImf1000).HasColumnName("be_cont_morahist_60d_12m_imf_1000");

                entity.Property(e => e.BeContMorahist60d12mTar0).HasColumnName("be_cont_morahist_60d_12m_tar_0");

                entity.Property(e => e.BeContMorahist60d12mTar1000).HasColumnName("be_cont_morahist_60d_12m_tar_1000");

                entity.Property(e => e.BeContMorahist60d12mTelco0).HasColumnName("be_cont_morahist_60d_12m_telco_0");

                entity.Property(e => e.BeContMorahist60d12mTelco1000).HasColumnName("be_cont_morahist_60d_12m_telco_1000");

                entity.Property(e => e.BeContMorahist60d24mBan0).HasColumnName("be_cont_morahist_60d_24m_ban_0");

                entity.Property(e => e.BeContMorahist60d24mBan1000).HasColumnName("be_cont_morahist_60d_24m_ban_1000");

                entity.Property(e => e.BeContMorahist60d24mCom0).HasColumnName("be_cont_morahist_60d_24m_com_0");

                entity.Property(e => e.BeContMorahist60d24mCom1000).HasColumnName("be_cont_morahist_60d_24m_com_1000");

                entity.Property(e => e.BeContMorahist60d24mImf0).HasColumnName("be_cont_morahist_60d_24m_imf_0");

                entity.Property(e => e.BeContMorahist60d24mImf1000).HasColumnName("be_cont_morahist_60d_24m_imf_1000");

                entity.Property(e => e.BeContMorahist60d24mTar0).HasColumnName("be_cont_morahist_60d_24m_tar_0");

                entity.Property(e => e.BeContMorahist60d24mTar1000).HasColumnName("be_cont_morahist_60d_24m_tar_1000");

                entity.Property(e => e.BeContMorahist60d24mTelco0).HasColumnName("be_cont_morahist_60d_24m_telco_0");

                entity.Property(e => e.BeContMorahist60d24mTelco1000).HasColumnName("be_cont_morahist_60d_24m_telco_1000");

                entity.Property(e => e.BeContMorahist60d36mBan0).HasColumnName("be_cont_morahist_60d_36m_ban_0");

                entity.Property(e => e.BeContMorahist60d36mBan1000).HasColumnName("be_cont_morahist_60d_36m_ban_1000");

                entity.Property(e => e.BeContMorahist60d36mCom0).HasColumnName("be_cont_morahist_60d_36m_com_0");

                entity.Property(e => e.BeContMorahist60d36mCom1000).HasColumnName("be_cont_morahist_60d_36m_com_1000");

                entity.Property(e => e.BeContMorahist60d36mImf0).HasColumnName("be_cont_morahist_60d_36m_imf_0");

                entity.Property(e => e.BeContMorahist60d36mImf1000).HasColumnName("be_cont_morahist_60d_36m_imf_1000");

                entity.Property(e => e.BeContMorahist60d36mTar0).HasColumnName("be_cont_morahist_60d_36m_tar_0");

                entity.Property(e => e.BeContMorahist60d36mTar1000).HasColumnName("be_cont_morahist_60d_36m_tar_1000");

                entity.Property(e => e.BeContMorahist60d36mTelco0).HasColumnName("be_cont_morahist_60d_36m_telco_0");

                entity.Property(e => e.BeContMorahist60d36mTelco1000).HasColumnName("be_cont_morahist_60d_36m_telco_1000");

                entity.Property(e => e.BeContMorahist60d6mBan0).HasColumnName("be_cont_morahist_60d_6m_ban_0");

                entity.Property(e => e.BeContMorahist60d6mBan1000).HasColumnName("be_cont_morahist_60d_6m_ban_1000");

                entity.Property(e => e.BeContMorahist60d6mCom0).HasColumnName("be_cont_morahist_60d_6m_com_0");

                entity.Property(e => e.BeContMorahist60d6mCom1000).HasColumnName("be_cont_morahist_60d_6m_com_1000");

                entity.Property(e => e.BeContMorahist60d6mImf0).HasColumnName("be_cont_morahist_60d_6m_imf_0");

                entity.Property(e => e.BeContMorahist60d6mImf1000).HasColumnName("be_cont_morahist_60d_6m_imf_1000");

                entity.Property(e => e.BeContMorahist60d6mTar0).HasColumnName("be_cont_morahist_60d_6m_tar_0");

                entity.Property(e => e.BeContMorahist60d6mTar1000).HasColumnName("be_cont_morahist_60d_6m_tar_1000");

                entity.Property(e => e.BeContMorahist60d6mTelco0).HasColumnName("be_cont_morahist_60d_6m_telco_0");

                entity.Property(e => e.BeContMorahist60d6mTelco1000).HasColumnName("be_cont_morahist_60d_6m_telco_1000");

                entity.Property(e => e.BeContMorahist90d12mBan).HasColumnName("be_cont_morahist_90d_12m_ban");

                entity.Property(e => e.BeContMorahist90d12mCom).HasColumnName("be_cont_morahist_90d_12m_com");

                entity.Property(e => e.BeContMorahist90d12mImf).HasColumnName("be_cont_morahist_90d_12m_imf");

                entity.Property(e => e.BeContMorahist90d12mTar).HasColumnName("be_cont_morahist_90d_12m_tar");

                entity.Property(e => e.BeContMorahist90d12mTelco).HasColumnName("be_cont_morahist_90d_12m_telco");

                entity.Property(e => e.BeContMorahist90d24mBan).HasColumnName("be_cont_morahist_90d_24m_ban");

                entity.Property(e => e.BeContMorahist90d24mCom).HasColumnName("be_cont_morahist_90d_24m_com");

                entity.Property(e => e.BeContMorahist90d24mImf).HasColumnName("be_cont_morahist_90d_24m_imf");

                entity.Property(e => e.BeContMorahist90d24mTar).HasColumnName("be_cont_morahist_90d_24m_tar");

                entity.Property(e => e.BeContMorahist90d24mTelco).HasColumnName("be_cont_morahist_90d_24m_telco");

                entity.Property(e => e.BeContMorahist90d36mBan).HasColumnName("be_cont_morahist_90d_36m_ban");

                entity.Property(e => e.BeContMorahist90d36mCom).HasColumnName("be_cont_morahist_90d_36m_com");

                entity.Property(e => e.BeContMorahist90d36mImf).HasColumnName("be_cont_morahist_90d_36m_imf");

                entity.Property(e => e.BeContMorahist90d36mTar).HasColumnName("be_cont_morahist_90d_36m_tar");

                entity.Property(e => e.BeContMorahist90d36mTelco).HasColumnName("be_cont_morahist_90d_36m_telco");

                entity.Property(e => e.BeContMorahist90d6mBan).HasColumnName("be_cont_morahist_90d_6m_ban");

                entity.Property(e => e.BeContMorahist90d6mCom).HasColumnName("be_cont_morahist_90d_6m_com");

                entity.Property(e => e.BeContMorahist90d6mImf).HasColumnName("be_cont_morahist_90d_6m_imf");

                entity.Property(e => e.BeContMorahist90d6mTar).HasColumnName("be_cont_morahist_90d_6m_tar");

                entity.Property(e => e.BeContMorahist90d6mTelco).HasColumnName("be_cont_morahist_90d_6m_telco");

                entity.Property(e => e.BeContSaldocastBan36m).HasColumnName("be_cont_saldocast_ban_36m");

                entity.Property(e => e.BeContSaldovencBan36m).HasColumnName("be_cont_saldovenc_ban_36m");

                entity.Property(e => e.BeExistedataCli).HasColumnName("be_existedata_cli");

                entity.Property(e => e.BePeorCalif12mBan).HasColumnName("be_peor_calif_12m_ban");

                entity.Property(e => e.BePeorCalif12mTar).HasColumnName("be_peor_calif_12m_tar");

                entity.Property(e => e.BePeorCalif24mBan).HasColumnName("be_peor_calif_24m_ban");

                entity.Property(e => e.BePeorCalif24mTar).HasColumnName("be_peor_calif_24m_tar");

                entity.Property(e => e.BePeorCalif36mBan).HasColumnName("be_peor_calif_36m_ban");

                entity.Property(e => e.BePeorCalif36mTar).HasColumnName("be_peor_calif_36m_tar");

                entity.Property(e => e.BeRefMoraactual120Ban).HasColumnName("be_ref_moraactual_120_ban");

                entity.Property(e => e.BeRefMoraactual120Com).HasColumnName("be_ref_moraactual_120_com");

                entity.Property(e => e.BeRefMoraactual120Imf).HasColumnName("be_ref_moraactual_120_imf");

                entity.Property(e => e.BeRefMoraactual120Tar).HasColumnName("be_ref_moraactual_120_tar");

                entity.Property(e => e.BeRefMoraactual150Ban).HasColumnName("be_ref_moraactual_150_ban");

                entity.Property(e => e.BeRefMoraactual150Com).HasColumnName("be_ref_moraactual_150_com");

                entity.Property(e => e.BeRefMoraactual150Imf).HasColumnName("be_ref_moraactual_150_imf");

                entity.Property(e => e.BeRefMoraactual150Tar).HasColumnName("be_ref_moraactual_150_tar");

                entity.Property(e => e.BeRefMoraactual180Ban).HasColumnName("be_ref_moraactual_180_ban");

                entity.Property(e => e.BeRefMoraactual180Com).HasColumnName("be_ref_moraactual_180_com");

                entity.Property(e => e.BeRefMoraactual180Imf).HasColumnName("be_ref_moraactual_180_imf");

                entity.Property(e => e.BeRefMoraactual180Tar).HasColumnName("be_ref_moraactual_180_tar");

                entity.Property(e => e.BeRefMoraactual30Ban0).HasColumnName("be_ref_moraactual_30_ban0");

                entity.Property(e => e.BeRefMoraactual30Ban1000).HasColumnName("be_ref_moraactual_30_ban1000");

                entity.Property(e => e.BeRefMoraactual30Ban1500).HasColumnName("be_ref_moraactual_30_ban1500");

                entity.Property(e => e.BeRefMoraactual30Ban2000).HasColumnName("be_ref_moraactual_30_ban2000");

                entity.Property(e => e.BeRefMoraactual30Ban500).HasColumnName("be_ref_moraactual_30_ban500");

                entity.Property(e => e.BeRefMoraactual30Com0).HasColumnName("be_ref_moraactual_30_com0");

                entity.Property(e => e.BeRefMoraactual30Com1000).HasColumnName("be_ref_moraactual_30_com1000");

                entity.Property(e => e.BeRefMoraactual30Com1500).HasColumnName("be_ref_moraactual_30_com1500");

                entity.Property(e => e.BeRefMoraactual30Com2000).HasColumnName("be_ref_moraactual_30_com2000");

                entity.Property(e => e.BeRefMoraactual30Com500).HasColumnName("be_ref_moraactual_30_com500");

                entity.Property(e => e.BeRefMoraactual30Imf0).HasColumnName("be_ref_moraactual_30_imf0");

                entity.Property(e => e.BeRefMoraactual30Imf1000).HasColumnName("be_ref_moraactual_30_imf1000");

                entity.Property(e => e.BeRefMoraactual30Imf1500).HasColumnName("be_ref_moraactual_30_imf1500");

                entity.Property(e => e.BeRefMoraactual30Imf2000).HasColumnName("be_ref_moraactual_30_imf2000");

                entity.Property(e => e.BeRefMoraactual30Imf500).HasColumnName("be_ref_moraactual_30_imf500");

                entity.Property(e => e.BeRefMoraactual30Tar0).HasColumnName("be_ref_moraactual_30_tar0");

                entity.Property(e => e.BeRefMoraactual30Tar1000).HasColumnName("be_ref_moraactual_30_tar1000");

                entity.Property(e => e.BeRefMoraactual30Tar1500).HasColumnName("be_ref_moraactual_30_tar1500");

                entity.Property(e => e.BeRefMoraactual30Tar2000).HasColumnName("be_ref_moraactual_30_tar2000");

                entity.Property(e => e.BeRefMoraactual30Tar500).HasColumnName("be_ref_moraactual_30_tar500");

                entity.Property(e => e.BeRefMoraactual60Ban0).HasColumnName("be_ref_moraactual_60_ban0");

                entity.Property(e => e.BeRefMoraactual60Ban1000).HasColumnName("be_ref_moraactual_60_ban1000");

                entity.Property(e => e.BeRefMoraactual60Ban1500).HasColumnName("be_ref_moraactual_60_ban1500");

                entity.Property(e => e.BeRefMoraactual60Ban2000).HasColumnName("be_ref_moraactual_60_ban2000");

                entity.Property(e => e.BeRefMoraactual60Ban500).HasColumnName("be_ref_moraactual_60_ban500");

                entity.Property(e => e.BeRefMoraactual60Com0).HasColumnName("be_ref_moraactual_60_com0");

                entity.Property(e => e.BeRefMoraactual60Com1000).HasColumnName("be_ref_moraactual_60_com1000");

                entity.Property(e => e.BeRefMoraactual60Com1500).HasColumnName("be_ref_moraactual_60_com1500");

                entity.Property(e => e.BeRefMoraactual60Com2000).HasColumnName("be_ref_moraactual_60_com2000");

                entity.Property(e => e.BeRefMoraactual60Com500).HasColumnName("be_ref_moraactual_60_com500");

                entity.Property(e => e.BeRefMoraactual60Imf0).HasColumnName("be_ref_moraactual_60_imf0");

                entity.Property(e => e.BeRefMoraactual60Imf1000).HasColumnName("be_ref_moraactual_60_imf1000");

                entity.Property(e => e.BeRefMoraactual60Imf1500).HasColumnName("be_ref_moraactual_60_imf1500");

                entity.Property(e => e.BeRefMoraactual60Imf2000).HasColumnName("be_ref_moraactual_60_imf2000");

                entity.Property(e => e.BeRefMoraactual60Imf500).HasColumnName("be_ref_moraactual_60_imf500");

                entity.Property(e => e.BeRefMoraactual60Tar0).HasColumnName("be_ref_moraactual_60_tar0");

                entity.Property(e => e.BeRefMoraactual60Tar1000).HasColumnName("be_ref_moraactual_60_tar1000");

                entity.Property(e => e.BeRefMoraactual60Tar1500).HasColumnName("be_ref_moraactual_60_tar1500");

                entity.Property(e => e.BeRefMoraactual60Tar2000).HasColumnName("be_ref_moraactual_60_tar2000");

                entity.Property(e => e.BeRefMoraactual60Tar500).HasColumnName("be_ref_moraactual_60_tar500");

                entity.Property(e => e.BeRefMoraactual90Ban).HasColumnName("be_ref_moraactual_90_ban");

                entity.Property(e => e.BeRefMoraactual90Com).HasColumnName("be_ref_moraactual_90_com");

                entity.Property(e => e.BeRefMoraactual90Imf).HasColumnName("be_ref_moraactual_90_imf");

                entity.Property(e => e.BeRefMoraactual90Tar).HasColumnName("be_ref_moraactual_90_tar");

                entity.Property(e => e.BeRefMoraactualCobroadminCom).HasColumnName("be_ref_moraactual_cobroadmin_com");

                entity.Property(e => e.BeRefMoraactualCobroadminImf).HasColumnName("be_ref_moraactual_cobroadmin_imf");

                entity.Property(e => e.BeRefMoraactualCobroadminTelco).HasColumnName("be_ref_moraactual_cobroadmin_telco");

                entity.Property(e => e.BeRefMoraactualTelco120).HasColumnName("be_ref_moraactual_telco120");

                entity.Property(e => e.BeRefMoraactualTelco150).HasColumnName("be_ref_moraactual_telco150");

                entity.Property(e => e.BeRefMoraactualTelco180).HasColumnName("be_ref_moraactual_telco180");

                entity.Property(e => e.BeRefMoraactualTelco300).HasColumnName("be_ref_moraactual_telco30_0");

                entity.Property(e => e.BeRefMoraactualTelco301000).HasColumnName("be_ref_moraactual_telco30_1000");

                entity.Property(e => e.BeRefMoraactualTelco301500).HasColumnName("be_ref_moraactual_telco30_1500");

                entity.Property(e => e.BeRefMoraactualTelco302000).HasColumnName("be_ref_moraactual_telco30_2000");

                entity.Property(e => e.BeRefMoraactualTelco30500).HasColumnName("be_ref_moraactual_telco30_500");

                entity.Property(e => e.BeRefMoraactualTelco600).HasColumnName("be_ref_moraactual_telco60_0");

                entity.Property(e => e.BeRefMoraactualTelco601000).HasColumnName("be_ref_moraactual_telco60_1000");

                entity.Property(e => e.BeRefMoraactualTelco601500).HasColumnName("be_ref_moraactual_telco60_1500");

                entity.Property(e => e.BeRefMoraactualTelco602000).HasColumnName("be_ref_moraactual_telco60_2000");

                entity.Property(e => e.BeRefMoraactualTelco60500).HasColumnName("be_ref_moraactual_telco60_500");

                entity.Property(e => e.BeRefMoraactualTelco90).HasColumnName("be_ref_moraactual_telco90");

                entity.Property(e => e.BeRefjudicialCom).HasColumnName("be_refjudicial_com");

                entity.Property(e => e.BeSaldoMoraact120Tar).HasColumnName("be_saldo_moraact_120_tar");

                entity.Property(e => e.BeSaldoMoraact150Tar).HasColumnName("be_saldo_moraact_150_tar");

                entity.Property(e => e.BeSaldoMoraact180Tar).HasColumnName("be_saldo_moraact_180_tar");

                entity.Property(e => e.BeSaldoMoraact30dTar0).HasColumnName("be_saldo_moraact_30d_tar0");

                entity.Property(e => e.BeSaldoMoraact30dTar1000).HasColumnName("be_saldo_moraact_30d_tar1000");

                entity.Property(e => e.BeSaldoMoraact30dTar1500).HasColumnName("be_saldo_moraact_30d_tar1500");

                entity.Property(e => e.BeSaldoMoraact30dTar2000).HasColumnName("be_saldo_moraact_30d_tar2000");

                entity.Property(e => e.BeSaldoMoraact30dTar500).HasColumnName("be_saldo_moraact_30d_tar500");

                entity.Property(e => e.BeSaldoMoraact60dTar0).HasColumnName("be_saldo_moraact_60d_tar0");

                entity.Property(e => e.BeSaldoMoraact60dTar1000).HasColumnName("be_saldo_moraact_60d_tar1000");

                entity.Property(e => e.BeSaldoMoraact60dTar1500).HasColumnName("be_saldo_moraact_60d_tar1500");

                entity.Property(e => e.BeSaldoMoraact60dTar2000).HasColumnName("be_saldo_moraact_60d_tar2000");

                entity.Property(e => e.BeSaldoMoraact60dTar500).HasColumnName("be_saldo_moraact_60d_tar500");

                entity.Property(e => e.BeSaldoMoraact90Tar).HasColumnName("be_saldo_moraact_90_tar");

                entity.Property(e => e.BeSaldocastActualBan).HasColumnName("be_saldocast_actual_ban");

                entity.Property(e => e.BeSaldomoraact120Ban).HasColumnName("be_saldomoraact_120_ban");

                entity.Property(e => e.BeSaldomoraact120Com).HasColumnName("be_saldomoraact_120_com");

                entity.Property(e => e.BeSaldomoraact120Imf).HasColumnName("be_saldomoraact_120_imf");

                entity.Property(e => e.BeSaldomoraact120Telco).HasColumnName("be_saldomoraact_120_telco");

                entity.Property(e => e.BeSaldomoraact150Ban).HasColumnName("be_saldomoraact_150_ban");

                entity.Property(e => e.BeSaldomoraact150Com).HasColumnName("be_saldomoraact_150_com");

                entity.Property(e => e.BeSaldomoraact150Imf).HasColumnName("be_saldomoraact_150_imf");

                entity.Property(e => e.BeSaldomoraact150Telco).HasColumnName("be_saldomoraact_150_telco");

                entity.Property(e => e.BeSaldomoraact180Ban).HasColumnName("be_saldomoraact_180_ban");

                entity.Property(e => e.BeSaldomoraact180Com).HasColumnName("be_saldomoraact_180_com");

                entity.Property(e => e.BeSaldomoraact180Imf).HasColumnName("be_saldomoraact_180_imf");

                entity.Property(e => e.BeSaldomoraact180Telco).HasColumnName("be_saldomoraact_180_telco");

                entity.Property(e => e.BeSaldomoraact30Ban0).HasColumnName("be_saldomoraact_30_ban0");

                entity.Property(e => e.BeSaldomoraact30Ban1000).HasColumnName("be_saldomoraact_30_ban1000");

                entity.Property(e => e.BeSaldomoraact30Ban1500).HasColumnName("be_saldomoraact_30_ban1500");

                entity.Property(e => e.BeSaldomoraact30Ban2000).HasColumnName("be_saldomoraact_30_ban2000");

                entity.Property(e => e.BeSaldomoraact30Ban500).HasColumnName("be_saldomoraact_30_ban500");

                entity.Property(e => e.BeSaldomoraact30Com0).HasColumnName("be_saldomoraact_30_com0");

                entity.Property(e => e.BeSaldomoraact30Com1000).HasColumnName("be_saldomoraact_30_com1000");

                entity.Property(e => e.BeSaldomoraact30Com1500).HasColumnName("be_saldomoraact_30_com1500");

                entity.Property(e => e.BeSaldomoraact30Com2000).HasColumnName("be_saldomoraact_30_com2000");

                entity.Property(e => e.BeSaldomoraact30Com500).HasColumnName("be_saldomoraact_30_com500");

                entity.Property(e => e.BeSaldomoraact30Imf0).HasColumnName("be_saldomoraact_30_imf0");

                entity.Property(e => e.BeSaldomoraact30Imf1000).HasColumnName("be_saldomoraact_30_imf1000");

                entity.Property(e => e.BeSaldomoraact30Imf1500).HasColumnName("be_saldomoraact_30_imf1500");

                entity.Property(e => e.BeSaldomoraact30Imf2000).HasColumnName("be_saldomoraact_30_imf2000");

                entity.Property(e => e.BeSaldomoraact30Imf500).HasColumnName("be_saldomoraact_30_imf500");

                entity.Property(e => e.BeSaldomoraact30Telco0).HasColumnName("be_saldomoraact_30_telco0");

                entity.Property(e => e.BeSaldomoraact30Telco1000).HasColumnName("be_saldomoraact_30_telco1000");

                entity.Property(e => e.BeSaldomoraact30Telco1500).HasColumnName("be_saldomoraact_30_telco1500");

                entity.Property(e => e.BeSaldomoraact30Telco2000).HasColumnName("be_saldomoraact_30_telco2000");

                entity.Property(e => e.BeSaldomoraact30Telco500).HasColumnName("be_saldomoraact_30_telco500");

                entity.Property(e => e.BeSaldomoraact60Ban0).HasColumnName("be_saldomoraact_60_ban0");

                entity.Property(e => e.BeSaldomoraact60Ban1000).HasColumnName("be_saldomoraact_60_ban1000");

                entity.Property(e => e.BeSaldomoraact60Ban1500).HasColumnName("be_saldomoraact_60_ban1500");

                entity.Property(e => e.BeSaldomoraact60Ban2000).HasColumnName("be_saldomoraact_60_ban2000");

                entity.Property(e => e.BeSaldomoraact60Ban500).HasColumnName("be_saldomoraact_60_ban500");

                entity.Property(e => e.BeSaldomoraact60Com0).HasColumnName("be_saldomoraact_60_com0");

                entity.Property(e => e.BeSaldomoraact60Com1000).HasColumnName("be_saldomoraact_60_com1000");

                entity.Property(e => e.BeSaldomoraact60Com1500).HasColumnName("be_saldomoraact_60_com1500");

                entity.Property(e => e.BeSaldomoraact60Com2000).HasColumnName("be_saldomoraact_60_com2000");

                entity.Property(e => e.BeSaldomoraact60Com500).HasColumnName("be_saldomoraact_60_com500");

                entity.Property(e => e.BeSaldomoraact60Imf0).HasColumnName("be_saldomoraact_60_imf0");

                entity.Property(e => e.BeSaldomoraact60Imf1000).HasColumnName("be_saldomoraact_60_imf1000");

                entity.Property(e => e.BeSaldomoraact60Imf1500).HasColumnName("be_saldomoraact_60_imf1500");

                entity.Property(e => e.BeSaldomoraact60Imf2000).HasColumnName("be_saldomoraact_60_imf2000");

                entity.Property(e => e.BeSaldomoraact60Imf500).HasColumnName("be_saldomoraact_60_imf500");

                entity.Property(e => e.BeSaldomoraact60Telco0).HasColumnName("be_saldomoraact_60_telco0");

                entity.Property(e => e.BeSaldomoraact60Telco1000).HasColumnName("be_saldomoraact_60_telco1000");

                entity.Property(e => e.BeSaldomoraact60Telco1500).HasColumnName("be_saldomoraact_60_telco1500");

                entity.Property(e => e.BeSaldomoraact60Telco2000).HasColumnName("be_saldomoraact_60_telco2000");

                entity.Property(e => e.BeSaldomoraact60Telco500).HasColumnName("be_saldomoraact_60_telco500");

                entity.Property(e => e.BeSaldomoraact90Ban).HasColumnName("be_saldomoraact_90_ban");

                entity.Property(e => e.BeSaldomoraact90Com).HasColumnName("be_saldomoraact_90_com");

                entity.Property(e => e.BeSaldomoraact90Imf).HasColumnName("be_saldomoraact_90_imf");

                entity.Property(e => e.BeSaldomoraact90Telco).HasColumnName("be_saldomoraact_90_telco");

                entity.Property(e => e.BeSaldovencBan).HasColumnName("be_saldovenc_ban");

                entity.Property(e => e.BeScore).HasColumnName("be_score");

                entity.Property(e => e.BeScoreProm).HasColumnName("be_score_prom");

                entity.Property(e => e.BeTarCalificacionActual).HasColumnName("be_tar_calificacion_actual");

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");
            });

            modelBuilder.Entity<Candidateinfo>(entity =>
            {
                entity.ToTable("candidateinfo");

                entity.Property(e => e.Candidateinfoid)
                    .HasColumnName("candidateinfoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fechaconsulta)
                    .HasColumnName("fechaconsulta")
                    .HasColumnType("date");

                entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Tipopersona).HasColumnName("tipopersona");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => new { e.CodCiud, e.EmpreSaf, e.NumDepto })
                    .HasName("ciudades_pkey");

                entity.ToTable("ciudades");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("ciudad")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodEquiv)
                    .IsRequired()
                    .HasColumnName("cod_equiv")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.CodRegion)
                    .HasColumnName("cod_region")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Esrural)
                    .HasColumnName("esrural")
                    .HasColumnType("numeric");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<ClaseFondoProg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("clase_fondo_prog");

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasColumnType("numeric");

                entity.Property(e => e.Fondo)
                    .IsRequired()
                    .HasColumnName("fondo");

                entity.Property(e => e.Programa)
                    .IsRequired()
                    .HasColumnName("programa");
            });

            modelBuilder.Entity<Clases>(entity =>
            {
                entity.HasKey(e => e.Clase)
                    .HasName("clases_pkey");

                entity.ToTable("clases");

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.ClTasa).HasColumnName("cl_tasa");

                entity.Property(e => e.DescClase)
                    .IsRequired()
                    .HasColumnName("desc_clase")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Fondo).HasColumnName("fondo");

                entity.Property(e => e.MaximoAprobado).HasColumnName("maximo_aprobado");

                entity.Property(e => e.Programa).HasColumnName("programa");

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasColumnName("sigla")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tpoperacion).HasColumnName("tpoperacion");
            });

            modelBuilder.Entity<ClasesPlazo>(entity =>
            {
                entity.HasKey(e => new { e.Clase, e.EmpreSaf })
                    .HasName("clases_plazo_pkey");

                entity.ToTable("clases_plazo");

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasColumnType("numeric");

                entity.Property(e => e.EmpreSaf).HasColumnName("empre_saf");

                entity.Property(e => e.MDesde)
                    .HasColumnName("m_desde")
                    .HasColumnType("numeric");

                entity.Property(e => e.MHasta)
                    .HasColumnName("m_hasta")
                    .HasColumnType("numeric");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasColumnType("numeric");

                entity.Property(e => e.Plazo)
                    .HasColumnName("plazo")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<ClienteEmpleo>(entity =>
            {
                entity.HasKey(e => e.Codempleo)
                    .HasName("cliente_empleo_pkey");

                entity.ToTable("cliente_empleo");

                entity.Property(e => e.Codempleo)
                    .HasColumnName("codempleo")
                    .HasIdentityOptions(null, null, null, 999999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasColumnName("cargo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir1)
                    .IsRequired()
                    .HasColumnName("dir1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir2)
                    .IsRequired()
                    .HasColumnName("dir2")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.FchIngreso)
                    .HasColumnName("fch_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.FchRetiro)
                    .HasColumnName("fch_retiro")
                    .HasColumnType("date");

                entity.Property(e => e.FrecuenciaTrab)
                    .HasColumnName("frecuencia_trab")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.HoraSemana)
                    .HasColumnName("hora_semana")
                    .HasColumnType("numeric(4,1)");

                entity.Property(e => e.Idsesion)
                    .HasColumnName("idsesion")
                    .HasColumnType("numeric(22,0)");

                entity.Property(e => e.IngresoCatorcenal)
                    .HasColumnName("ingreso_catorcenal")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IngresoMensual)
                    .HasColumnName("ingreso_mensual")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.IngresoSemanal)
                    .HasColumnName("ingreso_semanal")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.NombEmpleador)
                    .IsRequired()
                    .HasColumnName("nomb_empleador");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.SueldoHora)
                    .HasColumnName("sueldo_hora")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Supervisor)
                    .IsRequired()
                    .HasColumnName("supervisor")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tel1).HasColumnName("tel1");

                entity.Property(e => e.Tel2).HasColumnName("tel2");

                entity.Property(e => e.TrabPrincipal)
                    .HasColumnName("trab_principal")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Cliente)
                    .HasName("Clientes");

                entity.ToTable("clientes");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.AceptaMensaje)
                    .HasColumnName("acepta_mensaje")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Apell)
                    .IsRequired()
                    .HasColumnName("apell")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.AuditFch)
                    .HasColumnName("audit_fch")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.AuditPor)
                    .IsRequired()
                    .HasColumnName("audit_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CalifBaja)
                    .HasColumnName("calif_baja")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.Calificacion)
                    .HasColumnName("calificacion")
                    .HasColumnType("numeric(6,2)");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasColumnName("cargo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CargoConyu)
                    .IsRequired()
                    .HasColumnName("cargo_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CargoPublico)
                    .IsRequired()
                    .HasColumnName("cargo_publico")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CartasA)
                    .IsRequired()
                    .HasColumnName("cartas_a")
                    .HasDefaultValueSql("'T'::text");

                entity.Property(e => e.CatDeudor)
                    .HasColumnName("cat_deudor")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.CatDeudorAutom)
                    .HasColumnName("cat_deudor_autom")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CiudEm)
                    .IsRequired()
                    .HasColumnName("ciud_em")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("ciudad")
                    .HasDefaultValueSql("'TEGUCIGALPA'::text");

                entity.Property(e => e.ClienteTutor)
                    .IsRequired()
                    .HasColumnName("cliente_tutor")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("80101");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("801");

                entity.Property(e => e.CodLugpob)
                    .HasColumnName("cod_lugpob")
                    .HasColumnType("numeric(12,0)");

                entity.Property(e => e.CodOcupacion)
                    .HasColumnName("cod_ocupacion")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Codcentroe)
                    .IsRequired()
                    .HasColumnName("codcentroe")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Codubi)
                    .IsRequired()
                    .HasColumnName("codubi")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasColumnName("contacto")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaReceptora)
                    .IsRequired()
                    .HasColumnName("cta_receptora")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CursIndu)
                    .IsRequired()
                    .HasColumnName("curs_indu")
                    .HasDefaultValueSql("'N'::text");

                entity.Property(e => e.DependConyu)
                    .IsRequired()
                    .HasColumnName("depend_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dependencia)
                    .IsRequired()
                    .HasColumnName("dependencia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DetalleOtrosing)
                    .IsRequired()
                    .HasColumnName("detalle_otrosing")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir1)
                    .IsRequired()
                    .HasColumnName("dir1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir1Em)
                    .IsRequired()
                    .HasColumnName("dir1_em")
                    .HasDefaultValueSql("'    '::text");

                entity.Property(e => e.Dir2)
                    .IsRequired()
                    .HasColumnName("dir2")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir2Em)
                    .IsRequired()
                    .HasColumnName("dir2_em")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DirConyu)
                    .IsRequired()
                    .HasColumnName("dir_conyu");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreConyu)
                    .IsRequired()
                    .HasColumnName("empre_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasColumnName("empresa")
                    .HasDefaultValueSql("'0000'::text");

                entity.Property(e => e.EsBeneficCta)
                    .IsRequired()
                    .HasColumnName("es_benefic_cta")
                    .HasDefaultValueSql("'S'::text");

                entity.Property(e => e.Escribir)
                    .HasColumnName("escribir")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EsfuncPublico)
                    .IsRequired()
                    .HasColumnName("esfunc_publico")
                    .HasDefaultValueSql("'N'::text");

                entity.Property(e => e.EstCiv)
                    .IsRequired()
                    .HasColumnName("est_civ")
                    .HasDefaultValueSql("'S'::text");

                entity.Property(e => e.Estatusc)
                    .IsRequired()
                    .HasColumnName("estatusc")
                    .HasDefaultValueSql("'A'::text");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchEstat)
                    .HasColumnName("fch_estat")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchEstatvenc)
                    .HasColumnName("fch_estatvenc")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchGrad)
                    .HasColumnName("fch_grad")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchIngre)
                    .HasColumnName("fch_ingre")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchInicio)
                    .HasColumnName("fch_inicio")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchIniconyu)
                    .HasColumnName("fch_iniconyu")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchNacim)
                    .HasColumnName("fch_nacim")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchNacimConyu)
                    .HasColumnName("fch_nacim_conyu")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchPgosal)
                    .HasColumnName("fch_pgosal")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchRetir)
                    .HasColumnName("fch_retir")
                    .HasColumnType("date")
                    .HasDefaultValueSql("to_date('2040/12/01'::text, 'yyyy/mm/dd'::text)");

                entity.Property(e => e.FormaPgo)
                    .HasColumnName("forma_pgo")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.FrecEval)
                    .HasColumnName("frec_eval")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.GpsLatitud)
                    .IsRequired()
                    .HasColumnName("gps_latitud")
                    .HasDefaultValueSql("'14.0839154'::text");

                entity.Property(e => e.GpsLongitud)
                    .IsRequired()
                    .HasColumnName("gps_longitud")
                    .HasDefaultValueSql("'-87.205376'::text");

                entity.Property(e => e.GrpEcon)
                    .HasColumnName("grp_econ")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.HijosDepen)
                    .HasColumnName("hijos_depen")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.IdConyu)
                    .IsRequired()
                    .HasColumnName("id_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.IdPrefijo)
                    .HasColumnName("id_prefijo")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Idbanco)
                    .HasColumnName("idbanco")
                    .HasColumnType("numeric");

                entity.Property(e => e.Leer)
                    .HasColumnName("leer")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Libreta)
                    .IsRequired()
                    .HasColumnName("libreta")
                    .HasDefaultValueSql("'S'::text");

                entity.Property(e => e.LugarNacim)
                    .IsRequired()
                    .HasColumnName("lugar_nacim")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LugarNacimCl)
                    .IsRequired()
                    .HasColumnName("lugar_nacim_cl")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LugarTrabConyu)
                    .IsRequired()
                    .HasColumnName("lugar_trab_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.MedidasSimpl)
                    .HasColumnName("medidas_simpl")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Medio)
                    .IsRequired()
                    .HasColumnName("medio")
                    .HasDefaultValueSql("'C'::text");

                entity.Property(e => e.Ndependiente)
                    .HasColumnName("ndependiente")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.NivEdu)
                    .HasColumnName("niv_edu")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.NomConyu)
                    .IsRequired()
                    .HasColumnName("nom_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NombBeneficCta)
                    .IsRequired()
                    .HasColumnName("nomb_benefic_cta")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NombEm)
                    .IsRequired()
                    .HasColumnName("nomb_em")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasColumnName("ocupacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.OcupacionConyu)
                    .IsRequired()
                    .HasColumnName("ocupacion_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Oficial)
                    .HasColumnName("oficial")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("origen")
                    .HasDefaultValueSql("'IDH'::text");

                entity.Property(e => e.Otrosing)
                    .HasColumnName("otrosing")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.PaisConyu)
                    .HasColumnName("pais_conyu")
                    .HasColumnType("numeric(3,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.PaisDeId)
                    .HasColumnName("pais_de_id")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.PaisGrad)
                    .HasColumnName("pais_grad")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("95");

                entity.Property(e => e.Precalificacion)
                    .HasColumnName("precalificacion")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Provisional)
                    .HasColumnName("provisional")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Rtn)
                    .IsRequired()
                    .HasColumnName("rtn")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasColumnName("sector")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Seudonimo)
                    .IsRequired()
                    .HasColumnName("seudonimo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasDefaultValueSql("'M'::text");

                entity.Property(e => e.StatCoop)
                    .IsRequired()
                    .HasColumnName("stat_coop")
                    .HasDefaultValueSql("'A'::text");

                entity.Property(e => e.Sueldo)
                    .HasColumnName("sueldo")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.SueldoConyu)
                    .HasColumnName("sueldo_conyu")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.SueldoTotCatorcenal)
                    .HasColumnName("sueldo_tot_catorcenal")
                    .HasColumnType("numeric(12,2)");

                entity.Property(e => e.SueldoTotSemanal)
                    .HasColumnName("sueldo_tot_semanal")
                    .HasColumnType("numeric(12,2)");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelCont)
                    .IsRequired()
                    .HasColumnName("tel_cont")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelConyu)
                    .IsRequired()
                    .HasColumnName("tel_conyu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelFax)
                    .IsRequired()
                    .HasColumnName("tel_fax")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelMovil)
                    .IsRequired()
                    .HasColumnName("tel_movil")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TeleEm)
                    .IsRequired()
                    .HasColumnName("tele_em")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TiempoResidir)
                    .HasColumnName("tiempo_residir")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.TipoCta)
                    .HasColumnName("tipo_cta")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TipoDeId)
                    .IsRequired()
                    .HasColumnName("tipo_de_id")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.Tipoemp)
                    .IsRequired()
                    .HasColumnName("tipoemp")
                    .HasDefaultValueSql("'P'::text");

                entity.Property(e => e.Tpcliente)
                    .HasColumnName("tpcliente")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpegdivisa)
                    .IsRequired()
                    .HasColumnName("tpegdivisa")
                    .HasDefaultValueSql("'ZZ'::text");

                entity.Property(e => e.Tprelacion)
                    .IsRequired()
                    .HasColumnName("tprelacion")
                    .HasDefaultValueSql("'Z'::text");

                entity.Property(e => e.Tpresidencia)
                    .IsRequired()
                    .HasColumnName("tpresidencia")
                    .HasDefaultValueSql("'P'::text");

                entity.Property(e => e.UltCalific)
                    .HasColumnName("ult_calific")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)");
            });

            modelBuilder.Entity<Comportamientoobligaciones>(entity =>
            {
                entity.ToTable("comportamientoobligaciones");

                entity.Property(e => e.Comportamientoobligacionesid)
                    .HasColumnName("comportamientoobligacionesid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Creditoconsecutivo).HasColumnName("creditoconsecutivo");

                entity.Property(e => e.Entidadinformante).HasColumnName("entidadinformante");

                entity.Property(e => e.Fechaactualizacion).HasColumnName("fechaactualizacion");

                entity.Property(e => e.Fechaapertura).HasColumnName("fechaapertura");

                entity.Property(e => e.Fechacierre).HasColumnName("fechacierre");

                entity.Property(e => e.Garantia).HasColumnName("garantia");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Periodopago).HasColumnName("periodopago");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Comportamientopago>(entity =>
            {
                entity.HasKey(e => e.Comportamientodepagoid)
                    .HasName("comportamientopago_pkey");

                entity.ToTable("comportamientopago");

                entity.Property(e => e.Comportamientodepagoid)
                    .HasColumnName("comportamientodepagoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Calificacion).HasColumnName("calificacion ");

                entity.Property(e => e.Diasmora).HasColumnName("diasmora");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Identificacionsujetoid).HasColumnName("identificacionsujetoid");

                entity.Property(e => e.Limite).HasColumnName("limite");

                entity.Property(e => e.Moneda).HasColumnName("moneda");

                entity.Property(e => e.Saldoactual).HasColumnName("saldoactual");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");
            });

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.HasKey(e => e.Idconcepto)
                    .HasName("concepto_pkey");

                entity.ToTable("concepto");

                entity.Property(e => e.Idconcepto)
                    .HasColumnName("idconcepto")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Fchcreado).HasColumnName("fchcreado");

                entity.Property(e => e.Nombreconcepto)
                    .IsRequired()
                    .HasColumnName("nombreconcepto");

                entity.Property(e => e.Tparchivo)
                    .IsRequired()
                    .HasColumnName("tparchivo");
            });

            modelBuilder.Entity<Confcorreo>(entity =>
            {
                entity.ToTable("confcorreo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 9999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasColumnName("contrasena");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasColumnName("host");

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasColumnName("port");

                entity.Property(e => e.Ssl)
                    .IsRequired()
                    .HasColumnName("ssl");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.ToTable("consulta");

                entity.Property(e => e.Consultaid)
                    .HasColumnName("consultaid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfo).HasColumnName("candidateinfo");

                entity.Property(e => e.CodiOfic).HasColumnName("codi_ofic");

                entity.Property(e => e.Codigoentidad).HasColumnName("codigoentidad");

                entity.Property(e => e.FechOper).HasColumnName("fech_oper");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Nombrerazon).HasColumnName("nombrerazon");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");
            });

            modelBuilder.Entity<Consultatransunion>(entity =>
            {
                entity.HasKey(e => e.Consultaid)
                    .HasName("consultatransunion_pkey");

                entity.ToTable("consultatransunion");

                entity.Property(e => e.Consultaid)
                    .HasColumnName("consultaid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Entidadconsultante).HasColumnName("entidadconsultante");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Motivo).HasColumnName("motivo");
            });

            modelBuilder.Entity<Controlreporte>(entity =>
            {
                entity.ToTable("controlreporte");

                entity.Property(e => e.Controlreporteid)
                    .HasColumnName("controlreporteid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Controlreporte1).HasColumnName("controlreporte");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");
            });

            modelBuilder.Entity<Correo>(entity =>
            {
                entity.ToTable("correo");

                entity.Property(e => e.Correoid)
                    .HasColumnName("correoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Correo1).HasColumnName("correo");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");
            });

            modelBuilder.Entity<Datosgenerales>(entity =>
            {
                entity.ToTable("datosgenerales");

                entity.Property(e => e.Datosgeneralesid)
                    .HasColumnName("datosgeneralesid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Apellidocasada).HasColumnName("apellidocasada");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");

                entity.Property(e => e.Genero).HasColumnName("genero");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Nombrecompleto).HasColumnName("nombrecompleto");

                entity.Property(e => e.Primernombre).HasColumnName("primernombre");

                entity.Property(e => e.Segundoapellido).HasColumnName("segundoapellido");

                entity.Property(e => e.Segundonombre).HasColumnName("segundonombre");

                entity.Property(e => e.Tipoprimerapellido).HasColumnName("tipoprimerapellido");
            });

            modelBuilder.Entity<Deptos>(entity =>
            {
                entity.HasKey(e => e.NumDepto)
                    .HasName("deptos_pkey");

                entity.ToTable("deptos");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Depto)
                    .IsRequired()
                    .HasColumnName("depto")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasDefaultValueSql("' '::text");
            });

            modelBuilder.Entity<Destinos>(entity =>
            {
                entity.HasKey(e => new { e.Destino, e.EmpreSaf })
                    .HasName("destinos_pkey");

                entity.ToTable("destinos");

                entity.Property(e => e.Destino)
                    .HasColumnName("destino")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.DescDest)
                    .IsRequired()
                    .HasColumnName("desc_dest")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescNiv)
                    .HasColumnName("desc_niv")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.DestinoPadre)
                    .IsRequired()
                    .HasColumnName("destino_padre")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");
            });

            modelBuilder.Entity<Deucomer>(entity =>
            {
                entity.HasKey(e => e.Iddeucomer)
                    .HasName("deucomer_pkey");

                entity.ToTable("deucomer");

                entity.Property(e => e.Iddeucomer)
                    .HasColumnName("iddeucomer")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Codigoestado).HasColumnName("codigoestado");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.Factorcambio).HasColumnName("factorcambio");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.Fechaapertura).HasColumnName("fechaapertura");

                entity.Property(e => e.Fechacancelacion).HasColumnName("fechacancelacion");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechamora).HasColumnName("fechamora");

                entity.Property(e => e.Fechavencimiento).HasColumnName("fechavencimiento");

                entity.Property(e => e.Formapago).HasColumnName("formapago");

                entity.Property(e => e.Monedamonto).HasColumnName("monedamonto");

                entity.Property(e => e.Monedamora).HasColumnName("monedamora");

                entity.Property(e => e.Monedapago).HasColumnName("monedapago");

                entity.Property(e => e.Monedasaldo).HasColumnName("monedasaldo");

                entity.Property(e => e.MontOtor).HasColumnName("mont_otor");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.NumeCuot).HasColumnName("nume_cuot");

                entity.Property(e => e.Numerocuenta).HasColumnName("numerocuenta");

                entity.Property(e => e.PagoCuot).HasColumnName("pago_cuot");

                entity.Property(e => e.Pagocuota).HasColumnName("pagocuota");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");

                entity.Property(e => e.Saldototal).HasColumnName("saldototal");

                entity.Property(e => e.Tipocredito).HasColumnName("tipocredito");

                entity.Property(e => e.Tipodeuda).HasColumnName("tipodeuda");

                entity.Property(e => e.Tipoinformacion).HasColumnName("tipoinformacion");
            });

            modelBuilder.Entity<Deucomeranterior>(entity =>
            {
                entity.HasKey(e => e.Iddeucomeranterior)
                    .HasName("deucomeranterior_pkey");

                entity.ToTable("deucomeranterior");

                entity.Property(e => e.Iddeucomeranterior)
                    .HasColumnName("iddeucomeranterior")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Codigoestado).HasColumnName("codigoestado");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.Factorcambio).HasColumnName("factorcambio");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.Fechaapertura).HasColumnName("fechaapertura");

                entity.Property(e => e.Fechacancelacion).HasColumnName("fechacancelacion");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechamora).HasColumnName("fechamora");

                entity.Property(e => e.Fechavencimiento).HasColumnName("fechavencimiento");

                entity.Property(e => e.Formapago).HasColumnName("formapago");

                entity.Property(e => e.Monedamonto).HasColumnName("monedamonto");

                entity.Property(e => e.Monedamora).HasColumnName("monedamora");

                entity.Property(e => e.Monedapago).HasColumnName("monedapago");

                entity.Property(e => e.Monedasaldo).HasColumnName("monedasaldo");

                entity.Property(e => e.MontOtor).HasColumnName("mont_otor");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.NumeCuot).HasColumnName("nume_cuot");

                entity.Property(e => e.Numerocuenta).HasColumnName("numerocuenta");

                entity.Property(e => e.Pagocuota).HasColumnName("pagocuota");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");

                entity.Property(e => e.Saldototal).HasColumnName("saldototal");

                entity.Property(e => e.Tipocredito).HasColumnName("tipocredito");

                entity.Property(e => e.Tipodeuda).HasColumnName("tipodeuda");

                entity.Property(e => e.Tipoinformacion).HasColumnName("tipoinformacion");
            });

            modelBuilder.Entity<Deucomerhistorico>(entity =>
            {
                entity.HasKey(e => e.Iddeucomerhistorico)
                    .HasName("deucomerhistorico_pkey");

                entity.ToTable("deucomerhistorico");

                entity.Property(e => e.Iddeucomerhistorico)
                    .HasColumnName("iddeucomerhistorico")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CodiFnte).HasColumnName("codi_fnte");

                entity.Property(e => e.FechOtor).HasColumnName("fech_otor");

                entity.Property(e => e.NumeLine).HasColumnName("nume_line");

                entity.Property(e => e.NumeRefe).HasColumnName("nume_refe");

                entity.Property(e => e.PeriActu).HasColumnName("peri_actu");

                entity.Property(e => e.PeriLine).HasColumnName("peri_line");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.TipoCred).HasColumnName("tipo_cred");
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.ToTable("direccion");

                entity.Property(e => e.Direccionid)
                    .HasColumnName("direccionid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Direccion1).HasColumnName("direccion");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Texto).HasColumnName("texto");
            });

            modelBuilder.Entity<Direccione>(entity =>
            {
                entity.ToTable("direccione");

                entity.Property(e => e.Direccioneid)
                    .HasColumnName("direccioneid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Direccion).HasColumnName("direccion");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");
            });

            modelBuilder.Entity<Direcciones>(entity =>
            {
                entity.HasKey(e => e.IdDir)
                    .HasName("direcciones_pkey");

                entity.ToTable("direcciones");

                entity.Property(e => e.IdDir)
                    .HasColumnName("id_dir")
                    .HasIdentityOptions(null, null, null, 999999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CodLugpob)
                    .HasColumnName("cod_lugpob")
                    .HasColumnType("numeric(12,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir1).HasColumnName("dir1");

                entity.Property(e => e.Dir2)
                    .HasColumnName("dir2")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.GpsLatitud).HasColumnName("gps_latitud");

                entity.Property(e => e.GpsLongitud).HasColumnName("gps_longitud");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelMovil)
                    .IsRequired()
                    .HasColumnName("tel_movil")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TiempoResidir)
                    .HasColumnName("tiempo_residir")
                    .HasColumnType("numeric(3,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TipoDir)
                    .HasColumnName("tipo_dir")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Tpresidencia)
                    .IsRequired()
                    .HasColumnName("tpresidencia")
                    .HasDefaultValueSql("'1'::text");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)")
                    .HasDefaultValueSql("NULL::numeric");
            });

            modelBuilder.Entity<Equifax>(entity =>
            {
                entity.ToTable("equifax");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 999999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BeCalificacionActual)
                    .HasColumnName("be_calificacion_actual")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm12mBan)
                    .HasColumnName("be_cont_calif_cfm_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm12mTar)
                    .HasColumnName("be_cont_calif_cfm_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm24mBan)
                    .HasColumnName("be_cont_calif_cfm_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm24mTar)
                    .HasColumnName("be_cont_calif_cfm_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm36mBan)
                    .HasColumnName("be_cont_calif_cfm_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifCfm36mTar)
                    .HasColumnName("be_cont_calif_cfm_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI12mBan)
                    .HasColumnName("be_cont_calif_i_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI12mTar)
                    .HasColumnName("be_cont_calif_i_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI24mBan)
                    .HasColumnName("be_cont_calif_i_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI24mTar)
                    .HasColumnName("be_cont_calif_i_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI36mBan)
                    .HasColumnName("be_cont_calif_i_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifI36mTar)
                    .HasColumnName("be_cont_calif_i_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi12mBan)
                    .HasColumnName("be_cont_calif_ii_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi12mTar)
                    .HasColumnName("be_cont_calif_ii_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi24mBan)
                    .HasColumnName("be_cont_calif_ii_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi24mTar)
                    .HasColumnName("be_cont_calif_ii_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi36mBan)
                    .HasColumnName("be_cont_calif_ii_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIi36mTar)
                    .HasColumnName("be_cont_calif_ii_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii12mBan)
                    .HasColumnName("be_cont_calif_iii_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii12mTar)
                    .HasColumnName("be_cont_calif_iii_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii24mBan)
                    .HasColumnName("be_cont_calif_iii_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii24mTar)
                    .HasColumnName("be_cont_calif_iii_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii36mBan)
                    .HasColumnName("be_cont_calif_iii_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIii36mTar)
                    .HasColumnName("be_cont_calif_iii_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv12mBan)
                    .HasColumnName("be_cont_calif_iv_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv12mTar)
                    .HasColumnName("be_cont_calif_iv_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv24mBan)
                    .HasColumnName("be_cont_calif_iv_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv24mTar)
                    .HasColumnName("be_cont_calif_iv_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv36mBan)
                    .HasColumnName("be_cont_calif_iv_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifIv36mTar)
                    .HasColumnName("be_cont_calif_iv_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV12mBan)
                    .HasColumnName("be_cont_calif_v_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV12mTar)
                    .HasColumnName("be_cont_calif_v_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV24mBan)
                    .HasColumnName("be_cont_calif_v_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV24mTar)
                    .HasColumnName("be_cont_calif_v_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV36mBan)
                    .HasColumnName("be_cont_calif_v_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContCalifV36mTar)
                    .HasColumnName("be_cont_calif_v_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d12mBan)
                    .HasColumnName("be_cont_morahist_120d_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d12mCom)
                    .HasColumnName("be_cont_morahist_120d_12m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d12mImf)
                    .HasColumnName("be_cont_morahist_120d_12m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d12mTar)
                    .HasColumnName("be_cont_morahist_120d_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d12mTelco)
                    .HasColumnName("be_cont_morahist_120d_12m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d24mBan)
                    .HasColumnName("be_cont_morahist_120d_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d24mCom)
                    .HasColumnName("be_cont_morahist_120d_24m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d24mImf)
                    .HasColumnName("be_cont_morahist_120d_24m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d24mTar)
                    .HasColumnName("be_cont_morahist_120d_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d24mTelco)
                    .HasColumnName("be_cont_morahist_120d_24m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d36mBan)
                    .HasColumnName("be_cont_morahist_120d_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d36mCom)
                    .HasColumnName("be_cont_morahist_120d_36m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d36mImf)
                    .HasColumnName("be_cont_morahist_120d_36m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d36mTar)
                    .HasColumnName("be_cont_morahist_120d_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d36mTelco)
                    .HasColumnName("be_cont_morahist_120d_36m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d6mBan)
                    .HasColumnName("be_cont_morahist_120d_6m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d6mCom)
                    .HasColumnName("be_cont_morahist_120d_6m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d6mImf)
                    .HasColumnName("be_cont_morahist_120d_6m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d6mTar)
                    .HasColumnName("be_cont_morahist_120d_6m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist120d6mTelco)
                    .HasColumnName("be_cont_morahist_120d_6m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d12mBan)
                    .HasColumnName("be_cont_morahist_150d_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d12mCom)
                    .HasColumnName("be_cont_morahist_150d_12m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d12mImf)
                    .HasColumnName("be_cont_morahist_150d_12m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d12mTar)
                    .HasColumnName("be_cont_morahist_150d_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d12mTelco)
                    .HasColumnName("be_cont_morahist_150d_12m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d24mBan)
                    .HasColumnName("be_cont_morahist_150d_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d24mCom)
                    .HasColumnName("be_cont_morahist_150d_24m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d24mImf)
                    .HasColumnName("be_cont_morahist_150d_24m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d24mTar)
                    .HasColumnName("be_cont_morahist_150d_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d24mTelco)
                    .HasColumnName("be_cont_morahist_150d_24m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d36mBan)
                    .HasColumnName("be_cont_morahist_150d_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d36mCom)
                    .HasColumnName("be_cont_morahist_150d_36m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d36mImf)
                    .HasColumnName("be_cont_morahist_150d_36m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d36mTar)
                    .HasColumnName("be_cont_morahist_150d_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d36mTelco)
                    .HasColumnName("be_cont_morahist_150d_36m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d6mBan)
                    .HasColumnName("be_cont_morahist_150d_6m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d6mCom)
                    .HasColumnName("be_cont_morahist_150d_6m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d6mImf)
                    .HasColumnName("be_cont_morahist_150d_6m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d6mTar)
                    .HasColumnName("be_cont_morahist_150d_6m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist150d6mTelco)
                    .HasColumnName("be_cont_morahist_150d_6m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d12mBan)
                    .HasColumnName("be_cont_morahist_180d_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d12mCom)
                    .HasColumnName("be_cont_morahist_180d_12m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d12mImf)
                    .HasColumnName("be_cont_morahist_180d_12m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d12mTar)
                    .HasColumnName("be_cont_morahist_180d_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d12mTelco)
                    .HasColumnName("be_cont_morahist_180d_12m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d24mBan)
                    .HasColumnName("be_cont_morahist_180d_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d24mCom)
                    .HasColumnName("be_cont_morahist_180d_24m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d24mImf)
                    .HasColumnName("be_cont_morahist_180d_24m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d24mTar)
                    .HasColumnName("be_cont_morahist_180d_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d24mTelco)
                    .HasColumnName("be_cont_morahist_180d_24m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d36mBan)
                    .HasColumnName("be_cont_morahist_180d_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d36mCom)
                    .HasColumnName("be_cont_morahist_180d_36m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d36mImf)
                    .HasColumnName("be_cont_morahist_180d_36m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d36mTar)
                    .HasColumnName("be_cont_morahist_180d_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d36mTelco)
                    .HasColumnName("be_cont_morahist_180d_36m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d6mBan)
                    .HasColumnName("be_cont_morahist_180d_6m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d6mCom)
                    .HasColumnName("be_cont_morahist_180d_6m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d6mImf)
                    .HasColumnName("be_cont_morahist_180d_6m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d6mTar)
                    .HasColumnName("be_cont_morahist_180d_6m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist180d6mTelco)
                    .HasColumnName("be_cont_morahist_180d_6m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mBan0)
                    .HasColumnName("be_cont_morahist_30d_12m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mBan1000)
                    .HasColumnName("be_cont_morahist_30d_12m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mCom0)
                    .HasColumnName("be_cont_morahist_30d_12m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mCom1000)
                    .HasColumnName("be_cont_morahist_30d_12m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mImf0)
                    .HasColumnName("be_cont_morahist_30d_12m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mImf1000)
                    .HasColumnName("be_cont_morahist_30d_12m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mTar0)
                    .HasColumnName("be_cont_morahist_30d_12m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mTar1000)
                    .HasColumnName("be_cont_morahist_30d_12m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mTelco0)
                    .HasColumnName("be_cont_morahist_30d_12m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d12mTelco1000)
                    .HasColumnName("be_cont_morahist_30d_12m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mBan0)
                    .HasColumnName("be_cont_morahist_30d_24m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mBan1000)
                    .HasColumnName("be_cont_morahist_30d_24m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mCom0)
                    .HasColumnName("be_cont_morahist_30d_24m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mCom1000)
                    .HasColumnName("be_cont_morahist_30d_24m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mImf0)
                    .HasColumnName("be_cont_morahist_30d_24m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mImf1000)
                    .HasColumnName("be_cont_morahist_30d_24m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mTar0)
                    .HasColumnName("be_cont_morahist_30d_24m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mTar1000)
                    .HasColumnName("be_cont_morahist_30d_24m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mTelco0)
                    .HasColumnName("be_cont_morahist_30d_24m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d24mTelco1000)
                    .HasColumnName("be_cont_morahist_30d_24m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mBan0)
                    .HasColumnName("be_cont_morahist_30d_36m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mBan1000)
                    .HasColumnName("be_cont_morahist_30d_36m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mCom0)
                    .HasColumnName("be_cont_morahist_30d_36m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mCom1000)
                    .HasColumnName("be_cont_morahist_30d_36m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mImf0)
                    .HasColumnName("be_cont_morahist_30d_36m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mImf1000)
                    .HasColumnName("be_cont_morahist_30d_36m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mTar0)
                    .HasColumnName("be_cont_morahist_30d_36m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mTar1000)
                    .HasColumnName("be_cont_morahist_30d_36m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mTelco0)
                    .HasColumnName("be_cont_morahist_30d_36m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d36mTelco1000)
                    .HasColumnName("be_cont_morahist_30d_36m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mBan0)
                    .HasColumnName("be_cont_morahist_30d_6m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mBan1000)
                    .HasColumnName("be_cont_morahist_30d_6m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mCom0)
                    .HasColumnName("be_cont_morahist_30d_6m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mCom1000)
                    .HasColumnName("be_cont_morahist_30d_6m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mImf0)
                    .HasColumnName("be_cont_morahist_30d_6m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mImf1000)
                    .HasColumnName("be_cont_morahist_30d_6m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mTar0)
                    .HasColumnName("be_cont_morahist_30d_6m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mTar1000)
                    .HasColumnName("be_cont_morahist_30d_6m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mTelco0)
                    .HasColumnName("be_cont_morahist_30d_6m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist30d6mTelco1000)
                    .HasColumnName("be_cont_morahist_30d_6m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mBan0)
                    .HasColumnName("be_cont_morahist_60d_12m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mBan1000)
                    .HasColumnName("be_cont_morahist_60d_12m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mCom0)
                    .HasColumnName("be_cont_morahist_60d_12m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mCom1000)
                    .HasColumnName("be_cont_morahist_60d_12m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mImf0)
                    .HasColumnName("be_cont_morahist_60d_12m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mImf1000)
                    .HasColumnName("be_cont_morahist_60d_12m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mTar0)
                    .HasColumnName("be_cont_morahist_60d_12m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mTar1000)
                    .HasColumnName("be_cont_morahist_60d_12m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mTelco0)
                    .HasColumnName("be_cont_morahist_60d_12m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d12mTelco1000)
                    .HasColumnName("be_cont_morahist_60d_12m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mBan0)
                    .HasColumnName("be_cont_morahist_60d_24m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mBan1000)
                    .HasColumnName("be_cont_morahist_60d_24m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mCom0)
                    .HasColumnName("be_cont_morahist_60d_24m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mCom1000)
                    .HasColumnName("be_cont_morahist_60d_24m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mImf0)
                    .HasColumnName("be_cont_morahist_60d_24m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mImf1000)
                    .HasColumnName("be_cont_morahist_60d_24m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mTar0)
                    .HasColumnName("be_cont_morahist_60d_24m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mTar1000)
                    .HasColumnName("be_cont_morahist_60d_24m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mTelco0)
                    .HasColumnName("be_cont_morahist_60d_24m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d24mTelco1000)
                    .HasColumnName("be_cont_morahist_60d_24m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mBan0)
                    .HasColumnName("be_cont_morahist_60d_36m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mBan1000)
                    .HasColumnName("be_cont_morahist_60d_36m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mCom0)
                    .HasColumnName("be_cont_morahist_60d_36m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mCom1000)
                    .HasColumnName("be_cont_morahist_60d_36m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mImf0)
                    .HasColumnName("be_cont_morahist_60d_36m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mImf1000)
                    .HasColumnName("be_cont_morahist_60d_36m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mTar0)
                    .HasColumnName("be_cont_morahist_60d_36m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mTar1000)
                    .HasColumnName("be_cont_morahist_60d_36m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mTelco0)
                    .HasColumnName("be_cont_morahist_60d_36m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d36mTelco1000)
                    .HasColumnName("be_cont_morahist_60d_36m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mBan0)
                    .HasColumnName("be_cont_morahist_60d_6m_ban_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mBan1000)
                    .HasColumnName("be_cont_morahist_60d_6m_ban_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mCom0)
                    .HasColumnName("be_cont_morahist_60d_6m_com_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mCom1000)
                    .HasColumnName("be_cont_morahist_60d_6m_com_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mImf0)
                    .HasColumnName("be_cont_morahist_60d_6m_imf_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mImf1000)
                    .HasColumnName("be_cont_morahist_60d_6m_imf_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mTar0)
                    .HasColumnName("be_cont_morahist_60d_6m_tar_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mTar1000)
                    .HasColumnName("be_cont_morahist_60d_6m_tar_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mTelco0)
                    .HasColumnName("be_cont_morahist_60d_6m_telco_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist60d6mTelco1000)
                    .HasColumnName("be_cont_morahist_60d_6m_telco_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d12mBan)
                    .HasColumnName("be_cont_morahist_90d_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d12mCom)
                    .HasColumnName("be_cont_morahist_90d_12m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d12mImf)
                    .HasColumnName("be_cont_morahist_90d_12m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d12mTar)
                    .HasColumnName("be_cont_morahist_90d_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d12mTelco)
                    .HasColumnName("be_cont_morahist_90d_12m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d24mBan)
                    .HasColumnName("be_cont_morahist_90d_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d24mCom)
                    .HasColumnName("be_cont_morahist_90d_24m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d24mImf)
                    .HasColumnName("be_cont_morahist_90d_24m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d24mTar)
                    .HasColumnName("be_cont_morahist_90d_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d24mTelco)
                    .HasColumnName("be_cont_morahist_90d_24m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d36mBan)
                    .HasColumnName("be_cont_morahist_90d_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d36mCom)
                    .HasColumnName("be_cont_morahist_90d_36m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d36mImf)
                    .HasColumnName("be_cont_morahist_90d_36m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d36mTar)
                    .HasColumnName("be_cont_morahist_90d_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d36mTelco)
                    .HasColumnName("be_cont_morahist_90d_36m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d6mBan)
                    .HasColumnName("be_cont_morahist_90d_6m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d6mCom)
                    .HasColumnName("be_cont_morahist_90d_6m_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d6mImf)
                    .HasColumnName("be_cont_morahist_90d_6m_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d6mTar)
                    .HasColumnName("be_cont_morahist_90d_6m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContMorahist90d6mTelco)
                    .HasColumnName("be_cont_morahist_90d_6m_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContSaldocastBan36m)
                    .HasColumnName("be_cont_saldocast_ban_36m")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContSaldocastTar36m)
                    .HasColumnName("be_cont_saldocast_tar_36m")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContSaldovencBan36m)
                    .HasColumnName("be_cont_saldovenc_ban_36m")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeContSaldovencTar36m)
                    .HasColumnName("be_cont_saldovenc_tar_36m")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeExistedataCli)
                    .HasColumnName("be_existedata_cli")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif12mBan)
                    .HasColumnName("be_peor_calif_12m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif12mTar)
                    .HasColumnName("be_peor_calif_12m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif24mBan)
                    .HasColumnName("be_peor_calif_24m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif24mTar)
                    .HasColumnName("be_peor_calif_24m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif36mBan)
                    .HasColumnName("be_peor_calif_36m_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePeorCalif36mTar)
                    .HasColumnName("be_peor_calif_36m_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BePromScore)
                    .HasColumnName("be_prom_score")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual120Ban)
                    .HasColumnName("be_ref_moraactual_120_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual120Com)
                    .HasColumnName("be_ref_moraactual_120_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual120Imf)
                    .HasColumnName("be_ref_moraactual_120_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual120Tar)
                    .HasColumnName("be_ref_moraactual_120_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual150Ban)
                    .HasColumnName("be_ref_moraactual_150_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual150Com)
                    .HasColumnName("be_ref_moraactual_150_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual150Imf)
                    .HasColumnName("be_ref_moraactual_150_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual150Tar)
                    .HasColumnName("be_ref_moraactual_150_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual180Ban)
                    .HasColumnName("be_ref_moraactual_180_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual180Com)
                    .HasColumnName("be_ref_moraactual_180_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual180Imf)
                    .HasColumnName("be_ref_moraactual_180_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual180Tar)
                    .HasColumnName("be_ref_moraactual_180_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Ban0)
                    .HasColumnName("be_ref_moraactual_30_ban0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Ban1000)
                    .HasColumnName("be_ref_moraactual_30_ban1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Ban1500)
                    .HasColumnName("be_ref_moraactual_30_ban1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Ban2000)
                    .HasColumnName("be_ref_moraactual_30_ban2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Ban500)
                    .HasColumnName("be_ref_moraactual_30_ban500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Com0)
                    .HasColumnName("be_ref_moraactual_30_com0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Com1000)
                    .HasColumnName("be_ref_moraactual_30_com1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Com1500)
                    .HasColumnName("be_ref_moraactual_30_com1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Com2000)
                    .HasColumnName("be_ref_moraactual_30_com2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Com500)
                    .HasColumnName("be_ref_moraactual_30_com500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Imf0)
                    .HasColumnName("be_ref_moraactual_30_imf0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Imf1000)
                    .HasColumnName("be_ref_moraactual_30_imf1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Imf1500)
                    .HasColumnName("be_ref_moraactual_30_imf1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Imf2000)
                    .HasColumnName("be_ref_moraactual_30_imf2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Imf500)
                    .HasColumnName("be_ref_moraactual_30_imf500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Tar0)
                    .HasColumnName("be_ref_moraactual_30_tar0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Tar1000)
                    .HasColumnName("be_ref_moraactual_30_tar1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Tar1500)
                    .HasColumnName("be_ref_moraactual_30_tar1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Tar2000)
                    .HasColumnName("be_ref_moraactual_30_tar2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual30Tar500)
                    .HasColumnName("be_ref_moraactual_30_tar500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Ban0)
                    .HasColumnName("be_ref_moraactual_60_ban0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Ban1000)
                    .HasColumnName("be_ref_moraactual_60_ban1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Ban1500)
                    .HasColumnName("be_ref_moraactual_60_ban1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Ban2000)
                    .HasColumnName("be_ref_moraactual_60_ban2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Ban500)
                    .HasColumnName("be_ref_moraactual_60_ban500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Com0)
                    .HasColumnName("be_ref_moraactual_60_com0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Com1000)
                    .HasColumnName("be_ref_moraactual_60_com1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Com1500)
                    .HasColumnName("be_ref_moraactual_60_com1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Com2000)
                    .HasColumnName("be_ref_moraactual_60_com2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Com500)
                    .HasColumnName("be_ref_moraactual_60_com500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Imf0)
                    .HasColumnName("be_ref_moraactual_60_imf0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Imf1000)
                    .HasColumnName("be_ref_moraactual_60_imf1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Imf1500)
                    .HasColumnName("be_ref_moraactual_60_imf1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Imf2000)
                    .HasColumnName("be_ref_moraactual_60_imf2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Imf500)
                    .HasColumnName("be_ref_moraactual_60_imf500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Tar0)
                    .HasColumnName("be_ref_moraactual_60_tar0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Tar1000)
                    .HasColumnName("be_ref_moraactual_60_tar1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Tar1500)
                    .HasColumnName("be_ref_moraactual_60_tar1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Tar2000)
                    .HasColumnName("be_ref_moraactual_60_tar2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual60Tar500)
                    .HasColumnName("be_ref_moraactual_60_tar500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual90Ban)
                    .HasColumnName("be_ref_moraactual_90_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual90Com)
                    .HasColumnName("be_ref_moraactual_90_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual90Imf)
                    .HasColumnName("be_ref_moraactual_90_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactual90Tar)
                    .HasColumnName("be_ref_moraactual_90_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualCobroadminCom)
                    .HasColumnName("be_ref_moraactual_cobroadmin_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualCobroadminImf)
                    .HasColumnName("be_ref_moraactual_cobroadmin_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualCobroadminTelco)
                    .HasColumnName("be_ref_moraactual_cobroadmin_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco120)
                    .HasColumnName("be_ref_moraactual_telco120")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco150)
                    .HasColumnName("be_ref_moraactual_telco150")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco180)
                    .HasColumnName("be_ref_moraactual_telco180")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco300)
                    .HasColumnName("be_ref_moraactual_telco30_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco301000)
                    .HasColumnName("be_ref_moraactual_telco30_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco301500)
                    .HasColumnName("be_ref_moraactual_telco30_1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco302000)
                    .HasColumnName("be_ref_moraactual_telco30_2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco30500)
                    .HasColumnName("be_ref_moraactual_telco30_500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco600)
                    .HasColumnName("be_ref_moraactual_telco60_0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco601000)
                    .HasColumnName("be_ref_moraactual_telco60_1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco601500)
                    .HasColumnName("be_ref_moraactual_telco60_1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco602000)
                    .HasColumnName("be_ref_moraactual_telco60_2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco60500)
                    .HasColumnName("be_ref_moraactual_telco60_500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefMoraactualTelco90)
                    .HasColumnName("be_ref_moraactual_telco90")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeRefjudicialCom)
                    .HasColumnName("be_refjudicial_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact120Tar)
                    .HasColumnName("be_saldo_moraact_120_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact150Tar)
                    .HasColumnName("be_saldo_moraact_150_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact180Tar)
                    .HasColumnName("be_saldo_moraact_180_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact30dTar0)
                    .HasColumnName("be_saldo_moraact_30d_tar0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact30dTar1000)
                    .HasColumnName("be_saldo_moraact_30d_tar1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact30dTar1500)
                    .HasColumnName("be_saldo_moraact_30d_tar1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact30dTar2000)
                    .HasColumnName("be_saldo_moraact_30d_tar2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact30dTar500)
                    .HasColumnName("be_saldo_moraact_30d_tar500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact60dTar0)
                    .HasColumnName("be_saldo_moraact_60d_tar0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact60dTar1000)
                    .HasColumnName("be_saldo_moraact_60d_tar1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact60dTar1500)
                    .HasColumnName("be_saldo_moraact_60d_tar1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact60dTar2000)
                    .HasColumnName("be_saldo_moraact_60d_tar2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact60dTar500)
                    .HasColumnName("be_saldo_moraact_60d_tar500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldoMoraact90Tar)
                    .HasColumnName("be_saldo_moraact_90_tar")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldocastActualBan)
                    .HasColumnName("be_saldocast_actual_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact120Ban)
                    .HasColumnName("be_saldomoraact_120_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact120Com)
                    .HasColumnName("be_saldomoraact_120_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact120Imf)
                    .HasColumnName("be_saldomoraact_120_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact120Telco)
                    .HasColumnName("be_saldomoraact_120_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact150Ban)
                    .HasColumnName("be_saldomoraact_150_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact150Com)
                    .HasColumnName("be_saldomoraact_150_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact150Imf)
                    .HasColumnName("be_saldomoraact_150_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact150Telco)
                    .HasColumnName("be_saldomoraact_150_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact180Ban)
                    .HasColumnName("be_saldomoraact_180_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact180Com)
                    .HasColumnName("be_saldomoraact_180_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact180Imf)
                    .HasColumnName("be_saldomoraact_180_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact180Telco)
                    .HasColumnName("be_saldomoraact_180_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Ban0)
                    .HasColumnName("be_saldomoraact_30_ban0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Ban1000)
                    .HasColumnName("be_saldomoraact_30_ban1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Ban1500)
                    .HasColumnName("be_saldomoraact_30_ban1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Ban2000)
                    .HasColumnName("be_saldomoraact_30_ban2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Ban500)
                    .HasColumnName("be_saldomoraact_30_ban500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Com0)
                    .HasColumnName("be_saldomoraact_30_com0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Com1000)
                    .HasColumnName("be_saldomoraact_30_com1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Com1500)
                    .HasColumnName("be_saldomoraact_30_com1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Com2000)
                    .HasColumnName("be_saldomoraact_30_com2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Com500)
                    .HasColumnName("be_saldomoraact_30_com500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Imf0)
                    .HasColumnName("be_saldomoraact_30_imf0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Imf1000)
                    .HasColumnName("be_saldomoraact_30_imf1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Imf1500)
                    .HasColumnName("be_saldomoraact_30_imf1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Imf2000)
                    .HasColumnName("be_saldomoraact_30_imf2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Imf500)
                    .HasColumnName("be_saldomoraact_30_imf500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Telco0)
                    .HasColumnName("be_saldomoraact_30_telco0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Telco1000)
                    .HasColumnName("be_saldomoraact_30_telco1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Telco1500)
                    .HasColumnName("be_saldomoraact_30_telco1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Telco2000)
                    .HasColumnName("be_saldomoraact_30_telco2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact30Telco500)
                    .HasColumnName("be_saldomoraact_30_telco500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Ban0)
                    .HasColumnName("be_saldomoraact_60_ban0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Ban1000)
                    .HasColumnName("be_saldomoraact_60_ban1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Ban1500)
                    .HasColumnName("be_saldomoraact_60_ban1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Ban2000)
                    .HasColumnName("be_saldomoraact_60_ban2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Ban500)
                    .HasColumnName("be_saldomoraact_60_ban500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Com0)
                    .HasColumnName("be_saldomoraact_60_com0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Com1000)
                    .HasColumnName("be_saldomoraact_60_com1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Com1500)
                    .HasColumnName("be_saldomoraact_60_com1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Com2000)
                    .HasColumnName("be_saldomoraact_60_com2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Com500)
                    .HasColumnName("be_saldomoraact_60_com500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Imf0)
                    .HasColumnName("be_saldomoraact_60_imf0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Imf1000)
                    .HasColumnName("be_saldomoraact_60_imf1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Imf1500)
                    .HasColumnName("be_saldomoraact_60_imf1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Imf2000)
                    .HasColumnName("be_saldomoraact_60_imf2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Imf500)
                    .HasColumnName("be_saldomoraact_60_imf500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Telco0)
                    .HasColumnName("be_saldomoraact_60_telco0")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Telco1000)
                    .HasColumnName("be_saldomoraact_60_telco1000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Telco1500)
                    .HasColumnName("be_saldomoraact_60_telco1500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Telco2000)
                    .HasColumnName("be_saldomoraact_60_telco2000")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact60Telco500)
                    .HasColumnName("be_saldomoraact_60_telco500")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact90Ban)
                    .HasColumnName("be_saldomoraact_90_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact90Com)
                    .HasColumnName("be_saldomoraact_90_com")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact90Imf)
                    .HasColumnName("be_saldomoraact_90_imf")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldomoraact90Telco)
                    .HasColumnName("be_saldomoraact_90_telco")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeSaldovencBan)
                    .HasColumnName("be_saldovenc_ban")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeScore)
                    .HasColumnName("be_score")
                    .HasColumnType("numeric");

                entity.Property(e => e.BeTarCalificacionActual)
                    .HasColumnName("be_tar_calificacion_actual")
                    .HasColumnType("numeric");

                entity.Property(e => e.Entidad)
                    .HasColumnName("entidad")
                    .HasColumnType("numeric");

                entity.Property(e => e.FchConsulta).HasColumnName("fch_consulta");

                entity.Property(e => e.MoActividadeconomicaAcc)
                    .HasColumnName("mo_actividadeconomica_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoActividadeconomicaDes).HasColumnName("mo_actividadeconomica_des");

                entity.Property(e => e.MoAntiguedadDomicilioActual)
                    .HasColumnName("mo_antiguedad_domicilio_actual")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoAntiguedadLaboral)
                    .HasColumnName("mo_antiguedad_laboral")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoCuota)
                    .HasColumnName("mo_cuota")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoCuotaIngreso)
                    .HasColumnName("mo_cuota_ingreso")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoDomicilioZonariesgoAcc)
                    .HasColumnName("mo_domicilio_zonariesgo_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoDomicilioZonariesgoDesc).HasColumnName("mo_domicilio_zonariesgo_desc ");

                entity.Property(e => e.MoEdad)
                    .HasColumnName("mo_edad")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoEgreso)
                    .HasColumnName("mo_egreso")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoEndeudamientoActual)
                    .HasColumnName("mo_endeudamiento_actual")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoEndeudamientoSalida)
                    .HasColumnName("mo_endeudamiento_salida")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoEstadoCivilAcc)
                    .HasColumnName("mo_estado_civil_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoEstadoCivilDes).HasColumnName("mo_estado_civil_des");

                entity.Property(e => e.MoIngreso)
                    .HasColumnName("mo_ingreso")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoNacionalidadAcc)
                    .HasColumnName("mo_nacionalidad_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoNacionalidadDes).HasColumnName("mo_nacionalidad_des");

                entity.Property(e => e.MoNombreCliente).HasColumnName("mo_nombre_cliente");

                entity.Property(e => e.MoProfesionAcc)
                    .HasColumnName("mo_profesion_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoProfesionDes).HasColumnName("mo_profesion_des");

                entity.Property(e => e.MoTipoPersona)
                    .HasColumnName("mo_tipo_persona")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoTipoViviendaAcc)
                    .HasColumnName("mo_tipo_vivienda_acc")
                    .HasColumnType("numeric");

                entity.Property(e => e.MoTipoViviendaDes).HasColumnName("mo_tipo_vivienda_des");
            });

            modelBuilder.Entity<Estadociv>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.EmpreSaf })
                    .HasName("estadociv_pkey");

                entity.ToTable("estadociv");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodEnasegur)
                    .IsRequired()
                    .HasColumnName("cod_enasegur")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EsEmpresa)
                    .HasColumnName("es_empresa")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Estadociv1)
                    .IsRequired()
                    .HasColumnName("estadociv")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.HabilitarInfconyugue)
                    .HasColumnName("habilitar_infconyugue")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(10,0)");
            });

            modelBuilder.Entity<Evalufinan>(entity =>
            {
                entity.HasKey(e => e.Idevalufin)
                    .HasName("evalufinan_pkey");

                entity.ToTable("evalufinan");

                entity.Property(e => e.Idevalufin)
                    .HasColumnName("idevalufin")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codsolicitud).HasColumnName("codsolicitud");

                entity.Property(e => e.Estganacosvent)
                    .HasColumnName("estganacosvent")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganaganneta)
                    .HasColumnName("estganaganneta")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganagastfam)
                    .HasColumnName("estganagastfam")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganagastope)
                    .HasColumnName("estganagastope")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganaingreven)
                    .HasColumnName("estganaingreven")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganamarconfi)
                    .HasColumnName("estganamarconfi")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganaotro)
                    .HasColumnName("estganaotro")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganautibrut)
                    .HasColumnName("estganautibrut")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estganautioper)
                    .HasColumnName("estganautioper")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajuscator)
                    .HasColumnName("ganajuscator")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajusegre)
                    .HasColumnName("ganajusegre")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajusingre)
                    .HasColumnName("ganajusingre")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajusmensu)
                    .HasColumnName("ganajusmensu")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajussema)
                    .HasColumnName("ganajussema")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajusultneta)
                    .HasColumnName("ganajusultneta")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ganajusvent)
                    .HasColumnName("ganajusvent")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamagua)
                    .HasColumnName("gasfamagua")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamalimen)
                    .HasColumnName("gasfamalimen")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfameduca)
                    .HasColumnName("gasfameduca")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamelectri)
                    .HasColumnName("gasfamelectri")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamgas)
                    .HasColumnName("gasfamgas")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamotros)
                    .HasColumnName("gasfamotros")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamsalud)
                    .HasColumnName("gasfamsalud")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamtelefono)
                    .HasColumnName("gasfamtelefono")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamtotal)
                    .HasColumnName("gasfamtotal")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamtranspor)
                    .HasColumnName("gasfamtranspor")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamvestu)
                    .HasColumnName("gasfamvestu")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gasfamvivie)
                    .HasColumnName("gasfamvivie")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gopereagua)
                    .HasColumnName("gopereagua")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperealquiler)
                    .HasColumnName("goperealquiler")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperectasprest)
                    .HasColumnName("goperectasprest")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gopereelectri)
                    .HasColumnName("gopereelectri")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperegas)
                    .HasColumnName("goperegas")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gopereimpuesto)
                    .HasColumnName("gopereimpuesto")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperemantrenta)
                    .HasColumnName("goperemantrenta")
                    .HasColumnType("numeric");

                entity.Property(e => e.Gopereotros)
                    .HasColumnName("gopereotros")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperesalarios)
                    .HasColumnName("goperesalarios")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperetelefono)
                    .HasColumnName("goperetelefono")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperetotal)
                    .HasColumnName("goperetotal")
                    .HasColumnType("numeric");

                entity.Property(e => e.Goperetrans)
                    .HasColumnName("goperetrans")
                    .HasColumnType("numeric");

                entity.Property(e => e.Oingreconyugue)
                    .HasColumnName("oingreconyugue")
                    .HasColumnType("numeric");

                entity.Property(e => e.Oingreotrosneg)
                    .HasColumnName("oingreotrosneg")
                    .HasColumnType("numeric");

                entity.Property(e => e.Oingreremesas)
                    .HasColumnName("oingreremesas")
                    .HasColumnType("numeric");

                entity.Property(e => e.Oingresalarios)
                    .HasColumnName("oingresalarios")
                    .HasColumnType("numeric");

                entity.Property(e => e.Oingretotal)
                    .HasColumnName("oingretotal")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriahorro)
                    .HasColumnName("patriahorro")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriantmerca)
                    .HasColumnName("patriantmerca")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patribanco)
                    .HasColumnName("patribanco")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriccobra)
                    .HasColumnName("patriccobra")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriccomer)
                    .HasColumnName("patriccomer")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patricempe)
                    .HasColumnName("patricempe")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patricoopera)
                    .HasColumnName("patricoopera")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriefec)
                    .HasColumnName("patriefec")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patrifami)
                    .HasColumnName("patrifami")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriinven)
                    .HasColumnName("patriinven")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patrimaqui)
                    .HasColumnName("patrimaqui")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patrimicro)
                    .HasColumnName("patrimicro")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patripresta)
                    .HasColumnName("patripresta")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriprogob)
                    .HasColumnName("patriprogob")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriprovee)
                    .HasColumnName("patriprovee")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patritactivo)
                    .HasColumnName("patritactivo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patritelefo)
                    .HasColumnName("patritelefo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patriterreno)
                    .HasColumnName("patriterreno")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patritpasivo)
                    .HasColumnName("patritpasivo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patrivehicu)
                    .HasColumnName("patrivehicu")
                    .HasColumnType("numeric");

                entity.Property(e => e.Patrivivienda)
                    .HasColumnName("patrivivienda")
                    .HasColumnType("numeric");

                entity.Property(e => e.Vbaja)
                    .HasColumnName("vbaja")
                    .HasColumnType("numeric");

                entity.Property(e => e.Vbuena)
                    .HasColumnName("vbuena")
                    .HasColumnType("numeric");

                entity.Property(e => e.Vreccxc)
                    .HasColumnName("vreccxc")
                    .HasColumnType("numeric");

                entity.Property(e => e.Vregular)
                    .HasColumnName("vregular")
                    .HasColumnType("numeric");

                entity.Property(e => e.Vtotmensual)
                    .HasColumnName("vtotmensual")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<ExcepcionesAppMovil>(entity =>
            {
                entity.ToTable("excepciones_app_movil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 999999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Devicetype)
                    .IsRequired()
                    .HasColumnName("devicetype");

                entity.Property(e => e.Devincename)
                    .IsRequired()
                    .HasColumnName("devincename");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Idasesor)
                    .HasColumnName("idasesor")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idiom)
                    .IsRequired()
                    .HasColumnName("idiom");

                entity.Property(e => e.Lineexc)
                    .IsRequired()
                    .HasColumnName("lineexc");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer");

                entity.Property(e => e.Messageexc)
                    .IsRequired()
                    .HasColumnName("messageexc");

                entity.Property(e => e.Modeldevice)
                    .IsRequired()
                    .HasColumnName("modeldevice");

                entity.Property(e => e.Nameexc)
                    .IsRequired()
                    .HasColumnName("nameexc");

                entity.Property(e => e.Osrun)
                    .IsRequired()
                    .HasColumnName("osrun");

                entity.Property(e => e.Pageexc)
                    .IsRequired()
                    .HasColumnName("pageexc");

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasColumnName("platform");

                entity.Property(e => e.Processexc)
                    .IsRequired()
                    .HasColumnName("processexc");
            });

            modelBuilder.Entity<Factordecambio>(entity =>
            {
                entity.ToTable("factordecambio");

                entity.Property(e => e.Factordecambioid)
                    .HasColumnName("factordecambioid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.PeriInfo).HasColumnName("peri_info");

                entity.Property(e => e.TipoMone).HasColumnName("tipo_mone");

                entity.Property(e => e.ValoDola).HasColumnName("valo_dola");
            });

            modelBuilder.Entity<Fiadorescomercio>(entity =>
            {
                entity.ToTable("fiadorescomercio");

                entity.Property(e => e.Fiadorescomercioid)
                    .HasColumnName("fiadorescomercioid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CodiEsta).HasColumnName("codi_esta");

                entity.Property(e => e.CodiFnte).HasColumnName("codi_fnte");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.FactCamb).HasColumnName("fact_camb");

                entity.Property(e => e.FechAper).HasColumnName("fech_aper");

                entity.Property(e => e.FechCanc).HasColumnName("fech_canc");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.FechInfo).HasColumnName("fech_info");

                entity.Property(e => e.FechMora).HasColumnName("fech_mora");

                entity.Property(e => e.FechVenc).HasColumnName("fech_venc");

                entity.Property(e => e.FormPago).HasColumnName("form_pago");

                entity.Property(e => e.MoneMont).HasColumnName("mone_mont");

                entity.Property(e => e.MoneMora).HasColumnName("mone_mora");

                entity.Property(e => e.MonePago).HasColumnName("mone_pago");

                entity.Property(e => e.MoneSald).HasColumnName("mone_sald");

                entity.Property(e => e.MontOtor).HasColumnName("mont_otor");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.NumeCuen).HasColumnName("nume_cuen");

                entity.Property(e => e.NumeCuot).HasColumnName("nume_cuot");

                entity.Property(e => e.PagoCuot).HasColumnName("pago_cuot");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.RegiImpu).HasColumnName("regi_impu");

                entity.Property(e => e.SaldMora).HasColumnName("sald_mora");

                entity.Property(e => e.SaldTota).HasColumnName("sald_tota");

                entity.Property(e => e.TipoCred).HasColumnName("tipo_cred");

                entity.Property(e => e.TipoDeud).HasColumnName("tipo_deud");

                entity.Property(e => e.TipoInfo).HasColumnName("tipo_info");
            });

            modelBuilder.Entity<Fondos>(entity =>
            {
                entity.HasKey(e => e.Fondo)
                    .HasName("fondos_pkey");

                entity.ToTable("fondos");

                entity.Property(e => e.Fondo).HasColumnName("fondo");

                entity.Property(e => e.DescFondo)
                    .IsRequired()
                    .HasColumnName("desc_fondo");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.Fondeador)
                    .HasColumnName("fondeador")
                    .HasColumnType("numeric");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("numeric");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo");

                entity.Property(e => e.Ultimaactualizacion)
                    .IsRequired()
                    .HasColumnName("ultimaactualizacion");
            });

            modelBuilder.Entity<Frecuenc>(entity =>
            {
                entity.HasKey(e => new { e.Frec, e.EmpreSaf })
                    .HasName("frecuenc_pkey");

                entity.ToTable("frecuenc");

                entity.Property(e => e.Frec)
                    .HasColumnName("frec")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.CntAnual)
                    .HasColumnName("cnt_anual")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.DescFrec)
                    .IsRequired()
                    .HasColumnName("desc_frec")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Factor)
                    .HasColumnName("factor")
                    .HasColumnType("numeric(4,2)");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("unidad")
                    .HasDefaultValueSql("'ANUAL'::text");
            });

            modelBuilder.Entity<Garantias>(entity =>
            {
                entity.HasKey(e => new { e.Aval, e.Tpaval })
                    .HasName("garantias_pkey");

                entity.ToTable("garantias");

                entity.Property(e => e.Aval)
                    .HasColumnName("aval")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tpaval)
                    .HasColumnName("tpaval")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Anio)
                    .HasColumnName("anio")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.AvalReferencia)
                    .IsRequired()
                    .HasColumnName("aval_referencia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CantSemovientes)
                    .HasColumnName("cant_semovientes")
                    .HasColumnType("numeric(11,0)");

                entity.Property(e => e.Chasis)
                    .IsRequired()
                    .HasColumnName("chasis")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cilindraje)
                    .IsRequired()
                    .HasColumnName("cilindraje")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ClsGarantia)
                    .HasColumnName("cls_garantia")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("80101");

                entity.Property(e => e.CodCiud)
                    .HasColumnName("cod_ciud")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("801");

                entity.Property(e => e.CodCustodia)
                    .IsRequired()
                    .HasColumnName("cod_custodia")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescAvaluo)
                    .IsRequired()
                    .HasColumnName("desc_avaluo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescNotaria)
                    .IsRequired()
                    .HasColumnName("desc_notaria")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.FchEntrega)
                    .HasColumnName("fch_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.FchSuscripcion)
                    .HasColumnName("fch_suscripcion")
                    .HasColumnType("date");

                entity.Property(e => e.FchVencimiento)
                    .HasColumnName("fch_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdTpgarantiaHipo)
                    .HasColumnName("id_tpgarantia_hipo")
                    .HasColumnType("numeric(3,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.InfoCustodia)
                    .HasColumnName("info_custodia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasColumnName("lugar")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Motor)
                    .IsRequired()
                    .HasColumnName("motor")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NomValuador)
                    .IsRequired()
                    .HasColumnName("nom_valuador")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumContrato)
                    .IsRequired()
                    .HasColumnName("num_contrato")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.NumIdentificacion)
                    .IsRequired()
                    .HasColumnName("num_identificacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumPlaca)
                    .IsRequired()
                    .HasColumnName("num_placa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Raza)
                    .IsRequired()
                    .HasColumnName("raza")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnName("responsable")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelAsegu)
                    .IsRequired()
                    .HasColumnName("tel_asegu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelCustodia)
                    .IsRequired()
                    .HasColumnName("tel_custodia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TieneSeguro)
                    .HasColumnName("tiene_seguro")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TipoCobertura)
                    .IsRequired()
                    .HasColumnName("tipo_cobertura")
                    .HasDefaultValueSql("'T'::text");

                entity.Property(e => e.TipoHipoteca)
                    .HasColumnName("tipo_hipoteca")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpbien)
                    .HasColumnName("tpbien")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Tpgarantiam)
                    .HasColumnName("tpgarantiam")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Tpidentificacion)
                    .IsRequired()
                    .HasColumnName("tpidentificacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ValorProyectado)
                    .HasColumnName("valor_proyectado")
                    .HasColumnType("numeric(15,2)");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("vin")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)");
            });

            modelBuilder.Entity<GrpEcon>(entity =>
            {
                entity.HasKey(e => e.GrpEcon1)
                    .HasName("grp_econ_pkey");

                entity.ToTable("grp_econ");

                entity.Property(e => e.GrpEcon1)
                    .HasColumnName("grp_econ")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.DescGrp).HasColumnName("desc_grp");
            });

            modelBuilder.Entity<Identificacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("identificacion_pkey");

                entity.ToTable("identificacion");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodUnired)
                    .HasColumnName("cod_unired")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Editable)
                    .HasColumnName("editable")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.EsEmpresa)
                    .HasColumnName("es_empresa")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.Identificacion1)
                    .IsRequired()
                    .HasColumnName("identificacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Mascara)
                    .IsRequired()
                    .HasColumnName("mascara")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tpcliente)
                    .HasColumnName("tpcliente")
                    .HasColumnType("numeric(2,0)");
            });

            modelBuilder.Entity<Identificacionsujeto>(entity =>
            {
                entity.ToTable("identificacionsujeto");

                entity.Property(e => e.Identificacionsujetoid)
                    .HasColumnName("identificacionsujetoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fechareporte).HasColumnName("fechareporte");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Imgservidor>(entity =>
            {
                entity.ToTable("imgservidor");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion");
            });

            modelBuilder.Entity<IndClienteNegocio>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.EmpreSaf })
                    .HasName("ind_cliente_negocio_pkey");

                entity.ToTable("ind_cliente_negocio");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.ActEco)
                    .IsRequired()
                    .HasColumnName("act_eco")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.CicloRotacion)
                    .IsRequired()
                    .HasColumnName("ciclo_rotacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ClasifMypme)
                    .HasColumnName("clasif_mypme")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric(8,0)")
                    .HasDefaultValueSql("80101");

                entity.Property(e => e.CodCiudad)
                    .HasColumnName("cod_ciudad")
                    .HasColumnType("numeric(6,0)")
                    .HasDefaultValueSql("801");

                entity.Property(e => e.CodLugpob)
                    .HasColumnName("cod_lugpob")
                    .HasColumnType("numeric(12,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DiasDescanso)
                    .IsRequired()
                    .HasColumnName("dias_descanso")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DiasSemana)
                    .IsRequired()
                    .HasColumnName("dias_semana")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dir1)
                    .IsRequired()
                    .HasColumnName("dir1")
                    .HasDefaultValueSql("'N/A'::text");

                entity.Property(e => e.EmplFam)
                    .HasColumnName("empl_fam")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.EmplFijos)
                    .HasColumnName("empl_fijos")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.EmplRemunerados)
                    .HasColumnName("empl_remunerados")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchInicio)
                    .HasColumnName("fch_inicio")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchPto)
                    .HasColumnName("fch_pto")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.GestionJuridica)
                    .IsRequired()
                    .HasColumnName("gestion_juridica")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.HorarioFin)
                    .IsRequired()
                    .HasColumnName("horario_fin")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.HorarioIni)
                    .IsRequired()
                    .HasColumnName("horario_ini")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.IngMensual)
                    .HasColumnName("ing_mensual")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.InvRotacion)
                    .HasColumnName("inv_rotacion")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.LlevaActas)
                    .IsRequired()
                    .HasColumnName("lleva_actas")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LlevaConta)
                    .IsRequired()
                    .HasColumnName("lleva_conta")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LlevaEstatutos)
                    .IsRequired()
                    .HasColumnName("lleva_estatutos")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LlevaPrestamos)
                    .IsRequired()
                    .HasColumnName("lleva_prestamos")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.LlevaReglamentos)
                    .IsRequired()
                    .HasColumnName("lleva_reglamentos")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NomNegocio)
                    .IsRequired()
                    .HasColumnName("nom_negocio")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NumDepto)
                    .HasColumnName("num_depto")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("8");

                entity.Property(e => e.NumeroEmpl)
                    .HasColumnName("numero_empl")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("96");

                entity.Property(e => e.Propiedad)
                    .IsRequired()
                    .HasColumnName("propiedad")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SclasifMypme)
                    .HasColumnName("sclasif_mypme")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.TelCelular)
                    .IsRequired()
                    .HasColumnName("tel_celular")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelFijo)
                    .IsRequired()
                    .HasColumnName("tel_fijo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelNeg)
                    .IsRequired()
                    .HasColumnName("tel_neg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tenencia)
                    .IsRequired()
                    .HasColumnName("tenencia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TiempoAlq)
                    .IsRequired()
                    .HasColumnName("tiempo_alq")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TieneSocios)
                    .IsRequired()
                    .HasColumnName("tiene_socios")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TipoNegocio)
                    .IsRequired()
                    .HasColumnName("tipo_negocio")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<IndClienteReferencia>(entity =>
            {
                entity.HasKey(e => e.Idreferencia)
                    .HasName("ind_cliente_referencia_pkey");

                entity.ToTable("ind_cliente_referencia");

                entity.Property(e => e.Idreferencia)
                    .HasColumnName("idreferencia")
                    .HasColumnType("numeric(22,0)");

                entity.Property(e => e.CedulaCliente)
                    .IsRequired()
                    .HasColumnName("cedula_cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnName("celular")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Confirmada)
                    .HasColumnName("confirmada")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EsFamiliar)
                    .HasColumnName("es_familiar")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasColumnName("lugar")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NoCuenta)
                    .IsRequired()
                    .HasColumnName("no_cuenta")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Relacion)
                    .IsRequired()
                    .HasColumnName("relacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TelTrabajo)
                    .IsRequired()
                    .HasColumnName("tel_trabajo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TiempoResidir)
                    .HasColumnName("tiempo_residir")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Tpreferencia)
                    .HasColumnName("tpreferencia")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Tpresidencia)
                    .IsRequired()
                    .HasColumnName("tpresidencia")
                    .HasDefaultValueSql("'P'::text");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric(5,0)");
            });

            modelBuilder.Entity<IndClienteResidencia>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.IdDir, e.EmpreSaf })
                    .HasName("ind_cliente_residencia_pkey");

                entity.ToTable("ind_cliente_residencia");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.IdDir)
                    .HasColumnName("id_dir")
                    .HasColumnType("numeric");

                entity.Property(e => e.EmpreSaf)
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Adobe)
                    .HasColumnName("adobe")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Agua)
                    .HasColumnName("agua")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.AguasNegras)
                    .HasColumnName("aguas_negras")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Bloque)
                    .HasColumnName("bloque")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Cable)
                    .HasColumnName("cable")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CntTrabajan)
                    .HasColumnName("cnt_trabajan")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchAlquilar)
                    .HasColumnName("fch_alquilar")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.FchRecidir)
                    .HasColumnName("fch_recidir")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Ladrillo)
                    .HasColumnName("ladrillo")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Luz)
                    .HasColumnName("luz")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Madera)
                    .HasColumnName("madera")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Miembros)
                    .HasColumnName("miembros")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.MonedaPago)
                    .HasColumnName("moneda_pago")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Otros)
                    .HasColumnName("otros")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.PagoMensual)
                    .HasColumnName("pago_mensual")
                    .HasColumnType("numeric(13,2)");
            });

            modelBuilder.Entity<IscIndVar>(entity =>
            {
                entity.HasKey(e => new { e.CodInd, e.CodVar })
                    .HasName("isc_ind_var_pkey");

                entity.ToTable("isc_ind_var");

                entity.Property(e => e.CodInd)
                    .HasColumnName("cod_ind")
                    .HasColumnType("numeric");

                entity.Property(e => e.CodVar)
                    .HasColumnName("cod_var")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<IscIndicador>(entity =>
            {
                entity.HasKey(e => e.CodIndsoc)
                    .HasName("isc_indicador_pkey");

                entity.ToTable("isc_indicador");

                entity.Property(e => e.CodIndsoc)
                    .HasColumnName("cod_indsoc")
                    .HasColumnType("numeric");

                entity.Property(e => e.CodGrpind)
                    .HasColumnName("cod_grpind")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescIndsoc)
                    .IsRequired()
                    .HasColumnName("desc_indsoc")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.Generar)
                    .HasColumnName("generar")
                    .HasColumnType("numeric");

                entity.Property(e => e.IndFormula)
                    .IsRequired()
                    .HasColumnName("ind_formula")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.OpResul)
                    .IsRequired()
                    .HasColumnName("op_resul")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<IscOperadores>(entity =>
            {
                entity.HasKey(e => e.CodOper)
                    .HasName("isc_operadores_pkey");

                entity.ToTable("isc_operadores");

                entity.Property(e => e.CodOper)
                    .HasColumnName("cod_oper")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.DescOper)
                    .IsRequired()
                    .HasColumnName("desc_oper")
                    .HasDefaultValueSql("' '::text");
            });

            modelBuilder.Entity<IscVariable>(entity =>
            {
                entity.HasKey(e => e.CodVar)
                    .HasName("isc_variable_pkey");

                entity.ToTable("isc_variable");

                entity.Property(e => e.CodVar)
                    .HasColumnName("cod_var")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Consulta)
                    .IsRequired()
                    .HasColumnName("consulta")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescVariable)
                    .IsRequired()
                    .HasColumnName("desc_variable")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EsFuncion)
                    .HasColumnName("es_funcion")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion")
                    .HasDefaultValueSql("' '::text");
            });

            modelBuilder.Entity<Lugarpoblado>(entity =>
            {
                entity.HasKey(e => new { e.CodLugpob, e.CodAldea, e.EmpreSaf })
                    .HasName("lugarpoblado_pkey");

                entity.ToTable("lugarpoblado");

                entity.Property(e => e.CodLugpob)
                    .HasColumnName("cod_lugpob")
                    .HasColumnType("numeric");

                entity.Property(e => e.CodAldea)
                    .HasColumnName("cod_aldea")
                    .HasColumnType("numeric");

                entity.Property(e => e.EmpreSaf).HasColumnName("empre_saf");

                entity.Property(e => e.CodTplugpob)
                    .HasColumnName("cod_tplugpob")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por");

                entity.Property(e => e.DescLugpob)
                    .IsRequired()
                    .HasColumnName("desc_lugpob");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Hogar)
                    .HasColumnName("hogar")
                    .HasColumnType("numeric");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasColumnType("numeric");

                entity.Property(e => e.VivColectiva)
                    .HasColumnName("viv_colectiva")
                    .HasColumnType("numeric");

                entity.Property(e => e.VivDesocupada)
                    .HasColumnName("viv_desocupada")
                    .HasColumnType("numeric");

                entity.Property(e => e.VivOcupada)
                    .HasColumnName("viv_ocupada")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Modelosprod>(entity =>
            {
                entity.HasKey(e => e.Modeloid)
                    .HasName("modelo_pkey");

                entity.ToTable("modelosprod");

                entity.Property(e => e.Modeloid)
                    .HasColumnName("modeloid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Productocodigo).HasColumnName("productocodigo");

                entity.Property(e => e.Resultado).HasColumnName("resultado");

                entity.Property(e => e.Texto).HasColumnName("texto");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.ToTable("moneda");

                entity.Property(e => e.Monedaid)
                    .HasColumnName("monedaid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Texto).HasColumnName("texto");
            });

            modelBuilder.Entity<Nivelusuario>(entity =>
            {
                entity.HasKey(e => e.Idnivel)
                    .HasName("Nivel_usuario_pkey");

                entity.ToTable("nivelusuario");

                entity.Property(e => e.Idnivel)
                    .HasColumnName("idnivel")
                    .HasIdentityOptions(null, null, null, 9999L, null, null);

                entity.Property(e => e.Dependencia).HasColumnName("dependencia");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Obligacionescerradas>(entity =>
            {
                entity.ToTable("obligacionescerradas");

                entity.Property(e => e.Obligacionescerradasid)
                    .HasColumnName("obligacionescerradasid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codigotipocuenta).HasColumnName("codigotipocuenta");

                entity.Property(e => e.Estadocodigo).HasColumnName("estadocodigo");

                entity.Property(e => e.Estadotexto).HasColumnName("estadotexto");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Textotipocuenta).HasColumnName("textotipocuenta");
            });

            modelBuilder.Entity<Obligacionesvigentes>(entity =>
            {
                entity.ToTable("obligacionesvigentes");

                entity.Property(e => e.Obligacionesvigentesid)
                    .HasColumnName("obligacionesvigentesid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codigotipocuenta).HasColumnName("codigotipocuenta");

                entity.Property(e => e.Estadocodigo).HasColumnName("estadocodigo");

                entity.Property(e => e.Estadotexto).HasColumnName("estadotexto");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Textotipocuenta).HasColumnName("textotipocuenta");
            });

            modelBuilder.Entity<Ocupacion>(entity =>
            {
                entity.HasKey(e => e.CodOcupacion)
                    .HasName("ocupacion_pkey");

                entity.ToTable("ocupacion");

                entity.Property(e => e.CodOcupacion)
                    .HasColumnName("cod_ocupacion")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.FechaCreado)
                    .HasColumnName("fecha_creado")
                    .HasColumnType("date");

                entity.Property(e => e.Idsesion)
                    .HasColumnName("idsesion")
                    .HasColumnType("numeric(22,0)");

                entity.Property(e => e.Ocupacion1)
                    .IsRequired()
                    .HasColumnName("ocupacion")
                    .HasDefaultValueSql("' '::text");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.CodPais)
                    .HasName("paises_pkey");

                entity.ToTable("paises");

                entity.Property(e => e.CodPais)
                    .HasColumnName("cod_pais")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Nacionalidad)
                    .IsRequired()
                    .HasColumnName("nacionalidad")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NombPais)
                    .IsRequired()
                    .HasColumnName("nomb_pais")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SiglasPais)
                    .IsRequired()
                    .HasColumnName("siglas_pais")
                    .HasDefaultValueSql("' '::text");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.ToTable("periodo");

                entity.Property(e => e.Periodoid)
                    .HasColumnName("periodoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Periodoactual).HasColumnName("periodoactual");
            });

            modelBuilder.Entity<Programa>(entity =>
            {
                entity.HasKey(e => e.Programa1)
                    .HasName("programa_pkey");

                entity.ToTable("programa");

                entity.Property(e => e.Programa1).HasColumnName("programa");

                entity.Property(e => e.DescPrg)
                    .IsRequired()
                    .HasColumnName("desc_prg");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo");

                entity.Property(e => e.Ultimaactualizacion)
                    .IsRequired()
                    .HasColumnName("ultimaactualizacion");
            });

            modelBuilder.Entity<Prueba1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prueba1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<RiesgoactividadDestino>(entity =>
            {
                entity.HasKey(e => e.Idactividad)
                    .HasName("riesgoactividad_destino_pkey");

                entity.ToTable("riesgoactividad_destino");

                entity.Property(e => e.Idactividad).HasColumnName("idactividad");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgoagencia>(entity =>
            {
                entity.HasKey(e => e.Idriesgoagencia)
                    .HasName("riesgoagencia_pkey");

                entity.ToTable("riesgoagencia");

                entity.Property(e => e.Idriesgoagencia).HasColumnName("idriesgoagencia");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgobitacora>(entity =>
            {
                entity.HasKey(e => e.Idriesgobitacora)
                    .HasName("riesgobitacora_pkey");

                entity.ToTable("riesgobitacora");

                entity.Property(e => e.Idriesgobitacora)
                    .HasColumnName("idriesgobitacora")
                    .HasColumnType("numeric");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("accion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("fecha");

                entity.Property(e => e.Idusuario)
                    .IsRequired()
                    .HasColumnName("idusuario");
            });

            modelBuilder.Entity<Riesgocategorizacion>(entity =>
            {
                entity.HasKey(e => e.Idriesgocategorizacion)
                    .HasName("riesgocategorizacion_pkey");

                entity.ToTable("riesgocategorizacion");

                entity.Property(e => e.Idriesgocategorizacion)
                    .HasColumnName("idriesgocategorizacion")
                    .HasColumnType("numeric");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");
            });

            modelBuilder.Entity<Riesgoclientes>(entity =>
            {
                entity.HasKey(e => e.Idriesgocliente)
                    .HasName("riesgoclientes_pkey");

                entity.ToTable("riesgoclientes");

                entity.Property(e => e.Idriesgocliente).HasColumnName("idriesgocliente");

                entity.Property(e => e.Apell).HasColumnName("apell");

                entity.Property(e => e.Clienteid)
                    .IsRequired()
                    .HasColumnName("clienteid");

                entity.Property(e => e.CodSolicitud).HasColumnName("cod_solicitud");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fechahora).HasColumnName("fechahora");

                entity.Property(e => e.Idactividad).HasColumnName("idactividad");

                entity.Property(e => e.Idestadocivil).HasColumnName("idestadocivil");

                entity.Property(e => e.Idgenero).HasColumnName("idgenero");

                entity.Property(e => e.Idparam)
                    .HasColumnName("idparam")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idriesgo)
                    .HasColumnName("idriesgo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idriesgoagencia).HasColumnName("idriesgoagencia");

                entity.Property(e => e.Idriesgomuni)
                    .HasColumnName("idriesgomuni")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idriesgooficio)
                    .HasColumnName("idriesgooficio")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idriesgoorigen).HasColumnName("idriesgoorigen");

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idtipopersona)
                    .HasColumnName("idtipopersona")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Importancia)
                    .HasColumnName("importancia")
                    .HasColumnType("numeric");

                entity.Property(e => e.Infornet).HasColumnName("infornet");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Ofac).HasColumnName("ofac");

                entity.Property(e => e.Onu).HasColumnName("onu");

                entity.Property(e => e.Peps).HasColumnName("peps");

                entity.Property(e => e.Rangoactual)
                    .HasColumnName("rangoactual")
                    .HasColumnType("numeric");

                entity.Property(e => e.Rangomax)
                    .HasColumnName("rangomax")
                    .HasColumnType("numeric");

                entity.Property(e => e.Rangomin)
                    .HasColumnName("rangomin")
                    .HasColumnType("numeric");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgodepartamentos>(entity =>
            {
                entity.HasKey(e => e.Idriesgodepto)
                    .HasName("riesgodepartamentos_pkey");

                entity.ToTable("riesgodepartamentos");

                entity.Property(e => e.Idriesgodepto)
                    .HasColumnName("idriesgodepto")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgoestadocivil>(entity =>
            {
                entity.HasKey(e => e.Idestadocivil)
                    .HasName("riesgoestadocivil_pkey");

                entity.ToTable("riesgoestadocivil");

                entity.Property(e => e.Idestadocivil).HasColumnName("idestadocivil");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric(2,0)");
            });

            modelBuilder.Entity<Riesgogenero>(entity =>
            {
                entity.HasKey(e => e.Idgenero)
                    .HasName("riesgogenero_pkey");

                entity.ToTable("riesgogenero");

                entity.Property(e => e.Idgenero)
                    .HasColumnName("idgenero")
                    .HasColumnType("numeric(7,0)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(1);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgoinfornet>(entity =>
            {
                entity.ToTable("riesgoinfornet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Identidad)
                    .IsRequired()
                    .HasColumnName("identidad");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Riesgoinstrumentomonetario>(entity =>
            {
                entity.HasKey(e => e.Idmonetario)
                    .HasName("riesgoinstrumentomonetario_pkey");

                entity.ToTable("riesgoinstrumentomonetario");

                entity.Property(e => e.Idmonetario)
                    .HasColumnName("idmonetario")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric(2,0)");
            });

            modelBuilder.Entity<Riesgomunicipio>(entity =>
            {
                entity.HasKey(e => e.Idriesgomuni)
                    .HasName("riesgomunicipio_pkey");

                entity.ToTable("riesgomunicipio");

                entity.Property(e => e.Idriesgomuni)
                    .HasColumnName("idriesgomuni")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Idriesgocategoria)
                    .HasColumnName("idriesgocategoria")
                    .HasColumnType("numeric");

                entity.Property(e => e.Idriesgodepto)
                    .HasColumnName("idriesgodepto")
                    .HasColumnType("numeric");

                entity.Property(e => e.Kilometroscuadrados)
                    .HasColumnName("kilometroscuadrados")
                    .HasColumnType("numeric");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Totaldelitos)
                    .HasColumnName("totaldelitos")
                    .HasColumnType("numeric");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgoofac>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("riesgoofac_pkey");

                entity.ToTable("riesgoofac");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Apellidos).HasColumnName("apellidos");

                entity.Property(e => e.Ciudad).HasColumnName("ciudad");

                entity.Property(e => e.Departamento).HasColumnName("departamento");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");

                entity.Property(e => e.Nombres).HasColumnName("nombres");

                entity.Property(e => e.Pais).HasColumnName("pais");

                entity.Property(e => e.Tipodocoumento).HasColumnName("tipodocoumento");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<Riesgoonu>(entity =>
            {
                entity.HasKey(e => e.Dataid)
                    .HasName("riesgoonu_pk");

                entity.ToTable("riesgoonu");

                entity.Property(e => e.Dataid).HasColumnName("dataid");

                entity.Property(e => e.Apellidos).HasColumnName("apellidos");

                entity.Property(e => e.Comentario).HasColumnName("comentario");

                entity.Property(e => e.Designacion).HasColumnName("designacion");

                entity.Property(e => e.Fechanacimiento).HasColumnName("fechanacimiento");

                entity.Property(e => e.Nacionalidad).HasColumnName("nacionalidad");

                entity.Property(e => e.Nombres).HasColumnName("nombres");

                entity.Property(e => e.Pasaporte).HasColumnName("pasaporte");
            });

            modelBuilder.Entity<RiesgoorigenSector>(entity =>
            {
                entity.HasKey(e => e.Idriesgoorigen)
                    .HasName("riesgoorigen_sector_pkey");

                entity.ToTable("riesgoorigen_sector");

                entity.Property(e => e.Idriesgoorigen).HasColumnName("idriesgoorigen");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgopeps>(entity =>
            {
                entity.HasKey(e => e.Identidad)
                    .HasName("riesgopeps_pkey");

                entity.ToTable("riesgopeps");

                entity.Property(e => e.Identidad).HasColumnName("identidad");

                entity.Property(e => e.Candidato)
                    .IsRequired()
                    .HasColumnName("candidato");

                entity.Property(e => e.Cargoelectoral)
                    .IsRequired()
                    .HasColumnName("cargoelectoral");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Partidopolitico)
                    .IsRequired()
                    .HasColumnName("partidopolitico");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("ubicacion");
            });

            modelBuilder.Entity<Riesgoprofesionoficio>(entity =>
            {
                entity.HasKey(e => e.Idriesgooficio)
                    .HasName("riesgoprofesionoficio_pkey");

                entity.ToTable("riesgoprofesionoficio");

                entity.Property(e => e.Idriesgooficio)
                    .HasColumnName("idriesgooficio")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgos>(entity =>
            {
                entity.HasKey(e => e.Idriesgo)
                    .HasName("riesgos_pkey");

                entity.ToTable("riesgos");

                entity.Property(e => e.Idriesgo)
                    .HasColumnName("idriesgo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Importancia)
                    .HasColumnName("importancia")
                    .HasColumnType("numeric");

                entity.Property(e => e.Tipoparam)
                    .IsRequired()
                    .HasColumnName("tipoparam");

                entity.Property(e => e.Valormaximo)
                    .HasColumnName("valormaximo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Valorminimo)
                    .HasColumnName("valorminimo")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgosector>(entity =>
            {
                entity.HasKey(e => e.Idriesgosector)
                    .HasName("riesgosector_pkey");

                entity.ToTable("riesgosector");

                entity.Property(e => e.Idriesgosector)
                    .HasColumnName("idriesgosector")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgosparametros>(entity =>
            {
                entity.HasKey(e => e.Idparam)
                    .HasName("riesgosparametros_pkey");

                entity.ToTable("riesgosparametros");

                entity.Property(e => e.Idparam)
                    .HasColumnName("idparam")
                    .HasColumnType("numeric");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Idriesgo)
                    .HasColumnName("idriesgo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Rangomaximo)
                    .HasColumnName("rangomaximo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Rangominimo)
                    .HasColumnName("rangominimo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgotipopersona>(entity =>
            {
                entity.HasKey(e => e.Idtipopersona)
                    .HasName("tipopersona_pkey");

                entity.ToTable("riesgotipopersona");

                entity.Property(e => e.Idtipopersona)
                    .HasColumnName("idtipopersona")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("numeric(2,0)");
            });

            modelBuilder.Entity<Riesgotipos>(entity =>
            {
                entity.HasKey(e => e.Idtipo)
                    .HasName("riesgotipos_pkey");

                entity.ToTable("riesgotipos");

                entity.Property(e => e.Idtipo)
                    .HasColumnName("idtipo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Importancia)
                    .HasColumnName("importancia")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Riesgousuarios>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("Riesgousuario_pkey");

                entity.ToTable("riesgousuarios");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Contrasena).HasColumnName("contrasena");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fchcreado)
                    .IsRequired()
                    .HasColumnName("fchcreado")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Tipousuario).HasColumnName("tipousuario");
            });

            modelBuilder.Entity<Scoreactual>(entity =>
            {
                entity.ToTable("scoreactual");

                entity.Property(e => e.Scoreactualid)
                    .HasColumnName("scoreactualid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Message1).HasColumnName("message_1");

                entity.Property(e => e.Message2).HasColumnName("message_2");

                entity.Property(e => e.Message3).HasColumnName("message_3");

                entity.Property(e => e.NumeNide).HasColumnName("nume_nide");

                entity.Property(e => e.PeriInfo).HasColumnName("peri_info");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.TypeScore).HasColumnName("type_score");
            });

            modelBuilder.Entity<Scorehistorico>(entity =>
            {
                entity.ToTable("scorehistorico");

                entity.Property(e => e.Scorehistoricoid)
                    .HasColumnName("scorehistoricoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.FactMsg1).HasColumnName("fact_msg1");

                entity.Property(e => e.FactMsg2).HasColumnName("fact_msg2");

                entity.Property(e => e.FactMsg3).HasColumnName("fact_msg3");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Tiposcore).HasColumnName("tiposcore");

                entity.Property(e => e.Valorscore).HasColumnName("valorscore");
            });

            modelBuilder.Entity<SectorEcono>(entity =>
            {
                entity.HasKey(e => e.Sector)
                    .HasName("sector_econo_pkey");

                entity.ToTable("sector_econo");

                entity.Property(e => e.Sector)
                    .HasColumnName("sector")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescSect)
                    .IsRequired()
                    .HasColumnName("desc_sect")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Esdetalle)
                    .HasColumnName("esdetalle")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.GrpSector)
                    .IsRequired()
                    .HasColumnName("grp_sector")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SalarioMin)
                    .HasColumnName("salario_min")
                    .HasColumnType("numeric(18,2)");
            });

            modelBuilder.Entity<Sincronizacion>(entity =>
            {
                entity.HasKey(e => e.IdSincro)
                    .HasName("Sincronizacion_pkey");

                entity.Property(e => e.IdSincro)
                    .HasColumnName("id_sincro")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescEstatus)
                    .IsRequired()
                    .HasColumnName("desc_estatus");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.FchSincro)
                    .IsRequired()
                    .HasColumnName("fch_sincro");

                entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.TipoSincro).HasColumnName("tipo_sincro");
            });

            modelBuilder.Entity<SlcDestinos>(entity =>
            {
                entity.HasKey(e => new { e.CodSolicitud})
                    .HasName("slc_destinos_pkey");

                entity.ToTable("slc_destinos");

                entity.Property(e => e.CodSolicitud).HasColumnName("cod_solicitud");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("numeric");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<SlcEstado>(entity =>
            {
                entity.HasKey(e => e.Estado)
                    .HasName("slc_estado_pkey");

                entity.ToTable("slc_estado");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.DescEstado)
                    .IsRequired()
                    .HasColumnName("desc_estado");

                entity.Property(e => e.FchCreacion)
                    .IsRequired()
                    .HasColumnName("fch_creacion");
            });

            modelBuilder.Entity<SlcReferencia>(entity =>
            {
                entity.ToTable("slc_referencia");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnName("celular");

                entity.Property(e => e.CodSolicitud)
                    .IsRequired()
                    .HasColumnName("cod_solicitud");

                entity.Property(e => e.CodsolicitudId).HasColumnName("codsolicitud_id");

                entity.Property(e => e.Confirmada)
                    .HasColumnName("confirmada")
                    .HasColumnType("numeric");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasColumnName("cuenta");

                entity.Property(e => e.CuotaMes)
                    .HasColumnName("cuota_mes")
                    .HasColumnType("numeric");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.Familiar)
                    .HasColumnName("familiar")
                    .HasColumnType("numeric");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasColumnName("lugar");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion");

                entity.Property(e => e.Relacion)
                    .IsRequired()
                    .HasColumnName("relacion");

                entity.Property(e => e.SldoAdeuda)
                    .HasColumnName("sldo_adeuda")
                    .HasColumnType("numeric");

                entity.Property(e => e.SldoDep)
                    .HasColumnName("sldo_dep")
                    .HasColumnType("numeric");

                entity.Property(e => e.TelTrabajo)
                    .IsRequired()
                    .HasColumnName("tel_trabajo");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono");

                entity.Property(e => e.TiempoResidir)
                    .HasColumnName("tiempo_residir")
                    .HasColumnType("numeric");

                entity.Property(e => e.Tpreferencia)
                    .HasColumnName("tpreferencia")
                    .HasColumnType("numeric");

                entity.Property(e => e.Tpresidencia)
                    .IsRequired()
                    .HasColumnName("tpresidencia");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<SldoPmo>(entity =>
            {
                entity.HasKey(e => e.FchCierre)
                    .HasName("sldo_pmo_pkey");

                entity.ToTable("sldo_pmo");

                entity.Property(e => e.FchCierre).HasColumnName("fch_cierre");

                entity.Property(e => e.ActivarGracia)
                    .IsRequired()
                    .HasColumnName("activar_gracia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CambiarCatcnbs)
                    .HasColumnName("cambiar_catcnbs")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CapVenc)
                    .HasColumnName("cap_venc")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Capital)
                    .HasColumnName("capital")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Capitalizar)
                    .HasColumnName("capitalizar")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.CargMra)
                    .HasColumnName("carg_mra")
                    .HasColumnType("numeric(9,7)");

                entity.Property(e => e.CasillaBch)
                    .HasColumnName("casilla_bch")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CasillaContab)
                    .HasColumnName("casilla_contab")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CasillaContabg)
                    .HasColumnName("casilla_contabg")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CasillaOrig)
                    .HasColumnName("casilla_orig")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CasillaPrevia)
                    .HasColumnName("casilla_previa")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CasillaPreviai)
                    .HasColumnName("casilla_previai")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CatCnbs)
                    .IsRequired()
                    .HasColumnName("cat_cnbs")
                    .HasDefaultValueSql("'1010'::text");

                entity.Property(e => e.CatCnbsg)
                    .IsRequired()
                    .HasColumnName("cat_cnbsg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CatCnbsprevia)
                    .IsRequired()
                    .HasColumnName("cat_cnbsprevia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CatCrrenegocia)
                    .HasColumnName("cat_crrenegocia")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CatDeudor)
                    .HasColumnName("cat_deudor")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Categoria)
                    .HasColumnName("categoria")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CategoriaPrevia)
                    .HasColumnName("categoria_previa")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Categoriag)
                    .HasColumnName("categoriag")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Categoriza)
                    .HasColumnName("categoriza")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.ClTasa)
                    .HasColumnName("cl_tasa")
                    .HasColumnType("numeric(9,6)");

                entity.Property(e => e.Clase)
                    .IsRequired()
                    .HasColumnName("clase")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClaseAnterior)
                    .HasColumnName("clase_anterior")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.Claseseg)
                    .HasColumnName("claseseg")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Claseseg2)
                    .HasColumnName("claseseg2")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cobraint)
                    .IsRequired()
                    .HasColumnName("cobraint")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cobramora)
                    .IsRequired()
                    .HasColumnName("cobramora")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CodAct)
                    .HasColumnName("cod_act")
                    .HasColumnType("numeric");

                entity.Property(e => e.CodMetodologia)
                    .HasColumnName("cod_metodologia")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Codubi)
                    .IsRequired()
                    .HasColumnName("codubi")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CostoAtotal)
                    .HasColumnName("costo_atotal")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Cptlizar)
                    .IsRequired()
                    .HasColumnName("cptlizar")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasColumnName("creado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Crgmravenc)
                    .HasColumnName("crgmravenc")
                    .HasColumnType("numeric(9,7)");

                entity.Property(e => e.CtaCapit)
                    .IsRequired()
                    .HasColumnName("cta_capit")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaCapit1)
                    .IsRequired()
                    .HasColumnName("cta_capit1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaIngres)
                    .IsRequired()
                    .HasColumnName("cta_ingres")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaInters)
                    .IsRequired()
                    .HasColumnName("cta_inters")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaIntsuspenso)
                    .IsRequired()
                    .HasColumnName("cta_intsuspenso")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaMora)
                    .IsRequired()
                    .HasColumnName("cta_mora")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaPtesuspenso)
                    .IsRequired()
                    .HasColumnName("cta_ptesuspenso")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaSeguro1)
                    .IsRequired()
                    .HasColumnName("cta_seguro1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaSeguro2)
                    .IsRequired()
                    .HasColumnName("cta_seguro2")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CtaVarios)
                    .IsRequired()
                    .HasColumnName("cta_varios")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CualVenc)
                    .HasColumnName("cual_venc")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.CuoPags)
                    .HasColumnName("cuo_pags")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.CuoVenc)
                    .HasColumnName("cuo_venc")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Cuotas)
                    .HasColumnName("cuotas")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Degracia)
                    .HasColumnName("degracia")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.DescAct)
                    .IsRequired()
                    .HasColumnName("desc_act")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescCatCnbs)
                    .IsRequired()
                    .HasColumnName("desc_cat_cnbs")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescCatCnbsg)
                    .IsRequired()
                    .HasColumnName("desc_cat_cnbsg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescClase)
                    .IsRequired()
                    .HasColumnName("desc_clase")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescDest)
                    .IsRequired()
                    .HasColumnName("desc_dest")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescEstat)
                    .IsRequired()
                    .HasColumnName("desc_estat")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescFondo)
                    .IsRequired()
                    .HasColumnName("desc_fondo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescFormapgo)
                    .IsRequired()
                    .HasColumnName("desc_formapgo")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.DescGrpCat)
                    .IsRequired()
                    .HasColumnName("desc_grp_cat")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescGrpTpgarantia)
                    .IsRequired()
                    .HasColumnName("desc_grp_tpgarantia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescModalidad)
                    .IsRequired()
                    .HasColumnName("desc_modalidad")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescPrg)
                    .IsRequired()
                    .HasColumnName("desc_prg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescSuc)
                    .IsRequired()
                    .HasColumnName("desc_suc")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.DescTpcredito)
                    .IsRequired()
                    .HasColumnName("desc_tpcredito")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.DescTpgarantia)
                    .IsRequired()
                    .HasColumnName("desc_tpgarantia")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.DescTpobligacion)
                    .IsRequired()
                    .HasColumnName("desc_tpobligacion")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.DescTpoperacion)
                    .IsRequired()
                    .HasColumnName("desc_tpoperacion")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.DescTprenegociacion)
                    .IsRequired()
                    .HasColumnName("desc_tprenegociacion")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasColumnName("destino")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Diasmora)
                    .HasColumnName("diasmora")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.Engrupo)
                    .HasColumnName("engrupo")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Estatusseg)
                    .HasColumnName("estatusseg")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Fch1erpgo)
                    .IsRequired()
                    .HasColumnName("fch_1erpgo");

                entity.Property(e => e.Fch1erseg)
                    .IsRequired()
                    .HasColumnName("fch_1erseg");

                entity.Property(e => e.FchAper)
                    .IsRequired()
                    .HasColumnName("fch_aper");

                entity.Property(e => e.FchApro)
                    .IsRequired()
                    .HasColumnName("fch_apro");

                entity.Property(e => e.FchCanc)
                    .IsRequired()
                    .HasColumnName("fch_canc");

                entity.Property(e => e.FchCastigo)
                    .IsRequired()
                    .HasColumnName("fch_castigo");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.FchUChgTasa)
                    .IsRequired()
                    .HasColumnName("fch_u_chg_tasa");

                entity.Property(e => e.FchUabono)
                    .IsRequired()
                    .HasColumnName("fch_uabono");

                entity.Property(e => e.FchUcalc)
                    .IsRequired()
                    .HasColumnName("fch_ucalc");

                entity.Property(e => e.FchUcap)
                    .IsRequired()
                    .HasColumnName("fch_ucap");

                entity.Property(e => e.FchUe)
                    .IsRequired()
                    .HasColumnName("fch_ue");

                entity.Property(e => e.FchUin)
                    .IsRequired()
                    .HasColumnName("fch_uin");

                entity.Property(e => e.FchUmora)
                    .IsRequired()
                    .HasColumnName("fch_umora");

                entity.Property(e => e.FchUmvo)
                    .IsRequired()
                    .HasColumnName("fch_umvo");

                entity.Property(e => e.FchUpgo)
                    .IsRequired()
                    .HasColumnName("fch_upgo");

                entity.Property(e => e.FchVenc)
                    .IsRequired()
                    .HasColumnName("fch_venc");

                entity.Property(e => e.FchVseg)
                    .IsRequired()
                    .HasColumnName("fch_vseg");

                entity.Property(e => e.Fondo)
                    .IsRequired()
                    .HasColumnName("fondo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Formapgo)
                    .HasColumnName("formapgo")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Frec)
                    .HasColumnName("frec")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Frec2)
                    .HasColumnName("frec2")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.FrecSeg)
                    .HasColumnName("frec_seg")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Gestor)
                    .HasColumnName("gestor")
                    .HasColumnType("numeric(5,0)");

                entity.Property(e => e.GrpCat)
                    .IsRequired()
                    .HasColumnName("grp_cat")
                    .HasDefaultValueSql("'70'::text");

                entity.Property(e => e.GrpTpgarantia)
                    .IsRequired()
                    .HasColumnName("grp_tpgarantia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.IdLineaCredito)
                    .HasColumnName("id_linea_credito")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.InstCnbs)
                    .IsRequired()
                    .HasColumnName("inst_cnbs")
                    .HasDefaultValueSql("'010101'::text");

                entity.Property(e => e.IntAcum)
                    .HasColumnName("int_acum")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntAno)
                    .HasColumnName("int_ano")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntAyer)
                    .HasColumnName("int_ayer")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntCap)
                    .HasColumnName("int_cap")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntDia)
                    .HasColumnName("int_dia")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntFijo)
                    .HasColumnName("int_fijo")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.IntMes)
                    .HasColumnName("int_mes")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntMesant)
                    .HasColumnName("int_mesant")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntMesdiaant)
                    .HasColumnName("int_mesdiaant")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntMora)
                    .HasColumnName("int_mora")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntMoradia)
                    .HasColumnName("int_moradia")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntMorames)
                    .HasColumnName("int_morames")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntNocrg)
                    .HasColumnName("int_nocrg")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntPend)
                    .HasColumnName("int_pend")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntPendant)
                    .HasColumnName("int_pendant")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntPgdo)
                    .HasColumnName("int_pgdo")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntProme)
                    .HasColumnName("int_prome")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.IntSeguro)
                    .HasColumnName("int_seguro")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.IntSuspenso)
                    .HasColumnName("int_suspenso")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntSuspensoant)
                    .HasColumnName("int_suspensoant")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.IntVenc)
                    .HasColumnName("int_venc")
                    .HasColumnType("numeric(13,4)");

                entity.Property(e => e.LmtSeg1)
                    .HasColumnName("lmt_seg1")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.LmtSeg2)
                    .HasColumnName("lmt_seg2")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Local1)
                    .HasColumnName("local1")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.ManejaIntsuspenso)
                    .HasColumnName("maneja_intsuspenso")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.ManejaListado)
                    .HasColumnName("maneja_listado")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Mes0Relativo)
                    .HasColumnName("mes0_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes10Relativo)
                    .HasColumnName("mes10_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes11Relativo)
                    .HasColumnName("mes11_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes12Relativo)
                    .HasColumnName("mes12_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes1Relativo)
                    .HasColumnName("mes1_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes2Relativo)
                    .HasColumnName("mes2_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes3Relativo)
                    .HasColumnName("mes3_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes4Relativo)
                    .HasColumnName("mes4_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes5Relativo)
                    .HasColumnName("mes5_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes6Relativo)
                    .HasColumnName("mes6_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes7Relativo)
                    .HasColumnName("mes7_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes8Relativo)
                    .HasColumnName("mes8_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Mes9Relativo)
                    .HasColumnName("mes9_relativo")
                    .HasColumnType("numeric(6,0)");

                entity.Property(e => e.Modalidad)
                    .HasColumnName("modalidad")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasColumnType("numeric(4,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora120)
                    .HasColumnName("mora120")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora15)
                    .HasColumnName("mora15")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora180)
                    .HasColumnName("mora180")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora30)
                    .HasColumnName("mora30")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora302)
                    .HasColumnName("mora30_2")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora365)
                    .HasColumnName("mora365")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora60)
                    .HasColumnName("mora60")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora7)
                    .HasColumnName("mora7")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Mora90)
                    .HasColumnName("mora90")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Moramas365)
                    .HasColumnName("moramas365")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.MraCapit)
                    .HasColumnName("mra_capit")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.MraInts)
                    .HasColumnName("mra_ints")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.MraSeguro)
                    .HasColumnName("mra_seguro")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.NivelE)
                    .IsRequired()
                    .HasColumnName("nivel_e")
                    .HasDefaultValueSql("'1'::text");

                entity.Property(e => e.NombreMetodologia)
                    .IsRequired()
                    .HasColumnName("nombre_metodologia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NombreMoneda)
                    .IsRequired()
                    .HasColumnName("nombre_moneda")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Numcatcnbs)
                    .IsRequired()
                    .HasColumnName("numcatcnbs")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Numcatcnbsg)
                    .IsRequired()
                    .HasColumnName("numcatcnbsg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Oficial)
                    .HasColumnName("oficial")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.PlanRet)
                    .IsRequired()
                    .HasColumnName("plan_ret")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo")
                    .HasDefaultValueSql("'  '::text");

                entity.Property(e => e.Prestamo)
                    .IsRequired()
                    .HasColumnName("prestamo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.PrestamoRenegocia)
                    .IsRequired()
                    .HasColumnName("prestamo_renegocia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.PrimaSeg1)
                    .HasColumnName("prima_seg1")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.PrimaSeg2)
                    .HasColumnName("prima_seg2")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Programa)
                    .IsRequired()
                    .HasColumnName("programa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ProxPgo)
                    .IsRequired()
                    .HasColumnName("prox_pgo");

                entity.Property(e => e.ProxSegu)
                    .IsRequired()
                    .HasColumnName("prox_segu");

                entity.Property(e => e.ProyCap5anio)
                    .HasColumnName("proy_cap5anio")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes0)
                    .HasColumnName("proy_capmes0")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes1)
                    .HasColumnName("proy_capmes1")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes10)
                    .HasColumnName("proy_capmes10")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes11)
                    .HasColumnName("proy_capmes11")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes12)
                    .HasColumnName("proy_capmes12")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes2)
                    .HasColumnName("proy_capmes2")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes3)
                    .HasColumnName("proy_capmes3")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes4)
                    .HasColumnName("proy_capmes4")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes5)
                    .HasColumnName("proy_capmes5")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes6)
                    .HasColumnName("proy_capmes6")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes7)
                    .HasColumnName("proy_capmes7")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes8)
                    .HasColumnName("proy_capmes8")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyCapmes9)
                    .HasColumnName("proy_capmes9")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyInt5anio)
                    .HasColumnName("proy_int5anio")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes0)
                    .HasColumnName("proy_intmes0")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes1)
                    .HasColumnName("proy_intmes1")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes10)
                    .HasColumnName("proy_intmes10")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes11)
                    .HasColumnName("proy_intmes11")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes12)
                    .HasColumnName("proy_intmes12")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes2)
                    .HasColumnName("proy_intmes2")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes3)
                    .HasColumnName("proy_intmes3")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes4)
                    .HasColumnName("proy_intmes4")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes5)
                    .HasColumnName("proy_intmes5")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes6)
                    .HasColumnName("proy_intmes6")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes7)
                    .HasColumnName("proy_intmes7")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes8)
                    .HasColumnName("proy_intmes8")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyIntmes9)
                    .HasColumnName("proy_intmes9")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyMcap5anio)
                    .HasColumnName("proy_mcap5anio")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyMcapmes12)
                    .HasColumnName("proy_mcapmes12")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyMint5anio)
                    .HasColumnName("proy_mint5anio")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.ProyMintmes12)
                    .HasColumnName("proy_mintmes12")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro120)
                    .HasColumnName("proycobro120")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro180)
                    .HasColumnName("proycobro180")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro30)
                    .HasColumnName("proycobro30")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro365)
                    .HasColumnName("proycobro365")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro60)
                    .HasColumnName("proycobro60")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobro90)
                    .HasColumnName("proycobro90")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Proycobromas365)
                    .HasColumnName("proycobromas365")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Rangog)
                    .IsRequired()
                    .HasColumnName("rangog")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Recoplan)
                    .HasColumnName("recoplan")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.Reserva)
                    .HasColumnName("reserva")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.RptaCnbs)
                    .HasColumnName("rpta_cnbs")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SaldoAct)
                    .HasColumnName("saldo_act")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.SaldoActant)
                    .HasColumnName("saldo_actant")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.SaldoSeg)
                    .HasColumnName("saldo_seg")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.SaldoSg1)
                    .HasColumnName("saldo_sg1")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.SaldoSg2)
                    .HasColumnName("saldo_sg2")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.SeguPda)
                    .IsRequired()
                    .HasColumnName("segu_pda")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Seguro1)
                    .HasColumnName("seguro1")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Seguro2)
                    .HasColumnName("seguro2")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.SiglaMoneda)
                    .IsRequired()
                    .HasColumnName("sigla_moneda")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SldVarios)
                    .HasColumnName("sld_varios")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.Solicitud)
                    .IsRequired()
                    .HasColumnName("solicitud")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Subcatcnbs)
                    .IsRequired()
                    .HasColumnName("subcatcnbs")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SubcatcnbsPrevia)
                    .IsRequired()
                    .HasColumnName("subcatcnbs_previa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Subcatcnbsg)
                    .IsRequired()
                    .HasColumnName("subcatcnbsg")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasColumnName("sucursal")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Tasa)
                    .HasColumnName("tasa")
                    .HasColumnType("numeric(9,6)");

                entity.Property(e => e.TasaAnterior)
                    .HasColumnName("tasa_anterior")
                    .HasColumnType("numeric(9,6)");

                entity.Property(e => e.TasaMora)
                    .HasColumnName("tasa_mora")
                    .HasColumnType("numeric(8,6)");

                entity.Property(e => e.Tieneaval)
                    .IsRequired()
                    .HasColumnName("tieneaval")
                    .HasDefaultValueSql("''::text");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Tipodegracia)
                    .IsRequired()
                    .HasColumnName("tipodegracia")
                    .HasDefaultValueSql("'0'::text");

                entity.Property(e => e.Tipopmo)
                    .HasColumnName("tipopmo")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.TotSeg1)
                    .HasColumnName("tot_seg1")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.TotSeg2)
                    .HasColumnName("tot_seg2")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.Tpcartera)
                    .HasColumnName("tpcartera")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Tpcredito)
                    .HasColumnName("tpcredito")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpgarantia)
                    .IsRequired()
                    .HasColumnName("tpgarantia")
                    .HasDefaultValueSql("'99'::text");

                entity.Property(e => e.Tpobligacion)
                    .HasColumnName("tpobligacion")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpoperacion)
                    .IsRequired()
                    .HasColumnName("tpoperacion")
                    .HasDefaultValueSql("'080000'::text");

                entity.Property(e => e.TprenegociaDias)
                    .HasColumnName("tprenegocia_dias")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Tprenegociacion)
                    .IsRequired()
                    .HasColumnName("tprenegociacion")
                    .HasDefaultValueSql("'Z'::text");

                entity.Property(e => e.Vlcuota)
                    .HasColumnName("vlcuota")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlcuotaAnterior)
                    .HasColumnName("vlcuota_anterior")
                    .HasColumnType("numeric(13,2)");

                entity.Property(e => e.VlcuotaReal)
                    .HasColumnName("vlcuota_real")
                    .HasColumnType("numeric(13,2)");
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.CodSolicitud)
                    .HasName("solicitud_pkey");

                entity.ToTable("solicitud");

                entity.Property(e => e.CodSolicitud)
                    .HasColumnName("cod_solicitud")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.AbonoPrev)
                    .HasColumnName("abono_prev")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.Acta)
                    .IsRequired()
                    .HasColumnName("acta")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.ActualizaDatosclie)
                    .HasColumnName("actualiza_datosclie")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActualizaDatosneg)
                    .HasColumnName("actualiza_datosneg")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActualizaDireccion)
                    .HasColumnName("actualiza_direccion")
                    .HasColumnType("numeric(1,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Anio)
                    .HasColumnName("anio")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.AprobadoPor)
                    .IsRequired()
                    .HasColumnName("aprobado_por")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.Arrestado)
                    .HasColumnName("arrestado")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.ArrestadoRazon)
                    .IsRequired()
                    .HasColumnName("arrestado_razon")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval1)
                    .IsRequired()
                    .HasColumnName("aval1")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval1Tpgarantia)
                    .IsRequired()
                    .HasColumnName("aval1_tpgarantia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval1Tpobligacion)
                    .IsRequired()
                    .HasColumnName("aval1_tpobligacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval2)
                    .IsRequired()
                    .HasColumnName("aval2")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval2Tpgarantia)
                    .IsRequired()
                    .HasColumnName("aval2_tpgarantia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval2Tpobligacion)
                    .IsRequired()
                    .HasColumnName("aval2_tpobligacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval3)
                    .IsRequired()
                    .HasColumnName("aval3")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval3Tpgarantia)
                    .IsRequired()
                    .HasColumnName("aval3_tpgarantia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval3Tpobligacion)
                    .IsRequired()
                    .HasColumnName("aval3_tpobligacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Aval4).HasColumnName("aval4");

                entity.Property(e => e.Aval4Tpgarantia).HasColumnName("aval4_tpgarantia");

                entity.Property(e => e.Aval4Tpobligacion).HasColumnName("aval4_tpobligacion");

                entity.Property(e => e.Aval5).HasColumnName("aval5");

                entity.Property(e => e.Aval5Tpgarantia).HasColumnName("aval5_tpgarantia");

                entity.Property(e => e.Aval5Tpobligacion).HasColumnName("aval5_tpobligacion");

                entity.Property(e => e.Carnetimprema)
                    .IsRequired()
                    .HasColumnName("carnetimprema")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Cobertura1)
                    .HasColumnName("cobertura1")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Cobertura2)
                    .HasColumnName("cobertura2")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Cobertura3)
                    .HasColumnName("cobertura3")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Cobertura4)
                    .HasColumnName("cobertura4")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.Cobertura5)
                    .HasColumnName("cobertura5")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.CodAct)
                    .HasColumnName("cod_act")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.CodEstado)
                    .HasColumnName("cod_estado")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.CodResultPrecal)
                    .HasColumnName("cod_result_precal")
                    .HasColumnType("numeric(5,0)");

                entity.Property(e => e.Codubi)
                    .IsRequired()
                    .HasColumnName("codubi")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.CreditoRazon)
                    .IsRequired()
                    .HasColumnName("credito_razon")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Dictamen).HasColumnName("dictamen");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.EstadoSolic).HasColumnName("estado_solic");

                entity.Property(e => e.FchAprobado)
                    .HasColumnName("fch_aprobado")
                    .HasColumnType("date");

                entity.Property(e => e.FchCreado)
                    .HasColumnName("fch_creado")
                    .HasColumnType("date");

                entity.Property(e => e.FchSldo)
                    .HasColumnName("fch_sldo")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.FchVencimiento)
                    .HasColumnName("fch_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDictamen)
                    .HasColumnName("fecha_dictamen")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnName("fecha_solicitud")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Fondo)
                    .IsRequired()
                    .HasColumnName("fondo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Formapgo)
                    .HasColumnName("formapgo")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Frec)
                    .HasColumnName("frec")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.IntProme)
                    .HasColumnName("int_prome")
                    .HasColumnType("numeric(9,2)");

                entity.Property(e => e.MalCredito)
                    .HasColumnName("mal_credito")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Manutencion)
                    .HasColumnName("manutencion")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Moneda)
                    .HasColumnName("moneda")
                    .HasColumnType("numeric(4,0)");

                entity.Property(e => e.MontoAprobado)
                    .HasColumnName("monto_aprobado")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.MontoOriginal)
                    .HasColumnName("monto_original")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.MontoSolicitado)
                    .HasColumnName("monto_solicitado")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.NivelE)
                    .IsRequired()
                    .HasColumnName("nivel_e")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.NivelManejo)
                    .HasColumnName("nivel_manejo")
                    .HasColumnType("numeric(10,0)");

                entity.Property(e => e.NuevaAportacion)
                    .HasColumnName("nueva_aportacion")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.NumCuotas)
                    .HasColumnName("num_cuotas")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Oficial)
                    .HasColumnName("oficial")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Oficial2)
                    .HasColumnName("oficial2")
                    .HasColumnType("numeric(3,0)");

                entity.Property(e => e.Operador)
                    .HasColumnName("operador")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("origen")
                    .HasDefaultValueSql("'SAF'::text");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasColumnName("placa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.PlanRet)
                    .IsRequired()
                    .HasColumnName("plan_ret")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Prestamo)
                    .IsRequired()
                    .HasColumnName("prestamo")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.PrestamoRenegocia)
                    .HasColumnName("prestamo_renegocia")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Programa)
                    .IsRequired()
                    .HasColumnName("programa")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Quiebra)
                    .HasColumnName("quiebra")
                    .HasColumnType("numeric(1,0)");

                entity.Property(e => e.QuiebraFch)
                    .HasColumnName("quiebra_fch")
                    .HasColumnType("date");

                entity.Property(e => e.QuiebraRazon)
                    .IsRequired()
                    .HasColumnName("quiebra_razon")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.RazonManu)
                    .IsRequired()
                    .HasColumnName("razon_manu")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.SaldoAport)
                    .HasColumnName("saldo_aport")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.SueldoMensual)
                    .HasColumnName("sueldo_mensual")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.SueldoNeto)
                    .HasColumnName("sueldo_neto")
                    .HasColumnType("numeric(11,2)");

                entity.Property(e => e.Sueldoaval1)
                    .HasColumnName("sueldoaval1")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Sueldoaval2)
                    .HasColumnName("sueldoaval2")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Sueldoaval3)
                    .HasColumnName("sueldoaval3")
                    .HasColumnType("numeric(18,2)");

                entity.Property(e => e.Sueldoaval4)
                    .HasColumnName("sueldoaval4")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Sueldoaval5)
                    .HasColumnName("sueldoaval5")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Tasa)
                    .HasColumnName("tasa")
                    .HasColumnType("numeric(9,6)");

                entity.Property(e => e.Tipos)
                    .HasColumnName("tipos")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Tpaval1)
                    .HasColumnName("tpaval1")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpaval2)
                    .HasColumnName("tpaval2")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpaval3)
                    .HasColumnName("tpaval3")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpaval4)
                    .HasColumnName("tpaval4")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpaval5)
                    .HasColumnName("tpaval5")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tpcredito)
                    .HasColumnName("tpcredito")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.Tpoperacion)
                    .IsRequired()
                    .HasColumnName("tpoperacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.TprenegociaDias)
                    .HasColumnName("tprenegocia_dias")
                    .HasColumnType("numeric(2,0)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tprenegociacion)
                    .IsRequired()
                    .HasColumnName("tprenegociacion")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.Vlcuota)
                    .HasColumnName("vlcuota")
                    .HasColumnType("numeric(11,2)");
            });

            modelBuilder.Entity<Tardeuda>(entity =>
            {
                entity.HasKey(e => e.Idtardeuda)
                    .HasName("tardeuda_pkey");

                entity.ToTable("tardeuda");

                entity.Property(e => e.Idtardeuda)
                    .HasColumnName("idtardeuda")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Categoriariesgo).HasColumnName("categoriariesgo");

                entity.Property(e => e.Coberturatarjeta).HasColumnName("coberturatarjeta");

                entity.Property(e => e.Codigoestado).HasColumnName("codigoestado");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.Diasatraso).HasColumnName("diasatraso");

                entity.Property(e => e.Factorcambio).HasColumnName("factorcambio");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.Fechaapertura).HasColumnName("fechaapertura");

                entity.Property(e => e.Fechacancelacion).HasColumnName("fechacancelacion");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechamora).HasColumnName("fechamora");

                entity.Property(e => e.Limitetarjeta).HasColumnName("limitetarjeta");

                entity.Property(e => e.Monedalimite).HasColumnName("monedalimite");

                entity.Property(e => e.Monedamora).HasColumnName("monedamora");

                entity.Property(e => e.Monedapago).HasColumnName("monedapago");

                entity.Property(e => e.Monedasaldo).HasColumnName("monedasaldo");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.PagoMini).HasColumnName("pago_mini");

                entity.Property(e => e.Pagominimo).HasColumnName("pagominimo");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Saldocastigado).HasColumnName("saldocastigado");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");

                entity.Property(e => e.Saldototal).HasColumnName("saldototal");

                entity.Property(e => e.Saldovencido).HasColumnName("saldovencido");

                entity.Property(e => e.Tipotarjeta).HasColumnName("tipotarjeta");
            });

            modelBuilder.Entity<Tardeudaanterior>(entity =>
            {
                entity.HasKey(e => e.Idtardeudaanterior)
                    .HasName("tardeudaanterior_pkey");

                entity.ToTable("tardeudaanterior");

                entity.Property(e => e.Idtardeudaanterior)
                    .HasColumnName("idtardeudaanterior")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Coberturatarjeta).HasColumnName("coberturatarjeta");

                entity.Property(e => e.Codigoestado).HasColumnName("codigoestado");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.Factorcambio).HasColumnName("factorcambio");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.Fechaapertura).HasColumnName("fechaapertura");

                entity.Property(e => e.Fechacancelacion).HasColumnName("fechacancelacion");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechamora).HasColumnName("fechamora");

                entity.Property(e => e.Limitetarjeta).HasColumnName("limitetarjeta");

                entity.Property(e => e.Monedalimite).HasColumnName("monedalimite");

                entity.Property(e => e.Monedamora).HasColumnName("monedamora");

                entity.Property(e => e.Monedapago).HasColumnName("monedapago");

                entity.Property(e => e.Monedasaldo).HasColumnName("monedasaldo");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.Pagominimo).HasColumnName("pagominimo");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Saldomora)
                    .HasColumnName("saldomora")
                    .HasColumnType("numeric");

                entity.Property(e => e.Saldototal).HasColumnName("saldototal");

                entity.Property(e => e.Tipotarjeta).HasColumnName("tipotarjeta");
            });

            modelBuilder.Entity<Tardeudaextrafinanciamiento>(entity =>
            {
                entity.HasKey(e => e.Idtardeudaextrafinanciamiento)
                    .HasName("tardeudaextrafinanciamiento_pkey");

                entity.ToTable("tardeudaextrafinanciamiento");

                entity.Property(e => e.Idtardeudaextrafinanciamiento)
                    .HasColumnName("idtardeudaextrafinanciamiento")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CateDefi).HasColumnName("cate_defi");

                entity.Property(e => e.CateIndi).HasColumnName("cate_indi");

                entity.Property(e => e.CntaOrig).HasColumnName("cnta_orig");

                entity.Property(e => e.Coberturatarjeta).HasColumnName("coberturatarjeta");

                entity.Property(e => e.CodiEsta).HasColumnName("codi_esta");

                entity.Property(e => e.CodiSucu).HasColumnName("codi_sucu");

                entity.Property(e => e.Codigofuente).HasColumnName("codigofuente");

                entity.Property(e => e.ContMord).HasColumnName("cont_mord");

                entity.Property(e => e.ContMorl).HasColumnName("cont_morl");

                entity.Property(e => e.ContSobd).HasColumnName("cont_sobd");

                entity.Property(e => e.ContSobl).HasColumnName("cont_sobl");

                entity.Property(e => e.CostAnua).HasColumnName("cost_anua");

                entity.Property(e => e.CredEspe).HasColumnName("cred_espe");

                entity.Property(e => e.CredGrup).HasColumnName("cred_grup");

                entity.Property(e => e.CredReng).HasColumnName("cred_reng");

                entity.Property(e => e.DestCred).HasColumnName("dest_cred");

                entity.Property(e => e.Diasatraso).HasColumnName("diasatraso");

                entity.Property(e => e.EstaOrig).HasColumnName("esta_orig");

                entity.Property(e => e.FactCamb).HasColumnName("fact_camb");

                entity.Property(e => e.FechCanc).HasColumnName("fech_canc");

                entity.Property(e => e.FechEsta).HasColumnName("fech_esta");

                entity.Property(e => e.FechMora).HasColumnName("fech_mora");

                entity.Property(e => e.FechOtot).HasColumnName("fech_otot");

                entity.Property(e => e.FechUlpa).HasColumnName("fech_ulpa");

                entity.Property(e => e.Fechainformacion).HasColumnName("fechainformacion");

                entity.Property(e => e.Fechaotorgamiento).HasColumnName("fechaotorgamiento");

                entity.Property(e => e.Fechavencimiento).HasColumnName("fechavencimiento");

                entity.Property(e => e.FormPaca).HasColumnName("form_paca");

                entity.Property(e => e.LimiOtot).HasColumnName("limi_otot");

                entity.Property(e => e.MoneMont).HasColumnName("mone_mont");

                entity.Property(e => e.MoneMora).HasColumnName("mone_mora");

                entity.Property(e => e.MonePago).HasColumnName("mone_pago");

                entity.Property(e => e.MoneSald).HasColumnName("mone_sald");

                entity.Property(e => e.MontProv).HasColumnName("mont_prov");

                entity.Property(e => e.Montootorgado).HasColumnName("montootorgado");

                entity.Property(e => e.NiveMora).HasColumnName("nive_mora");

                entity.Property(e => e.NumeAdic).HasColumnName("nume_adic");

                entity.Property(e => e.Numerocandidato).HasColumnName("numerocandidato");

                entity.Property(e => e.Numerocuotas).HasColumnName("numerocuotas");

                entity.Property(e => e.OrigFond).HasColumnName("orig_fond");

                entity.Property(e => e.Pagominimo).HasColumnName("pagominimo");

                entity.Property(e => e.PeriGrac).HasColumnName("peri_grac");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.PlazExtr).HasColumnName("plaz_extr");

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Reserva).HasColumnName("reserva");

                entity.Property(e => e.SaldCmor).HasColumnName("sald_cmor");

                entity.Property(e => e.SaldComi).HasColumnName("sald_comi");

                entity.Property(e => e.SaldCont).HasColumnName("sald_cont");

                entity.Property(e => e.SaldInxc).HasColumnName("sald_inxc");

                entity.Property(e => e.SaldIsus).HasColumnName("sald_isus");

                entity.Property(e => e.Saldomora).HasColumnName("saldomora");

                entity.Property(e => e.Saldototal).HasColumnName("saldototal");

                entity.Property(e => e.TasaBiginte).HasColumnName("tasa_biginte");

                entity.Property(e => e.TasaInmo).HasColumnName("tasa_inmo");

                entity.Property(e => e.TipoCreo).HasColumnName("tipo_creo");

                entity.Property(e => e.TipoGara).HasColumnName("tipo_gara");

                entity.Property(e => e.TipoOper).HasColumnName("tipo_oper");

                entity.Property(e => e.Tipotarjeta).HasColumnName("tipotarjeta");

                entity.Property(e => e.UbicGeog).HasColumnName("ubic_geog");

                entity.Property(e => e.ValoGara).HasColumnName("valo_gara");
            });

            modelBuilder.Entity<Tardeudahistorica>(entity =>
            {
                entity.HasKey(e => e.Idtardeudahistorica)
                    .HasName("tardeudahistorica_pkey");

                entity.ToTable("tardeudahistorica");

                entity.Property(e => e.Idtardeudahistorica)
                    .HasColumnName("idtardeudahistorica")
                    .HasIdentityOptions(null, null, null, 999999999L, null, null);

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.CodiFnte).HasColumnName("codi_fnte");

                entity.Property(e => e.FechOtor).HasColumnName("fech_otor");

                entity.Property(e => e.NumeLine).HasColumnName("nume_line");

                entity.Property(e => e.NumeRefe).HasColumnName("nume_refe");

                entity.Property(e => e.PeriActu).HasColumnName("peri_actu");

                entity.Property(e => e.PeriLine).HasColumnName("peri_line");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.TipoCred).HasColumnName("tipo_cred");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.ToTable("telefono");

                entity.Property(e => e.Telefonoid)
                    .HasColumnName("telefonoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Candidateinfoid).HasColumnName("candidateinfoid");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Periodoinformacion).HasColumnName("periodoinformacion");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Telefonotransunion>(entity =>
            {
                entity.HasKey(e => e.Telefonoid)
                    .HasName("telefonotransunion_pkey");

                entity.ToTable("telefonotransunion");

                entity.Property(e => e.Telefonoid)
                    .HasColumnName("telefonoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.Texto).HasColumnName("texto");
            });

            modelBuilder.Entity<Tpclientes>(entity =>
            {
                entity.HasKey(e => e.Tpcliente)
                    .HasName("tpclientes_pkey");

                entity.ToTable("tpclientes");

                entity.Property(e => e.Tpcliente)
                    .HasColumnName("tpcliente")
                    .HasColumnType("numeric(2,0)");

                entity.Property(e => e.DescTpcliente)
                    .IsRequired()
                    .HasColumnName("desc_tpcliente")
                    .HasDefaultValueSql("' '::text");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf")
                    .HasDefaultValueSql("'01'::text");

                entity.Property(e => e.EsEmpresa).HasColumnName("es_empresa");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");
            });

            modelBuilder.Entity<Tpgarantias>(entity =>
            {
                entity.HasKey(e => e.Tpgarantia)
                    .HasName("tpgarantias_pkey");

                entity.ToTable("tpgarantias");

                entity.Property(e => e.Tpgarantia).HasColumnName("tpgarantia");

                entity.Property(e => e.DescTpgarantia)
                    .IsRequired()
                    .HasColumnName("desc_tpgarantia");

                entity.Property(e => e.EmpreSaf)
                    .IsRequired()
                    .HasColumnName("empre_saf");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.GrpTpgarantia)
                    .IsRequired()
                    .HasColumnName("grp_tpgarantia");

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasColumnName("prefijo");

                entity.Property(e => e.Ultimaactualizacion)
                    .IsRequired()
                    .HasColumnName("ultimaactualizacion");
            });

            modelBuilder.Entity<Tpoperaciones>(entity =>
            {
                entity.HasKey(e => new { e.Tpoperacion, e.EmpreSaf })
                    .HasName("tpoperaciones_pkey");

                entity.ToTable("tpoperaciones");

                entity.Property(e => e.Tpoperacion).HasColumnName("tpoperacion");

                entity.Property(e => e.EmpreSaf).HasColumnName("empre_saf");

                entity.Property(e => e.DescTpoperacion)
                    .IsRequired()
                    .HasColumnName("desc_tpoperacion");

                entity.Property(e => e.Engrupo)
                    .HasColumnName("engrupo")
                    .HasColumnType("numeric");

                entity.Property(e => e.Esinversion)
                    .HasColumnName("esinversion")
                    .HasColumnType("numeric");

                entity.Property(e => e.FchCreado)
                    .IsRequired()
                    .HasColumnName("fch_creado");

                entity.Property(e => e.Rptautorz)
                    .IsRequired()
                    .HasColumnName("rptautorz");

                entity.Property(e => e.Rptcontrato)
                    .IsRequired()
                    .HasColumnName("rptcontrato");

                entity.Property(e => e.Rptnotaentrega)
                    .IsRequired()
                    .HasColumnName("rptnotaentrega");

                entity.Property(e => e.Rptpagare)
                    .IsRequired()
                    .HasColumnName("rptpagare");

                entity.Property(e => e.Rptslc)
                    .IsRequired()
                    .HasColumnName("rptslc");

                entity.Property(e => e.Rpttraspaso)
                    .IsRequired()
                    .HasColumnName("rpttraspaso");

                entity.Property(e => e.Ultimaactualizacion)
                    .IsRequired()
                    .HasColumnName("ultimaactualizacion");
            });

            modelBuilder.Entity<Transunion>(entity =>
            {
                entity.HasKey(e => e.Idconsulta)
                    .HasName("transunion_pkey");

                entity.ToTable("transunion");

                entity.Property(e => e.Idconsulta)
                    .HasColumnName("idconsulta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantidad)
                    .IsRequired()
                    .HasColumnName("cantidad");

                entity.Property(e => e.Cantidad1)
                    .IsRequired()
                    .HasColumnName("cantidad1");

                entity.Property(e => e.Cantidad2)
                    .IsRequired()
                    .HasColumnName("cantidad2");

                entity.Property(e => e.Cantidad3)
                    .IsRequired()
                    .HasColumnName("cantidad3");

                entity.Property(e => e.Cantidad4)
                    .IsRequired()
                    .HasColumnName("cantidad4");

                entity.Property(e => e.Cantidad6)
                    .IsRequired()
                    .HasColumnName("cantidad6");

                entity.Property(e => e.Cantidad7)
                    .IsRequired()
                    .HasColumnName("cantidad7");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasColumnName("cargo");

                entity.Property(e => e.CargoJuri)
                    .IsRequired()
                    .HasColumnName("cargo_juri");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula");

                entity.Property(e => e.ClasificacionComporta)
                    .IsRequired()
                    .HasColumnName("clasificacion_comporta");

                entity.Property(e => e.ClasificacionComporta1)
                    .IsRequired()
                    .HasColumnName("clasificacion_comporta1");

                entity.Property(e => e.ClasificacionComporta2)
                    .IsRequired()
                    .HasColumnName("clasificacion_comporta2");

                entity.Property(e => e.ClasificacionComporta3)
                    .IsRequired()
                    .HasColumnName("clasificacion_comporta3");

                entity.Property(e => e.CodRepor)
                    .IsRequired()
                    .HasColumnName("cod_repor");

                entity.Property(e => e.Codtel)
                    .IsRequired()
                    .HasColumnName("codtel");

                entity.Property(e => e.Codtel2)
                    .IsRequired()
                    .HasColumnName("codtel2");

                entity.Property(e => e.CuotaComporta)
                    .IsRequired()
                    .HasColumnName("cuota_comporta");

                entity.Property(e => e.CuotaComporta1)
                    .IsRequired()
                    .HasColumnName("cuota_comporta1");

                entity.Property(e => e.CuotaComporta2)
                    .IsRequired()
                    .HasColumnName("cuota_comporta2");

                entity.Property(e => e.CuotaComporta3)
                    .IsRequired()
                    .HasColumnName("cuota_comporta3");

                entity.Property(e => e.Dependientes)
                    .IsRequired()
                    .HasColumnName("dependientes");

                entity.Property(e => e.DireccionConyugue)
                    .IsRequired()
                    .HasColumnName("direccion_conyugue");

                entity.Property(e => e.Divisiongeografica1)
                    .IsRequired()
                    .HasColumnName("divisiongeografica1");

                entity.Property(e => e.Divisiongeografica2)
                    .IsRequired()
                    .HasColumnName("divisiongeografica2");

                entity.Property(e => e.Divisiongeso1Conyugue)
                    .IsRequired()
                    .HasColumnName("divisiongeso1_conyugue");

                entity.Property(e => e.Divisiongeso2Conyugue)
                    .IsRequired()
                    .HasColumnName("divisiongeso2_conyugue");

                entity.Property(e => e.Edad)
                    .IsRequired()
                    .HasColumnName("edad");

                entity.Property(e => e.Empresarepresen)
                    .IsRequired()
                    .HasColumnName("empresarepresen");

                entity.Property(e => e.Empresarepresentacion)
                    .IsRequired()
                    .HasColumnName("empresarepresentacion");

                entity.Property(e => e.Entidadconsultante)
                    .IsRequired()
                    .HasColumnName("entidadconsultante");

                entity.Property(e => e.Entidadinformante)
                    .IsRequired()
                    .HasColumnName("entidadinformante");

                entity.Property(e => e.Entidadinformante1)
                    .IsRequired()
                    .HasColumnName("entidadinformante1");

                entity.Property(e => e.Entidadinformante2)
                    .IsRequired()
                    .HasColumnName("entidadinformante2");

                entity.Property(e => e.Entidadinformante3)
                    .IsRequired()
                    .HasColumnName("entidadinformante3");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Estado1)
                    .IsRequired()
                    .HasColumnName("estado1");

                entity.Property(e => e.Estado2)
                    .IsRequired()
                    .HasColumnName("estado2");

                entity.Property(e => e.Estado3)
                    .IsRequired()
                    .HasColumnName("estado3");

                entity.Property(e => e.Estado4)
                    .IsRequired()
                    .HasColumnName("estado4");

                entity.Property(e => e.Estado5)
                    .IsRequired()
                    .HasColumnName("estado5");

                entity.Property(e => e.Estado6)
                    .IsRequired()
                    .HasColumnName("estado6");

                entity.Property(e => e.Estado7)
                    .IsRequired()
                    .HasColumnName("estado7");

                entity.Property(e => e.EstadoComporta)
                    .IsRequired()
                    .HasColumnName("estado_comporta");

                entity.Property(e => e.EstadoComporta1)
                    .IsRequired()
                    .HasColumnName("estado_comporta1");

                entity.Property(e => e.EstadoComporta2)
                    .IsRequired()
                    .HasColumnName("estado_comporta2");

                entity.Property(e => e.EstadoComporta3)
                    .IsRequired()
                    .HasColumnName("estado_comporta3");

                entity.Property(e => e.EstadocivConyugue)
                    .IsRequired()
                    .HasColumnName("estadociv_conyugue");

                entity.Property(e => e.EstadocivfchConyugue)
                    .IsRequired()
                    .HasColumnName("estadocivfch_conyugue");

                entity.Property(e => e.Estadocivil)
                    .IsRequired()
                    .HasColumnName("estadocivil");

                entity.Property(e => e.FchactualizacionObliga)
                    .IsRequired()
                    .HasColumnName("fchactualizacion_obliga");

                entity.Property(e => e.FchactualizacionObliga1)
                    .IsRequired()
                    .HasColumnName("fchactualizacion_obliga1");

                entity.Property(e => e.FchactualizacionObliga2)
                    .IsRequired()
                    .HasColumnName("fchactualizacion_obliga2");

                entity.Property(e => e.FchactualizacionObliga3)
                    .IsRequired()
                    .HasColumnName("fchactualizacion_obliga3");

                entity.Property(e => e.FchapertuaObliga)
                    .IsRequired()
                    .HasColumnName("fchapertua_obliga");

                entity.Property(e => e.FchapertuaObliga1)
                    .IsRequired()
                    .HasColumnName("fchapertua_obliga1");

                entity.Property(e => e.FchapertuaObliga2)
                    .IsRequired()
                    .HasColumnName("fchapertua_obliga2");

                entity.Property(e => e.FchapertuaObliga3)
                    .IsRequired()
                    .HasColumnName("fchapertua_obliga3");

                entity.Property(e => e.Fchinscripcion)
                    .IsRequired()
                    .HasColumnName("fchinscripcion");

                entity.Property(e => e.Fchinscripcion1)
                    .IsRequired()
                    .HasColumnName("fchinscripcion1");

                entity.Property(e => e.Fchnacimiento)
                    .IsRequired()
                    .HasColumnName("fchnacimiento");

                entity.Property(e => e.Fchreporte)
                    .IsRequired()
                    .HasColumnName("fchreporte");

                entity.Property(e => e.FchvencObliga)
                    .IsRequired()
                    .HasColumnName("fchvenc_obliga");

                entity.Property(e => e.FchvencObliga1)
                    .IsRequired()
                    .HasColumnName("fchvenc_obliga1");

                entity.Property(e => e.FchvencObliga2)
                    .IsRequired()
                    .HasColumnName("fchvenc_obliga2");

                entity.Property(e => e.FchvencObliga3)
                    .IsRequired()
                    .HasColumnName("fchvenc_obliga3");

                entity.Property(e => e.GarantiaObliga)
                    .IsRequired()
                    .HasColumnName("garantia_obliga");

                entity.Property(e => e.GarantiaObliga1)
                    .IsRequired()
                    .HasColumnName("garantia_obliga1");

                entity.Property(e => e.GarantiaObliga2)
                    .IsRequired()
                    .HasColumnName("garantia_obliga2");

                entity.Property(e => e.GarantiaObliga3)
                    .IsRequired()
                    .HasColumnName("garantia_obliga3");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero");

                entity.Property(e => e.IdenCodConyugue)
                    .IsRequired()
                    .HasColumnName("iden_cod_conyugue");

                entity.Property(e => e.IdenConyugue)
                    .IsRequired()
                    .HasColumnName("iden_conyugue");

                entity.Property(e => e.IdenteJuri)
                    .IsRequired()
                    .HasColumnName("idente_juri");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasColumnName("identificacion");

                entity.Property(e => e.Idsujeto)
                    .IsRequired()
                    .HasColumnName("idsujeto");

                entity.Property(e => e.IdsujetoJuri)
                    .IsRequired()
                    .HasColumnName("idsujeto_juri");

                entity.Property(e => e.LimiteComporta)
                    .IsRequired()
                    .HasColumnName("limite_comporta");

                entity.Property(e => e.LimiteComporta1)
                    .IsRequired()
                    .HasColumnName("limite_comporta1");

                entity.Property(e => e.LimiteComporta2)
                    .IsRequired()
                    .HasColumnName("limite_comporta2");

                entity.Property(e => e.LimiteComporta3)
                    .IsRequired()
                    .HasColumnName("limite_comporta3");

                entity.Property(e => e.Moneda1)
                    .IsRequired()
                    .HasColumnName("moneda1");

                entity.Property(e => e.Moneda2)
                    .IsRequired()
                    .HasColumnName("moneda2");

                entity.Property(e => e.MonedaComporta)
                    .IsRequired()
                    .HasColumnName("moneda_comporta");

                entity.Property(e => e.MonedaComporta1)
                    .IsRequired()
                    .HasColumnName("moneda_comporta1");

                entity.Property(e => e.MonedaComporta2)
                    .IsRequired()
                    .HasColumnName("moneda_comporta2");

                entity.Property(e => e.MonedaComporta3)
                    .IsRequired()
                    .HasColumnName("moneda_comporta3");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo");

                entity.Property(e => e.NombreConyugue)
                    .IsRequired()
                    .HasColumnName("nombre_conyugue");

                entity.Property(e => e.Nombrecompleto)
                    .IsRequired()
                    .HasColumnName("nombrecompleto");

                entity.Property(e => e.NumeroObliga)
                    .IsRequired()
                    .HasColumnName("numero_obliga");

                entity.Property(e => e.NumeroObliga1)
                    .IsRequired()
                    .HasColumnName("numero_obliga1");

                entity.Property(e => e.NumeroObliga2)
                    .IsRequired()
                    .HasColumnName("numero_obliga2");

                entity.Property(e => e.NumeroObliga3)
                    .IsRequired()
                    .HasColumnName("numero_obliga3");

                entity.Property(e => e.Obligacion)
                    .IsRequired()
                    .HasColumnName("obligacion");

                entity.Property(e => e.Obligacion1)
                    .IsRequired()
                    .HasColumnName("obligacion1");

                entity.Property(e => e.Obligacion2)
                    .IsRequired()
                    .HasColumnName("obligacion2");

                entity.Property(e => e.Obligacion3)
                    .IsRequired()
                    .HasColumnName("obligacion3");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("pais");

                entity.Property(e => e.PeriodoPagoObliga)
                    .IsRequired()
                    .HasColumnName("periodo_pago_obliga");

                entity.Property(e => e.PeriodoPagoObliga1)
                    .IsRequired()
                    .HasColumnName("periodo_pago_obliga1");

                entity.Property(e => e.PeriodoPagoObliga2)
                    .IsRequired()
                    .HasColumnName("periodo_pago_obliga2");

                entity.Property(e => e.PeriodoPagoObliga3)
                    .IsRequired()
                    .HasColumnName("periodo_pago_obliga3");

                entity.Property(e => e.Primerapellido)
                    .IsRequired()
                    .HasColumnName("primerapellido");

                entity.Property(e => e.Primernombre)
                    .IsRequired()
                    .HasColumnName("primernombre");

                entity.Property(e => e.SaldoactualComporta)
                    .IsRequired()
                    .HasColumnName("saldoactual_comporta");

                entity.Property(e => e.SaldoactualComporta1)
                    .IsRequired()
                    .HasColumnName("saldoactual_comporta1");

                entity.Property(e => e.SaldoactualComporta2)
                    .IsRequired()
                    .HasColumnName("saldoactual_comporta2");

                entity.Property(e => e.SaldoactualComporta3)
                    .IsRequired()
                    .HasColumnName("saldoactual_comporta3");

                entity.Property(e => e.SaldomoraComporta)
                    .IsRequired()
                    .HasColumnName("saldomora_comporta");

                entity.Property(e => e.SaldomoraComporta1)
                    .IsRequired()
                    .HasColumnName("saldomora_comporta1");

                entity.Property(e => e.SaldomoraComporta2)
                    .IsRequired()
                    .HasColumnName("saldomora_comporta2");

                entity.Property(e => e.SaldomoraComporta3)
                    .IsRequired()
                    .HasColumnName("saldomora_comporta3");

                entity.Property(e => e.Segundoapellido)
                    .IsRequired()
                    .HasColumnName("segundoapellido");

                entity.Property(e => e.Segundonombre)
                    .IsRequired()
                    .HasColumnName("segundonombre");

                entity.Property(e => e.TelCodConyugue)
                    .IsRequired()
                    .HasColumnName("tel_cod_conyugue");

                entity.Property(e => e.TelConyugue)
                    .IsRequired()
                    .HasColumnName("tel_conyugue");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono");

                entity.Property(e => e.Telefono2)
                    .IsRequired()
                    .HasColumnName("telefono2");

                entity.Property(e => e.TipoObliga)
                    .IsRequired()
                    .HasColumnName("tipo_obliga");

                entity.Property(e => e.TipoObliga1)
                    .IsRequired()
                    .HasColumnName("tipo_obliga1");

                entity.Property(e => e.TipoObliga2)
                    .IsRequired()
                    .HasColumnName("tipo_obliga2");

                entity.Property(e => e.TipoObliga3)
                    .IsRequired()
                    .HasColumnName("tipo_obliga3");

                entity.Property(e => e.Tipocuenta)
                    .IsRequired()
                    .HasColumnName("tipocuenta");

                entity.Property(e => e.Tipocuenta1)
                    .IsRequired()
                    .HasColumnName("tipocuenta1");

                entity.Property(e => e.Tipocuenta2)
                    .IsRequired()
                    .HasColumnName("tipocuenta2");

                entity.Property(e => e.Tipocuenta3)
                    .IsRequired()
                    .HasColumnName("tipocuenta3");

                entity.Property(e => e.Tipocuenta4)
                    .IsRequired()
                    .HasColumnName("tipocuenta4");

                entity.Property(e => e.Tipocuenta5)
                    .IsRequired()
                    .HasColumnName("tipocuenta5");

                entity.Property(e => e.Tipocuenta6)
                    .IsRequired()
                    .HasColumnName("tipocuenta6");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario");

                entity.Property(e => e.Vectorhisto1Anio)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio");

                entity.Property(e => e.Vectorhisto1Anio1)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio1");

                entity.Property(e => e.Vectorhisto1Anio10)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio10");

                entity.Property(e => e.Vectorhisto1Anio11)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio11");

                entity.Property(e => e.Vectorhisto1Anio12)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio12");

                entity.Property(e => e.Vectorhisto1Anio13)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio13");

                entity.Property(e => e.Vectorhisto1Anio14)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio14");

                entity.Property(e => e.Vectorhisto1Anio15)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio15");

                entity.Property(e => e.Vectorhisto1Anio16)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio16");

                entity.Property(e => e.Vectorhisto1Anio17)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio17");

                entity.Property(e => e.Vectorhisto1Anio18)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio18");

                entity.Property(e => e.Vectorhisto1Anio19)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio19");

                entity.Property(e => e.Vectorhisto1Anio2)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio2");

                entity.Property(e => e.Vectorhisto1Anio20)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio20");

                entity.Property(e => e.Vectorhisto1Anio21)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio21");

                entity.Property(e => e.Vectorhisto1Anio22)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio22");

                entity.Property(e => e.Vectorhisto1Anio23)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio23");

                entity.Property(e => e.Vectorhisto1Anio24)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio24");

                entity.Property(e => e.Vectorhisto1Anio3)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio3");

                entity.Property(e => e.Vectorhisto1Anio4)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio4");

                entity.Property(e => e.Vectorhisto1Anio5)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio5");

                entity.Property(e => e.Vectorhisto1Anio6)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio6");

                entity.Property(e => e.Vectorhisto1Anio7)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio7");

                entity.Property(e => e.Vectorhisto1Anio8)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio8");

                entity.Property(e => e.Vectorhisto1Anio9)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_anio9");

                entity.Property(e => e.Vectorhisto1Mes1)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes1");

                entity.Property(e => e.Vectorhisto1Mes10)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes10");

                entity.Property(e => e.Vectorhisto1Mes11)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes11");

                entity.Property(e => e.Vectorhisto1Mes12)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes12");

                entity.Property(e => e.Vectorhisto1Mes13)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes13");

                entity.Property(e => e.Vectorhisto1Mes14)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes14");

                entity.Property(e => e.Vectorhisto1Mes15)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes15");

                entity.Property(e => e.Vectorhisto1Mes16)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes16");

                entity.Property(e => e.Vectorhisto1Mes17)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes17");

                entity.Property(e => e.Vectorhisto1Mes18)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes18");

                entity.Property(e => e.Vectorhisto1Mes19)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes19");

                entity.Property(e => e.Vectorhisto1Mes2)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes2");

                entity.Property(e => e.Vectorhisto1Mes20)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes20");

                entity.Property(e => e.Vectorhisto1Mes21)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes21");

                entity.Property(e => e.Vectorhisto1Mes22)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes22");

                entity.Property(e => e.Vectorhisto1Mes23)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes23");

                entity.Property(e => e.Vectorhisto1Mes24)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes24");

                entity.Property(e => e.Vectorhisto1Mes3)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes3");

                entity.Property(e => e.Vectorhisto1Mes4)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes4");

                entity.Property(e => e.Vectorhisto1Mes5)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes5");

                entity.Property(e => e.Vectorhisto1Mes6)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes6");

                entity.Property(e => e.Vectorhisto1Mes7)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes7");

                entity.Property(e => e.Vectorhisto1Mes8)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes8");

                entity.Property(e => e.Vectorhisto1Mes9)
                    .IsRequired()
                    .HasColumnName("vectorhisto1_mes9");

                entity.Property(e => e.Vectorhisto2Anio)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio");

                entity.Property(e => e.Vectorhisto2Anio1)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio1");

                entity.Property(e => e.Vectorhisto2Anio10)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio10");

                entity.Property(e => e.Vectorhisto2Anio11)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio11");

                entity.Property(e => e.Vectorhisto2Anio12)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio12");

                entity.Property(e => e.Vectorhisto2Anio13)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio13");

                entity.Property(e => e.Vectorhisto2Anio14)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio14");

                entity.Property(e => e.Vectorhisto2Anio15)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio15");

                entity.Property(e => e.Vectorhisto2Anio16)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio16");

                entity.Property(e => e.Vectorhisto2Anio17)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio17");

                entity.Property(e => e.Vectorhisto2Anio18)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio18");

                entity.Property(e => e.Vectorhisto2Anio19)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio19");

                entity.Property(e => e.Vectorhisto2Anio2)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio2");

                entity.Property(e => e.Vectorhisto2Anio20)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio20");

                entity.Property(e => e.Vectorhisto2Anio21)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio21");

                entity.Property(e => e.Vectorhisto2Anio22)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio22");

                entity.Property(e => e.Vectorhisto2Anio23)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio23");

                entity.Property(e => e.Vectorhisto2Anio24)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio24");

                entity.Property(e => e.Vectorhisto2Anio3)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio3");

                entity.Property(e => e.Vectorhisto2Anio4)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio4");

                entity.Property(e => e.Vectorhisto2Anio5)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio5");

                entity.Property(e => e.Vectorhisto2Anio6)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio6");

                entity.Property(e => e.Vectorhisto2Anio7)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio7");

                entity.Property(e => e.Vectorhisto2Anio8)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio8");

                entity.Property(e => e.Vectorhisto2Anio9)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_anio9");

                entity.Property(e => e.Vectorhisto2Mes1)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes1");

                entity.Property(e => e.Vectorhisto2Mes10)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes10");

                entity.Property(e => e.Vectorhisto2Mes11)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes11");

                entity.Property(e => e.Vectorhisto2Mes12)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes12");

                entity.Property(e => e.Vectorhisto2Mes13)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes13");

                entity.Property(e => e.Vectorhisto2Mes14)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes14");

                entity.Property(e => e.Vectorhisto2Mes15)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes15");

                entity.Property(e => e.Vectorhisto2Mes16)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes16");

                entity.Property(e => e.Vectorhisto2Mes17)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes17");

                entity.Property(e => e.Vectorhisto2Mes18)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes18");

                entity.Property(e => e.Vectorhisto2Mes19)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes19");

                entity.Property(e => e.Vectorhisto2Mes2)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes2");

                entity.Property(e => e.Vectorhisto2Mes20)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes20");

                entity.Property(e => e.Vectorhisto2Mes21)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes21");

                entity.Property(e => e.Vectorhisto2Mes22)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes22");

                entity.Property(e => e.Vectorhisto2Mes23)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes23");

                entity.Property(e => e.Vectorhisto2Mes24)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes24");

                entity.Property(e => e.Vectorhisto2Mes3)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes3");

                entity.Property(e => e.Vectorhisto2Mes4)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes4");

                entity.Property(e => e.Vectorhisto2Mes5)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes5");

                entity.Property(e => e.Vectorhisto2Mes6)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes6");

                entity.Property(e => e.Vectorhisto2Mes7)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes7");

                entity.Property(e => e.Vectorhisto2Mes8)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes8");

                entity.Property(e => e.Vectorhisto2Mes9)
                    .IsRequired()
                    .HasColumnName("vectorhisto2_mes9");

                entity.Property(e => e.Vectorhisto3Anio)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio");

                entity.Property(e => e.Vectorhisto3Anio1)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio1");

                entity.Property(e => e.Vectorhisto3Anio10)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio10");

                entity.Property(e => e.Vectorhisto3Anio11)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio11");

                entity.Property(e => e.Vectorhisto3Anio12)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio12");

                entity.Property(e => e.Vectorhisto3Anio13)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio13");

                entity.Property(e => e.Vectorhisto3Anio14)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio14");

                entity.Property(e => e.Vectorhisto3Anio15)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio15");

                entity.Property(e => e.Vectorhisto3Anio16)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio16");

                entity.Property(e => e.Vectorhisto3Anio17)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio17");

                entity.Property(e => e.Vectorhisto3Anio18)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio18");

                entity.Property(e => e.Vectorhisto3Anio19)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio19");

                entity.Property(e => e.Vectorhisto3Anio2)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio2");

                entity.Property(e => e.Vectorhisto3Anio20)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio20");

                entity.Property(e => e.Vectorhisto3Anio21)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio21");

                entity.Property(e => e.Vectorhisto3Anio22)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio22");

                entity.Property(e => e.Vectorhisto3Anio23)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio23");

                entity.Property(e => e.Vectorhisto3Anio24)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio24");

                entity.Property(e => e.Vectorhisto3Anio3)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio3");

                entity.Property(e => e.Vectorhisto3Anio4)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio4");

                entity.Property(e => e.Vectorhisto3Anio5)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio5");

                entity.Property(e => e.Vectorhisto3Anio6)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio6");

                entity.Property(e => e.Vectorhisto3Anio7)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio7");

                entity.Property(e => e.Vectorhisto3Anio8)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio8");

                entity.Property(e => e.Vectorhisto3Anio9)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_anio9");

                entity.Property(e => e.Vectorhisto3Mes1)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes1");

                entity.Property(e => e.Vectorhisto3Mes10)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes10");

                entity.Property(e => e.Vectorhisto3Mes11)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes11");

                entity.Property(e => e.Vectorhisto3Mes12)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes12");

                entity.Property(e => e.Vectorhisto3Mes13)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes13");

                entity.Property(e => e.Vectorhisto3Mes14)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes14");

                entity.Property(e => e.Vectorhisto3Mes15)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes15");

                entity.Property(e => e.Vectorhisto3Mes16)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes16");

                entity.Property(e => e.Vectorhisto3Mes17)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes17");

                entity.Property(e => e.Vectorhisto3Mes18)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes18");

                entity.Property(e => e.Vectorhisto3Mes19)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes19");

                entity.Property(e => e.Vectorhisto3Mes2)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes2");

                entity.Property(e => e.Vectorhisto3Mes20)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes20");

                entity.Property(e => e.Vectorhisto3Mes21)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes21");

                entity.Property(e => e.Vectorhisto3Mes22)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes22");

                entity.Property(e => e.Vectorhisto3Mes23)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes23");

                entity.Property(e => e.Vectorhisto3Mes24)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes24");

                entity.Property(e => e.Vectorhisto3Mes3)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes3");

                entity.Property(e => e.Vectorhisto3Mes4)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes4");

                entity.Property(e => e.Vectorhisto3Mes5)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes5");

                entity.Property(e => e.Vectorhisto3Mes6)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes6");

                entity.Property(e => e.Vectorhisto3Mes7)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes7");

                entity.Property(e => e.Vectorhisto3Mes8)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes8");

                entity.Property(e => e.Vectorhisto3Mes9)
                    .IsRequired()
                    .HasColumnName("vectorhisto3_mes9");

                entity.Property(e => e.VectorhistoAnio)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio");

                entity.Property(e => e.VectorhistoAnio1)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio1");

                entity.Property(e => e.VectorhistoAnio10)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio10");

                entity.Property(e => e.VectorhistoAnio11)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio11");

                entity.Property(e => e.VectorhistoAnio12)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio12");

                entity.Property(e => e.VectorhistoAnio13)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio13");

                entity.Property(e => e.VectorhistoAnio14)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio14");

                entity.Property(e => e.VectorhistoAnio15)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio15");

                entity.Property(e => e.VectorhistoAnio16)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio16");

                entity.Property(e => e.VectorhistoAnio17)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio17");

                entity.Property(e => e.VectorhistoAnio18)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio18");

                entity.Property(e => e.VectorhistoAnio19)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio19");

                entity.Property(e => e.VectorhistoAnio2)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio2");

                entity.Property(e => e.VectorhistoAnio20)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio20");

                entity.Property(e => e.VectorhistoAnio21)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio21");

                entity.Property(e => e.VectorhistoAnio22)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio22");

                entity.Property(e => e.VectorhistoAnio23)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio23");

                entity.Property(e => e.VectorhistoAnio24)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio24");

                entity.Property(e => e.VectorhistoAnio3)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio3");

                entity.Property(e => e.VectorhistoAnio4)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio4");

                entity.Property(e => e.VectorhistoAnio5)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio5");

                entity.Property(e => e.VectorhistoAnio6)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio6");

                entity.Property(e => e.VectorhistoAnio7)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio7");

                entity.Property(e => e.VectorhistoAnio8)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio8");

                entity.Property(e => e.VectorhistoAnio9)
                    .IsRequired()
                    .HasColumnName("vectorhisto_anio9");

                entity.Property(e => e.VectorhistoMes)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes");

                entity.Property(e => e.VectorhistoMes1)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes1");

                entity.Property(e => e.VectorhistoMes10)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes10");

                entity.Property(e => e.VectorhistoMes11)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes11");

                entity.Property(e => e.VectorhistoMes12)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes12");

                entity.Property(e => e.VectorhistoMes13)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes13");

                entity.Property(e => e.VectorhistoMes14)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes14");

                entity.Property(e => e.VectorhistoMes15)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes15");

                entity.Property(e => e.VectorhistoMes16)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes16");

                entity.Property(e => e.VectorhistoMes17)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes17");

                entity.Property(e => e.VectorhistoMes18)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes18");

                entity.Property(e => e.VectorhistoMes19)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes19");

                entity.Property(e => e.VectorhistoMes2)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes2");

                entity.Property(e => e.VectorhistoMes20)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes20");

                entity.Property(e => e.VectorhistoMes21)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes21");

                entity.Property(e => e.VectorhistoMes22)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes22");

                entity.Property(e => e.VectorhistoMes23)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes23");

                entity.Property(e => e.VectorhistoMes24)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes24");

                entity.Property(e => e.VectorhistoMes3)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes3");

                entity.Property(e => e.VectorhistoMes4)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes4");

                entity.Property(e => e.VectorhistoMes5)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes5");

                entity.Property(e => e.VectorhistoMes6)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes6");

                entity.Property(e => e.VectorhistoMes7)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes7");

                entity.Property(e => e.VectorhistoMes8)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes8");

                entity.Property(e => e.VectorhistoMes9)
                    .IsRequired()
                    .HasColumnName("vectorhisto_mes9");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("Usuario_pkey");

                entity.ToTable("usuarios");

                entity.Property(e => e.Idusuario)
                    .HasColumnName("idusuario")
                    .HasIdentityOptions(146L, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codagencia).HasColumnName("codagencia");

                entity.Property(e => e.Codasesor).HasColumnName("codasesor");

                entity.Property(e => e.Contrasena).HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Fchcreado)
                    .IsRequired()
                    .HasColumnName("fchcreado")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Fchvenpass)
                    .IsRequired()
                    .HasColumnName("fchvenpass");

                entity.Property(e => e.Fchvenusu)
                    .IsRequired()
                    .HasColumnName("fchvenusu");

                entity.Property(e => e.Nivelusuario).HasColumnName("nivelusuario");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.SessionActiva).HasColumnName("session_activa");

                entity.Property(e => e.Tipousuario).HasColumnName("tipousuario");

                entity.Property(e => e.Usu)
                    .IsRequired()
                    .HasColumnName("usu");
            });

            modelBuilder.Entity<VContar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_contar");

                entity.Property(e => e.Contar).HasColumnName("contar");
            });

            modelBuilder.Entity<Validsession>(entity =>
            {
                entity.ToTable("validsession");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Agencia).HasColumnName("agencia");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("fecha");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasColumnName("modulo");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Vectorhistorico>(entity =>
            {
                entity.ToTable("vectorhistorico");

                entity.Property(e => e.Vectorhistoricoid)
                    .HasColumnName("vectorhistoricoid")
                    .HasIdentityOptions(null, null, null, 99999L, null, null)
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Identificadorsujetoid).HasColumnName("identificadorsujetoid");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Mora).HasColumnName("mora");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
