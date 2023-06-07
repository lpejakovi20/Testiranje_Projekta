using DataAccessLayer.Interfaces;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository
{
    public class FakeNarudzbenicaRepository : INarudzbenicaRepository
    {
        public int Add(narudzbenica entity, bool saveChanges = true)
        {
            if(entity == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public IQueryable<narudzbenica> GetAll() {
            List<narudzbenica> lista = new List<narudzbenica>();

            var novaNarudzbenica = new narudzbenica {
                id = 125,
                datum_kreiranja = DateTime.Now.AddDays(3),
                broj_stavki = 10,
                sveukupan_iznos = 1000,
                zaposlenik_id = 5

            };
            var novaNarudzbenica2 = new narudzbenica {
                id = 126,
                datum_kreiranja = DateTime.Now.AddDays(1),
                broj_stavki = 10,
                sveukupan_iznos = 1000,
                zaposlenik_id = 5

            };
            var novaNarudzbenica3 = new narudzbenica {
                id = 127,
                datum_kreiranja = DateTime.Now.AddDays(2),
                broj_stavki = 10,
                sveukupan_iznos = 1000,
                zaposlenik_id = 5

            };

            lista.Add(novaNarudzbenica);
            lista.Add(novaNarudzbenica2);
            lista.Add(novaNarudzbenica3);

            IQueryable<narudzbenica> query = lista.AsQueryable();

            return query;
        }

        public narudzbenica GetNarudzbenicaById(int narudzbenicaId)
{
            if (narudzbenicaId < 1) {
                return null;
            }
           
            var novaNarudzbenica = new narudzbenica {
               id = 125,
               datum_kreiranja = DateTime.Now,
               broj_stavki = 10,
               sveukupan_iznos = 1000,
               zaposlenik_id = 5

            };
            if (novaNarudzbenica.id == narudzbenicaId) {
                return novaNarudzbenica;
            } else return null;
            
        }

        public int Update(narudzbenica entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
