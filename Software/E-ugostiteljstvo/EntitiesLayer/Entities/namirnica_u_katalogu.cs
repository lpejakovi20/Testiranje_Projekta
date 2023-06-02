namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class namirnica_u_katalogu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public namirnica_u_katalogu()
        {
            iskoristenost_namirnice = new HashSet<iskoristenost_namirnice>();
            namirnica = new HashSet<namirnica>();
            namirnica_narudzbenica = new HashSet<namirnica_narudzbenica>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string naziv { get; set; }

        [Required]
        [StringLength(30)]
        public string vrsta { get; set; }

        [Required]
        [StringLength(20)]
        public string mjerna_jedinica { get; set; }

        public decimal cijena { get; set; }

        public int minimalne_zalihe { get; set; }

        public int optimalne_zalihe { get; set; }

        public int? zaposlenik_id { get; set; }

        public int rok_uporabe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<iskoristenost_namirnice> iskoristenost_namirnice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<namirnica> namirnica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<namirnica_narudzbenica> namirnica_narudzbenica { get; set; }

        public virtual zaposlenik zaposlenik { get; set; }
    }
}