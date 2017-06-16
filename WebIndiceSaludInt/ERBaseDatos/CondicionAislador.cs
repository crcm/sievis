namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CondicionAislador")]
    public partial class CondicionAislador
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string corrosión { get; set; }

        [StringLength(250)]
        public string observaciones_corrosion { get; set; }

        [StringLength(2)]
        public string roturas { get; set; }

        [StringLength(250)]
        public string observaciones_roturas { get; set; }

        [StringLength(2)]
        public string grietas { get; set; }

        [StringLength(250)]
        public string observaciones_grietas { get; set; }

        [StringLength(2)]
        public string flameo { get; set; }

        [StringLength(250)]
        public string observaciones_flameo { get; set; }

        [StringLength(2)]
        public string danio_cementado { get; set; }

        [StringLength(250)]
        public string observaciones_cementado { get; set; }

        [StringLength(2)]
        public string danio_piezasfijacion { get; set; }

        [StringLength(250)]
        public string observaciones_piezasfijacion { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
