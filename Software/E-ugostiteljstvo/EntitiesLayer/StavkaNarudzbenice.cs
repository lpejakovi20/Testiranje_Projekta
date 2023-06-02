using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    ///<author>Matej Ritoša</author>
    public class StavkaNarudzbenice
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public int Kolicina { get; set; }
        public string MjernaJedinica { get; set; }

        public decimal Cijena { get; set; }
        public decimal Iznos { get; set; }


    }
}
