namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("uloga")]
    public partial class uloga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uloga()
        {
            zaposlenik = new HashSet<zaposlenik>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(40)]
        public string naziv { get; set; }

        [StringLength(255)]
        public string opis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposlenik> zaposlenik { get; set; }
    }
}
