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
    public class FakeNamirnicaRepository : INamirnicaRepository
    {
        public int Add(namirnica entity, bool saveChanges = true)
        {
            if(entity != null)
            {
                return 1;
            }
            else return 0;
        }

        public IQueryable<namirnica> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<StavkaNarudzbenice> GetDostupneKolicineNamirnica()
        {
            throw new NotImplementedException();
        }

        public IQueryable<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka()
        {
            throw new NotImplementedException();
        }

        public IQueryable<namirnica> GetNamirniceByKatalogId(int namirnica_id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<dynamic> GetNamirniceIstecenogRoka()
        {
            List<dynamic> lista = new List<dynamic>();

            var nova = new
            {
                id = 10,
                naziv = "kruška",
                istekao_rok = DateTime.Now,
                vrsta = "voće",
                kolicina = "5",
                mjerna_jedinica = "kom",
                cijena = 10,
                iznos = 50
            };

            lista.Add(nova);

            IQueryable<dynamic> query = lista.AsQueryable().Take(1);

            return query;
        }

        public int Update(namirnica entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }
    }
}
