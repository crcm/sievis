namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prueba")]
    public partial class Prueba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prueba()
        {
            Archivo = new HashSet<Archivo>();
            Inspeccion_visual = new HashSet<Inspeccion_visual>();
            PruebaRutina = new HashSet<PruebaRutina>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int Equipo_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int Equipo_Gerencia_id { get; set; }

        public int Equipo_Mecanismo_id { get; set; }

        public int Equipo_Subestacion_id { get; set; }

        public int Equipo_Marca_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Archivo> Archivo { get; set; }

        public virtual Equipo Equipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspeccion_visual> Inspeccion_visual { get; set; }

        public virtual PruebaEspecial PruebaEspecial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PruebaRutina> PruebaRutina { get; set; }
    }
}
