namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    ///<author>Lovro Pejakoviæ</author>
    public partial class iskoristenost_namirnice
    {
        public int id { get; set; }

        public int iskoristeno { get; set; }

        public int neiskoristeno { get; set; }

        [Column(TypeName = "date")]
        public DateTime datum { get; set; }

        public int namirnica_u_katalogu_id { get; set; }

        public virtual namirnica_u_katalogu namirnica_u_katalogu { get; set; }
    }
}
