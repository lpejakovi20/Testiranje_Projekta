using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    ///<author>Lovro Pejaković</author>
    public partial class namirnica
    {
        public override string ToString()
        {
            //return rok.ToString();
            return rok.ToShortDateString();
        }
    }
}
