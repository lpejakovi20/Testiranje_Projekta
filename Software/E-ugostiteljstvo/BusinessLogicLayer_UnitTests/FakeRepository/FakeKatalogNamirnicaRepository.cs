using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository
{
    public class FakeKatalogNamirnicaRepository : IKatalogNamirnicaRepository
    {
        public int Add(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }

        public IQueryable<namirnica_u_katalogu> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<namirnica_u_katalogu> GetFiltered(string selecteditem)
        {
            if(selecteditem == null) { return null; }
            List<namirnica_u_katalogu> lista = new List<namirnica_u_katalogu>()
            {
                new namirnica_u_katalogu(){id=333,naziv="Patka",vrsta="Meso",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12},
                new namirnica_u_katalogu(){id=333,naziv="Guska",vrsta="Meso",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12},
                new namirnica_u_katalogu(){id=333,naziv="Paprika",vrsta="Povrće",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12}
            };
            IQueryable<namirnica_u_katalogu> query = lista.AsQueryable().Take(3);
            return query;
        }

        public namirnica_u_katalogu GetKatalogNamirnicaById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase)
        {
            var list = new List<namirnica_u_katalogu>();
            if(phrase == null)
            {
                IQueryable<namirnica_u_katalogu> queryPrazan = list.AsQueryable();
                return queryPrazan;
            }
            var novaNamirnica = new namirnica_u_katalogu() { id = 1, naziv = "Ananas", cijena = 12, vrsta = "Voće", mjerna_jedinica = "kom", minimalne_zalihe = 4, optimalne_zalihe = 5, rok_uporabe = 12 };
            list.Add(novaNamirnica);
            IQueryable<namirnica_u_katalogu> query = list.AsQueryable();
            return query;
        }

        public int Update(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }
    }
}
