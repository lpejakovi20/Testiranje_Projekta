using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;

namespace DataAccessLayer.Repositories
{
    ///<author>Matej Ritoša</author>
    public class ZaposlenikRepository : Repository<zaposlenik> , IZaposlenikRepository {
        public ZaposlenikRepository() : base(new DBModel())
        {
        }

        public zaposlenik GetZaposlenikByEmail(string phrase)
        {
            var query = (from p in Entities.Include("uloga")
                        where p.email.Contains(phrase)
                        select p).FirstOrDefault<zaposlenik>();

            return query;
        }

        public zaposlenik GetZaposlenikById(int id)
        {
            var query = (from p in Entities.Include("uloga")
                         where p.id == id
                         select p).FirstOrDefault<zaposlenik>();

            return query;
        }

        public zaposlenik GetZaposlenikZaNarudzbenicu(int zaposlenikId)
        {
            var query = (from p in Entities
                         where p.id == zaposlenikId
                         select p).FirstOrDefault<zaposlenik>();

            return query;
        }

        public override int Update(zaposlenik entity, bool saveChanges = true)
        {
            var zaposlenik = Entities.SingleOrDefault(c => c.id == entity.id);

           

            if(zaposlenik != null) {
                zaposlenik.ime = entity.ime;
                zaposlenik.prezime = entity.prezime;
                zaposlenik.lozinka = entity.lozinka;
                zaposlenik.email = entity.email;
            }

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Add(zaposlenik entity, bool saveChanges = true)
        {
            var uloga = Context.uloga.SingleOrDefault(c => c.id == entity.uloga.id);
            var _zaposlenik = new zaposlenik();
            _zaposlenik.email = entity.email;
            _zaposlenik.lozinka = entity.lozinka;
            _zaposlenik.ime = entity.ime;
            _zaposlenik.prezime = entity.prezime;
            _zaposlenik.uloga = uloga;
            _zaposlenik.slika = entity.slika;

            Entities.Add(_zaposlenik);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }

        }
    }
}
