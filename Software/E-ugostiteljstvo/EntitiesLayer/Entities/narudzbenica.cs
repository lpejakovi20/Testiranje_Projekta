namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("narudzbenica")]
    public partial class narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public narudzbenica()
        {
            namirnica_narudzbenica = new HashSet<namirnica_narudzbenica>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime datum_kreiranja { get; set; }

        public decimal sveukupan_iznos { get; set; }

        public int broj_stavki { get; set; }

        public int? zaposlenik_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<namirnica_narudzbenica> namirnica_narudzbenica { get; set; }

        public virtual zaposlenik zaposlenik { get; set; }
    }
}