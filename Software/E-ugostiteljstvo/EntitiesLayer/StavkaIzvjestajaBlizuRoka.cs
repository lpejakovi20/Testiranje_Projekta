using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    ///<author>Nikola Parag</author>
    public class StavkaIzvjestajaBlizuRoka
    {
        public int id { get; set; }
        public string naziv { get; set; }

        public int kolicina { get; set; }

        public DateTime rok { get; set; }
    }
}
