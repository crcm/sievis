namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PruebaEspecial")]
    public partial class PruebaEspecial
    {
        public int? Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Prueba_id { get; set; }

        [StringLength(1)]
        public string res_dim_con_fasea { get; set; }

        [StringLength(1)]
        public string res_dim_con_faseb { get; set; }

        [StringLength(1)]
        public string res_dim_con_fasec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? temp_ambiente { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tfasea { get; set; }

        [StringLength(4)]
        public string ubicacion_tempfasea { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tfaseb { get; set; }

        [StringLength(4)]
        public string ubicacion_tempfaseb { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tfasec { get; set; }

        [StringLength(4)]
        public string ubicacion_tempfasec { get; set; }

        [StringLength(1)]
        public string patron_iba1 { get; set; }

        [StringLength(1)]
        public string patron_iba2 { get; set; }

        [StringLength(1)]
        public string patron_tba1 { get; set; }

        [StringLength(1)]
        public string patron_tba2 { get; set; }

        [StringLength(1)]
        public string patron_ibacierre { get; set; }

        [StringLength(1)]
        public string patron_tbacierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? parranque_minimo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? caida_ibobinad1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? caida_ibobinad2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? caida_ibobinacierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vaperturad1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vaperturad2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vcierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ctotal_capertura1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ctotal_capertura2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ctotal_ccierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? recorrido_capertura1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? recorrido_capertura2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? recorrido_ccierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? penetracion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rebote_apertura1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rebote_apertura2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rebote_cierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sobrerecorrido_apertura1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sobrerecorrido_apertura2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sobrerecorrido_cierre { get; set; }

        public virtual Prueba Prueba { get; set; }
    }
}
