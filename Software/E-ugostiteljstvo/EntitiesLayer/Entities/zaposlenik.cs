namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("zaposlenik")]
    public partial class zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zaposlenik()
        {
            namirnica_u_katalogu = new HashSet<namirnica_u_katalogu>();
            narudzbenica = new HashSet<narudzbenica>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ime { get; set; }

        [Required]
        [StringLength(50)]
        public string prezime { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string lozinka { get; set; }

        
        

        public byte[] slika { get; set; }

        public int uloga_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<namirnica_u_katalogu> namirnica_u_katalogu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzbenica> narudzbenica { get; set; }

        public virtual uloga uloga { get; set; }
    }
}
