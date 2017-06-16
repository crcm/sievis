namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Archivo")]
    public partial class Archivo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int Prueba_id { get; set; }

        public DateTime? fecha { get; set; }

        [Column(TypeName = "image")]
        public byte[] archivo_soporte { get; set; }

        public virtual Prueba Prueba { get; set; }
    }
}
