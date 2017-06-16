namespace WebIndiceSaludInt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipo")]
    public partial class Equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipo()
        {
            Prueba = new HashSet<Prueba>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Gerencia_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Subestacion_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Marca_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mecanismo_id { get; set; }

        [StringLength(5)]
        public string bahia { get; set; }

        [StringLength(20)]
        public string ns { get; set; }

        [StringLength(20)]
        public string modelo_tipo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Anio_fabricacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tesion_nominal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? corriente_nominal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? corriente_cc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bil { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? presionSF6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? altitudoperacion { get; set; }

        [StringLength(2)]
        public string dis_estructural { get; set; }

        [StringLength(1)]
        public string conf_camaras { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? res_estatica_contactos { get; set; }

        [StringLength(1)]
        public string interruptor_contiene { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? interruptor_resistencia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? interruptor_capacitor { get; set; }

        public virtual Gerencia Gerencia { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual Mecanismo Mecanismo { get; set; }

        public virtual Subestacion Subestacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prueba> Prueba { get; set; }
    }
}
