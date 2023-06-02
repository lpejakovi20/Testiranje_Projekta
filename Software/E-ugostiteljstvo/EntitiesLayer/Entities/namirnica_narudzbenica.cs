namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class namirnica_narudzbenica
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int namirnica_u_katalogu_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int narudzbenica_id { get; set; }

        public int kolicina { get; set; }

        public virtual namirnica_u_katalogu namirnica_u_katalogu { get; set; }

        public virtual narudzbenica narudzbenica { get; set; }
    }
}