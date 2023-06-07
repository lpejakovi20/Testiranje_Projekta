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
    public class StavkeNarudzbeniceRepository : Repository<namirnica_narudzbenica> , IStavkeNarudzbeniceRepository
    {
        public StavkeNarudzbeniceRepository() : base(new DBModel())
        {
        }

        public override int Update(namirnica_narudzbenica entity, bool saveChanges = true)
        {
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Add(namirnica_narudzbenica entity, bool saveChanges = true)
        {
            var narudzbenica = Context.narudzbenica.SingleOrDefault(c => c.id == entity.narudzbenica_id);
            var namirnica_u_katalogu = Context.namirnica_u_katalogu.SingleOrDefault(c => c.id == entity.namirnica_u_katalogu_id);
            var _namirnica_narudzbenica = new namirnica_narudzbenica();

            _namirnica_narudzbenica.namirnica_u_katalogu = namirnica_u_katalogu;
            _namirnica_narudzbenica.narudzbenica = narudzbenica;
            _namirnica_narudzbenica.kolicina = entity.kolicina;


            Entities.Add(_namirnica_narudzbenica);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }

        }
        public IQueryable<dynamic> GetStavkeNarudzbenice(int narudzbenicaId)
        {
            var query = from nn in Entities
                        join nk in Context.namirnica_u_katalogu on nn.namirnica_u_katalogu_id equals nk.id
                        join n in Context.narudzbenica on nn.narudzbenica_id equals n.id
                        where nn.narudzbenica_id == narudzbenicaId
                        select new { nk.id, nk.naziv, nk.vrsta, nk.mjerna_jedinica, nk.cijena, nn.kolicina };
            return query;
        }
    }
}
