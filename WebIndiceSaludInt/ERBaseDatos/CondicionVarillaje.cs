namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CondicionVarillaje")]
    public partial class CondicionVarillaje
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string alineacion { get; set; }

        [StringLength(250)]
        public string observaciones_alineacion { get; set; }

        [StringLength(2)]
        public string lubricacion { get; set; }

        [StringLength(250)]
        public string observaciones_lubricacion { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
