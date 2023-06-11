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

        public int Delete(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0; ;
        }

        public IQueryable<namirnica_u_katalogu> GetAll()
        {
            List<namirnica_u_katalogu> lista = new List<namirnica_u_katalogu>()
            {
                new namirnica_u_katalogu(){id=333,naziv="Patka",vrsta="Meso",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12},
                new namirnica_u_katalogu(){id=333,naziv="Guska",vrsta="Meso",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12},
                new namirnica_u_katalogu(){id=333,naziv="Paprika",vrsta="Povrće",mjerna_jedinica = "kg",minimalne_zalihe = 4, optimalne_zalihe = 5, cijena = 12, rok_uporabe = 12}
            };
            IQueryable<namirnica_u_katalogu> query = lista.AsQueryable();
            return query;
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
            if (id < 1) {
                return null;
            }
            List<namirnica_u_katalogu> namirniceUKatalogu = new List<namirnica_u_katalogu>();
            var novaNamirnicaKatalog = new namirnica_u_katalogu {
                id = 125,
                naziv = "Mrkva",
                vrsta = "Povrće",
                mjerna_jedinica = "kg",
                cijena = 1,
                minimalne_zalihe = 10,
                optimalne_zalihe = 20,
                zaposlenik_id = 7,
                rok_uporabe = 14

            };
            var novaNamirnicaKatalog2 = new namirnica_u_katalogu {
                id = 126,
                naziv = "Mrkva",
                vrsta = "Povrće",
                mjerna_jedinica = "kg",
                cijena = 1,
                minimalne_zalihe = 10,
                optimalne_zalihe = 20,
                zaposlenik_id = 7,
                rok_uporabe = 14

            };
            namirniceUKatalogu.Add(novaNamirnicaKatalog);
            namirniceUKatalogu.Add(novaNamirnicaKatalog2);

            foreach (var namirnica in namirniceUKatalogu) {
                if (namirnica.id == id) {
                    return namirnica;
                } 
            }
             return null;

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
