using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    ///<author>Lovro Pejaković</author>
    public class StavkaIskoristenostNamirnice
    {
        public int Namirnica_u_katalogu_id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public int Iskoristeno { get; set; }
        public string Mjerna_jedinica { get; set; }
    }
}
