namespace WebIndiceSaludInt
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SaludInterruptoresBD : DbContext
    {
        public SaludInterruptoresBD()
            : base("name=SaludInterruptoresBD")
        {
        }

        public virtual DbSet<AnalisisGas> AnalisisGas { get; set; }
        public virtual DbSet<AplicacionInterruptor> AplicacionInterruptor { get; set; }
        public virtual DbSet<Archivo> Archivo { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CondicionAislador> CondicionAislador { get; set; }
        public virtual DbSet<CondicionGabineteControl> CondicionGabineteControl { get; set; }
        public virtual DbSet<CondicionOtrosComponentes> CondicionOtrosComponentes { get; set; }
        public virtual DbSet<CondicionVarillaje> CondicionVarillaje { get; set; }
        public virtual DbSet<Densimetro> Densimetro { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Gerencia> Gerencia { get; set; }
        public virtual DbSet<Inspeccion_visual> Inspeccion_visual { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Mecanismo> Mecanismo { get; set; }
        public virtual DbSet<MecanismoHidraulico> MecanismoHidraulico { get; set; }
        public virtual DbSet<MecanismoNeumatico> MecanismoNeumatico { get; set; }
        public virtual DbSet<MecanismoResortes> MecanismoResortes { get; set; }
        public virtual DbSet<Presostato> Presostato { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
        public virtual DbSet<PruebaRutina> PruebaRutina { get; set; }
        public virtual DbSet<Subestacion> Subestacion { get; set; }
        public virtual DbSet<PruebaEspecial> PruebaEspecial { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.fase)
                .IsUnicode(false);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.humedad)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.sf6)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.cf4)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.so2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.HF)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.aire)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AnalisisGas>()
                .Property(e => e.presion)
                .HasPrecision(5, 2);

            modelBuilder.Entity<AplicacionInterruptor>()
                .Property(e => e.descripción)
                .IsUnicode(false);

            modelBuilder.Entity<AplicacionInterruptor>()
                .HasMany(e => e.Inspeccion_visual)
                .WithRequired(e => e.AplicacionInterruptor)
                .HasForeignKey(e => e.AplicacionInterruptor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.corrosión)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_corrosion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.roturas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_roturas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.grietas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_grietas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.flameo)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_flameo)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.danio_cementado)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_cementado)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.danio_piezasfijacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionAislador>()
                .Property(e => e.observaciones_piezasfijacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.humedad)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_humedad)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.roturas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_roturas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.grietas_sello)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_grietas)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.insectos)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_insectos)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.desprendimiento_pintura)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_pintura)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.corrosion_interna)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_corrosioninterna)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.corrosion_externa)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_corrosionexterna)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.disparo1)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_disparo1)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.disparo2)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_disparo2)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.cierre)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_cierre)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.resistencia_calefactora)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionGabineteControl>()
                .Property(e => e.observaciones_rcalecfactora)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.aterrizamiento_cdisparo)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.observaciones_aterrizamiento)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.corrosion_tubing)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.observaciones_ctubing)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.corrosion_ctierra)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.observaciones_ctierra)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.ruido_audible)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.observaciones_ruidoaudible)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.vibracion_audible)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.observaciones_vibracionaudible)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionOtrosComponentes>()
                .Property(e => e.instrumento_medicionSF6)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionVarillaje>()
                .Property(e => e.alineacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionVarillaje>()
                .Property(e => e.observaciones_alineacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionVarillaje>()
                .Property(e => e.lubricacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionVarillaje>()
                .Property(e => e.observaciones_lubricacion)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.carcasa)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.observaciones_carcasa)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.caratula)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.observaciones_caratula)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.escala)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.observaciones_escala)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.presionSF6_va)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.presionSF6_vn)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.observaciones_presionSF6)
                .IsUnicode(false);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.temperatura_va)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.temperatura_vn)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Densimetro>()
                .Property(e => e.observaciones_temperatura)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.bahia)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.ns)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.modelo_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.Anio_fabricacion)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.tesion_nominal)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.corriente_nominal)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.corriente_cc)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.bil)
                .HasPrecision(6, 3);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.presionSF6)
                .HasPrecision(6, 3);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.altitudoperacion)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.dis_estructural)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.conf_camaras)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.res_estatica_contactos)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.interruptor_contiene)
                .IsUnicode(false);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.interruptor_resistencia)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Equipo>()
                .Property(e => e.interruptor_capacitor)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Equipo>()
                .HasMany(e => e.Prueba)
                .WithRequired(e => e.Equipo)
                .HasForeignKey(e => new { e.Equipo_id, e.Equipo_Gerencia_id, e.Equipo_Subestacion_id, e.Equipo_Marca_id, e.Equipo_Mecanismo_id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gerencia>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Gerencia>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.Gerencia)
                .HasForeignKey(e => e.Gerencia_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .Property(e => e.fase)
                .IsUnicode(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .Property(e => e.existe_gabinete)
                .IsUnicode(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.CondicionAislador)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.CondicionGabineteControl)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.CondicionOtrosComponentes)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.CondicionVarillaje)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.Densimetro)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.MecanismoHidraulico)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.MecanismoNeumatico)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.MecanismoResortes)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspeccion_visual>()
                .HasMany(e => e.Presostato)
                .WithRequired(e => e.Inspeccion_visual)
                .HasForeignKey(e => e.Inspeccion_visual_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.Marca)
                .HasForeignKey(e => e.Marca_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mecanismo>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Mecanismo>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.Mecanismo)
                .HasForeignKey(e => e.Mecanismo_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.fuga_aceite)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_fugaa)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.acumulador)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_acumulador)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.presion_aceite)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_presiona)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.unidad_control)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_uctrl)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.valvulas)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_valvulas)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.trecarga_acumulador)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_trecargaa)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.burbujas_reservorio)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_burbujasr)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.fugas_nitrogeno)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_fugasnitro)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.compresor)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoHidraulico>()
                .Property(e => e.observaciones_compresor)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.presion_aire)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.observaciones_presionaire)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.fuga_aire)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.observaciones_fugaaire)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.valvulas)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.observaciones_valvulas)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.corrosion_mecanismo)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoNeumatico>()
                .Property(e => e.observaciones_corrmecan)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.alineacion_resortes)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.observaciones_alin_resortes)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.amortiguadores)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.observaciones_amortiguadores)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.motor)
                .IsUnicode(false);

            modelBuilder.Entity<MecanismoResortes>()
                .Property(e => e.observaciones_motor)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.carcasa)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.observaciones_carcasa)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.caratula)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.observaciones_caratula)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.escala)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.observaciones_escala)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.presionSF6_va)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.presionSF6_vn)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.observaciones_presionSF6)
                .IsUnicode(false);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.temperatura_va)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.temperatura_vn)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Presostato>()
                .Property(e => e.observaciones_temperatura)
                .IsUnicode(false);

            modelBuilder.Entity<Prueba>()
                .HasMany(e => e.Archivo)
                .WithRequired(e => e.Prueba)
                .HasForeignKey(e => e.Prueba_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prueba>()
                .HasMany(e => e.Inspeccion_visual)
                .WithRequired(e => e.Prueba)
                .HasForeignKey(e => e.Prueba_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prueba>()
                .HasOptional(e => e.PruebaEspecial)
                .WithRequired(e => e.Prueba);

            modelBuilder.Entity<Prueba>()
                .HasMany(e => e.PruebaRutina)
                .WithRequired(e => e.Prueba)
                .HasForeignKey(e => e.Prueba_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.ibobina_disparo1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.ibobina_disparo2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.ibobina_cierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.pantibombeo)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.imotor_ienergizacion)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.disponibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.nivel_contaminacion)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_1cfasea)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_1cfaseb)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_1cfasec)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfasea_c1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfasea_c2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfaseb_c1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfaseb_c2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfasec_c1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.rec_2cfasec_c2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.resitencia_preinsercion)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaRutina>()
                .Property(e => e.capacitancia_capacitor)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Subestacion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Subestacion>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.Subestacion)
                .HasForeignKey(e => e.Subestacion_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.res_dim_con_fasea)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.res_dim_con_faseb)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.res_dim_con_fasec)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.temp_ambiente)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.tfasea)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ubicacion_tempfasea)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.tfaseb)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ubicacion_tempfaseb)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.tfasec)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ubicacion_tempfasec)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_iba1)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_iba2)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_tba1)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_tba2)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_ibacierre)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.patron_tbacierre)
                .IsUnicode(false);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.parranque_minimo)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.caida_ibobinad1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.caida_ibobinad2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.caida_ibobinacierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.vaperturad1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.vaperturad2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.vcierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ctotal_capertura1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ctotal_capertura2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.ctotal_ccierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.recorrido_capertura1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.recorrido_capertura2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.recorrido_ccierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.penetracion)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.rebote_apertura1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.rebote_apertura2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.rebote_cierre)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.sobrerecorrido_apertura1)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.sobrerecorrido_apertura2)
                .HasPrecision(6, 2);

            modelBuilder.Entity<PruebaEspecial>()
                .Property(e => e.sobrerecorrido_cierre)
                .HasPrecision(6, 2);
        }
    }
}
