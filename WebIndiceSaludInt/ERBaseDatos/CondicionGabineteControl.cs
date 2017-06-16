namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CondicionGabineteControl")]
    public partial class CondicionGabineteControl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string humedad { get; set; }

        [StringLength(250)]
        public string observaciones_humedad { get; set; }

        [StringLength(2)]
        public string roturas { get; set; }

        [StringLength(250)]
        public string observaciones_roturas { get; set; }

        [StringLength(2)]
        public string grietas_sello { get; set; }

        [StringLength(250)]
        public string observaciones_grietas { get; set; }

        [StringLength(2)]
        public string insectos { get; set; }

        [StringLength(250)]
        public string observaciones_insectos { get; set; }

        [StringLength(2)]
        public string desprendimiento_pintura { get; set; }

        [StringLength(250)]
        public string observaciones_pintura { get; set; }

        [StringLength(2)]
        public string corrosion_interna { get; set; }

        [StringLength(250)]
        public string observaciones_corrosioninterna { get; set; }

        [StringLength(2)]
        public string corrosion_externa { get; set; }

        [StringLength(250)]
        public string observaciones_corrosionexterna { get; set; }

        [StringLength(2)]
        public string disparo1 { get; set; }

        [StringLength(250)]
        public string observaciones_disparo1 { get; set; }

        [StringLength(2)]
        public string disparo2 { get; set; }

        [StringLength(250)]
        public string observaciones_disparo2 { get; set; }

        [StringLength(2)]
        public string cierre { get; set; }

        [StringLength(250)]
        public string observaciones_cierre { get; set; }

        [StringLength(2)]
        public string resistencia_calefactora { get; set; }

        [StringLength(250)]
        public string observaciones_rcalecfactora { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
