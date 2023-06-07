using DataAccessLayer.Interfaces;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository {
    public class FakeZaposlenikRepository : IZaposlenikRepository {
        public int Add(zaposlenik entity, bool saveChanges = true) {
            if (entity != null) {
                return 1;
            } else return 0;
        }

        public IQueryable<zaposlenik> GetAll() {
            List<zaposlenik> lista = new List<zaposlenik>();

            var nova = new zaposlenik {
                id = 7,
                ime = "test",
                prezime = "test",
                email = "test@mail.com",
                lozinka = "123456",
                slika = null
            };

            lista.Add(nova);

            IQueryable<zaposlenik> query = lista.AsQueryable();

            return query;
        }

        public zaposlenik GetZaposlenikByEmail(string phrase) {
           
            if(phrase == "") {
                return null;
            }

            var noviZaposlenik = new zaposlenik {
                id = 7,
                ime = "test",
                prezime = "test",
                email = "test@mail.com",
                lozinka = "123456",
                slika = null

            };
            if (noviZaposlenik.email == phrase) {
                return noviZaposlenik;
            } else return null;
        }

        public zaposlenik GetZaposlenikById(int id) {
            if (id < 1) {
                return null;
            }

            var noviZaposlenik = new zaposlenik {
                id = 7,
                ime = "test",
                prezime = "test",
                email = "test@mail.com",
                lozinka = "123456",
                slika = null
   
            };
            if (noviZaposlenik.id == id) {
                return noviZaposlenik;
            } else return null;
        }

        public zaposlenik GetZaposlenikZaNarudzbenicu(int zaposlenikId) {
            if (zaposlenikId < 1) {
                return null;
            }

            var noviZaposlenik = new zaposlenik {
                id = 5,
                ime = "test",
                prezime = "test",
                email = "test@mail.com",
                lozinka = "123456",
                slika = null

            };
            if (noviZaposlenik.id == zaposlenikId) {
                return noviZaposlenik;
            } else return null;
        }

        public int Update(zaposlenik entity, bool saveChanges = true) {
            if (entity != null) {
                return 1;
            } else return 0;
        }
    }
}
