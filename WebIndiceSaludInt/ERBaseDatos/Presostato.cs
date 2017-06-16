namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Presostato")]
    public partial class Presostato
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string carcasa { get; set; }

        [StringLength(250)]
        public string observaciones_carcasa { get; set; }

        [StringLength(2)]
        public string caratula { get; set; }

        [StringLength(250)]
        public string observaciones_caratula { get; set; }

        [StringLength(2)]
        public string escala { get; set; }

        [StringLength(250)]
        public string observaciones_escala { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presionSF6_va { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presionSF6_vn { get; set; }

        [StringLength(250)]
        public string observaciones_presionSF6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? temperatura_va { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? temperatura_vn { get; set; }

        [StringLength(250)]
        public string observaciones_temperatura { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
