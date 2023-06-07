using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository {
    public class FakeUlogaRepository : IUlogaRepository {
        public IQueryable<uloga> GetAll() {
            List<uloga> lista = new List<uloga>();

            var nova = new uloga {
               id = 1,
               naziv = "Kuhinja",
               opis = null
            };

            lista.Add(nova);

            IQueryable<uloga> query = lista.AsQueryable();

            return query;
        }
    }
}
