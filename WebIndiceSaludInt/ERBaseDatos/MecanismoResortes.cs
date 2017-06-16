namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MecanismoResortes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string alineacion_resortes { get; set; }

        [StringLength(250)]
        public string observaciones_alin_resortes { get; set; }

        [StringLength(2)]
        public string amortiguadores { get; set; }

        [StringLength(250)]
        public string observaciones_amortiguadores { get; set; }

        [StringLength(2)]
        public string motor { get; set; }

        [StringLength(250)]
        public string observaciones_motor { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
