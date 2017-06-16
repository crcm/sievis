namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AnalisisGas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public bool? fuga { get; set; }

        public DateTime? tiempo_rellenado { get; set; }

        [StringLength(1)]
        public string fase { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? humedad { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sf6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cf4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? aire { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presion { get; set; }

        public int Prueba_id { get; set; }
    }
}
