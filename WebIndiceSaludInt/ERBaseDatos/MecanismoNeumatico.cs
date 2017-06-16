namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MecanismoNeumatico")]
    public partial class MecanismoNeumatico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string presion_aire { get; set; }

        [StringLength(250)]
        public string observaciones_presionaire { get; set; }

        [StringLength(2)]
        public string fuga_aire { get; set; }

        [StringLength(250)]
        public string observaciones_fugaaire { get; set; }

        [StringLength(2)]
        public string valvulas { get; set; }

        [StringLength(250)]
        public string observaciones_valvulas { get; set; }

        [StringLength(2)]
        public string corrosion_mecanismo { get; set; }

        [StringLength(250)]
        public string observaciones_corrmecan { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
