namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Inspeccion_visual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspeccion_visual()
        {
            CondicionAislador = new HashSet<CondicionAislador>();
            CondicionGabineteControl = new HashSet<CondicionGabineteControl>();
            CondicionOtrosComponentes = new HashSet<CondicionOtrosComponentes>();
            CondicionVarillaje = new HashSet<CondicionVarillaje>();
            Densimetro = new HashSet<Densimetro>();
            MecanismoHidraulico = new HashSet<MecanismoHidraulico>();
            MecanismoNeumatico = new HashSet<MecanismoNeumatico>();
            MecanismoResortes = new HashSet<MecanismoResortes>();
            Presostato = new HashSet<Presostato>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int Prueba_id { get; set; }

        public int AplicacionInterruptor_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_inspeccion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_puestaservicio { get; set; }

        [StringLength(1)]
        public string fase { get; set; }

        public int? num_operaciones { get; set; }

        [StringLength(2)]
        public string existe_gabinete { get; set; }

        public virtual AplicacionInterruptor AplicacionInterruptor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicionAislador> CondicionAislador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicionGabineteControl> CondicionGabineteControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicionOtrosComponentes> CondicionOtrosComponentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicionVarillaje> CondicionVarillaje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Densimetro> Densimetro { get; set; }

        public virtual Prueba Prueba { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MecanismoHidraulico> MecanismoHidraulico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MecanismoNeumatico> MecanismoNeumatico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MecanismoResortes> MecanismoResortes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presostato> Presostato { get; set; }
    }
}
