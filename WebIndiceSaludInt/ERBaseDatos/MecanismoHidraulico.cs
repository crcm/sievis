namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MecanismoHidraulico")]
    public partial class MecanismoHidraulico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(2)]
        public string fuga_aceite { get; set; }

        [StringLength(250)]
        public string observaciones_fugaa { get; set; }

        [StringLength(2)]
        public string acumulador { get; set; }

        [StringLength(250)]
        public string observaciones_acumulador { get; set; }

        [StringLength(2)]
        public string presion_aceite { get; set; }

        [StringLength(250)]
        public string observaciones_presiona { get; set; }

        [StringLength(2)]
        public string unidad_control { get; set; }

        [StringLength(250)]
        public string observaciones_uctrl { get; set; }

        [StringLength(2)]
        public string valvulas { get; set; }

        [StringLength(250)]
        public string observaciones_valvulas { get; set; }

        [StringLength(2)]
        public string trecarga_acumulador { get; set; }

        [StringLength(250)]
        public string observaciones_trecargaa { get; set; }

        [StringLength(2)]
        public string burbujas_reservorio { get; set; }

        [StringLength(250)]
        public string observaciones_burbujasr { get; set; }

        [StringLength(2)]
        public string fugas_nitrogeno { get; set; }

        [StringLength(250)]
        public string observaciones_fugasnitro { get; set; }

        [StringLength(2)]
        public string compresor { get; set; }

        [StringLength(250)]
        public string observaciones_compresor { get; set; }

        public int Inspeccion_visual_id { get; set; }

        public virtual Inspeccion_visual Inspeccion_visual { get; set; }
    }
}
