using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    ///<author>Lovro Pejaković</author>
    public class StavkaIzdatnice
    {
        public int Id { get; set; }
        public int Temp_id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public int Kolicina { get; set; }
        public string MjernaJedinica { get; set; }
        public DateTime Rok_trajanja { get; set; }

        public StavkaIzdatnice(int id, string naziv, string vrsta, int kolicina, string mjerna_jedinica, DateTime rok, int temp_id)
        {
            Id = id;
            Temp_id = temp_id;
            Naziv = naziv;
            Vrsta = vrsta;
            Kolicina = kolicina;
            MjernaJedinica = mjerna_jedinica;
            Rok_trajanja = rok;
        }
    }
}
