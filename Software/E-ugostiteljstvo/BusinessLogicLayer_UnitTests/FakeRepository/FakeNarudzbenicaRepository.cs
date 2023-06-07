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
