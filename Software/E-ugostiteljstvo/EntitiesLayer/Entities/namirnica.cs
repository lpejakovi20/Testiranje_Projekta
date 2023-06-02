namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("namirnica")]
    public partial class namirnica
    {
        public int id { get; set; }

        
        [Column(TypeName = "date")]
        public DateTime rok { get; set; }

        public int kolicina { get; set; }

        public int namirnica_u_katalogu_id { get; set; }

        public virtual namirnica_u_katalogu namirnica_u_katalogu { get; set; }
    }
}
