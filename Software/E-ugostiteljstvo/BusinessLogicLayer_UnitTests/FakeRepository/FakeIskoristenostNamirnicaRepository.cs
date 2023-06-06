using DataAccessLayer.Interfaces;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository
{
    public class FakeIskoristenostNamirnicaRepository : IIskoristenostNamirnicaRepository
    {
        public int Add(iskoristenost_namirnice entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }

        public IQueryable<StavkaIskoristenostNamirnice> GetIskoristeneNamirniceByMonth(int month, int year)
        {
            if(month < 1 || month > 12)
            {
                return null;
            }

            List<StavkaIskoristenostNamirnice> lista = new List<StavkaIskoristenostNamirnice>();

            var nova = new StavkaIskoristenostNamirnice
            {
                Namirnica_u_katalogu_id = 10,
                Naziv = "Namirnica 1",
                Vrsta = "Vrsta 1",
                Iskoristeno = 10,
                Mjerna_jedinica = "kom"
            };

            lista.Add(nova);

            IQueryable<StavkaIskoristenostNamirnice> query = lista.AsQueryable().Take(1);

            return query;
        }

        public int Update(iskoristenost_namirnice entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }
    }
}
