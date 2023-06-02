using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    ///<author>Lovro Pejaković</author>
    public static class StavkaIzdatniceRepository
    {
        public static List<StavkaIzdatnice> lista;
        
        public static List<StavkaIzdatnice> GetList()
        {
            return lista;
        }

        public static void AddToList(StavkaIzdatnice stavka)
        {
            lista.Add(stavka);
        }
    }
}
