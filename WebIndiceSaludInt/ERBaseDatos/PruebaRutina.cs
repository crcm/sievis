namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PruebaRutina")]
    public partial class PruebaRutina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int Prueba_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ibobina_disparo1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ibobina_disparo2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ibobina_cierre { get; set; }

        public int? tapertura_fasead1 { get; set; }

        public int? tapertura_fasebd1 { get; set; }

        public int? tapertura_fasecd1 { get; set; }

        public int? tapertura_fasead2 { get; set; }

        public int? tapertura_fasebd2 { get; set; }

        public int? tapertura_fasecd2 { get; set; }

        public int? tcierre_fasea { get; set; }

        public int? tcierre_faseb { get; set; }

        public int? tcierre_fasec { get; set; }

        [StringLength(2)]
        public string pantibombeo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? imotor_ienergizacion { get; set; }

        public int? imotor_tcarga { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fultimo_mantenimiento { get; set; }

        public int? num_operfallas { get; set; }

        [StringLength(1)]
        public string disponibilidad { get; set; }

        public int? altitud_instalacion { get; set; }

        [StringLength(1)]
        public string nivel_contaminacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_1cfasea { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_1cfaseb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_1cfasec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfasea_c1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfasea_c2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfaseb_c1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfaseb_c2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfasec_c1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rec_2cfasec_c2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? resitencia_preinsercion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? capacitancia_capacitor { get; set; }

        public virtual Prueba Prueba { get; set; }
    }
}
