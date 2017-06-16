namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CondicionOtrosComponentes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string aterrizamiento_cdisparo { get; set; }

        [StringLength(250)]
        public string observaciones_aterrizamiento { get; set; }

        [StringLength(2)]
        public string corrosion_tubing { get; set; }

        [StringLength(250)]
        public string observaciones_ctubing { get; set; }

        [StringLength(2)]
        public string corrosion_ctierra { get; set; }

        [StringLength(250)]
        public string observaciones_ctierra { get; set; }

        [StringLength(2)]
        public string ruido_audible { get; set; }

        [StringLength(250)]
        public string observaciones_ruidoaudible { get; set; }

        [StringLength(2)]
        public string vibracion_audible { get; set; }

        [StringLength(250)]
        public string observaciones_vibracionaudible { get; set; }

        [StringLength(2)]
        public string instrumento_medicionSF6 { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
