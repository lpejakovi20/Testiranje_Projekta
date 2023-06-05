using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    ///<author>Lovro Pejaković</author>
    public class IskoristenostNamirnicaRepository : Repository<iskoristenost_namirnice>
    {
        public IskoristenostNamirnicaRepository() : base(new DBModel())
        {

        }

        public IQueryable<StavkaIskoristenostNamirnice> GetIskoristeneNamirniceByMonth(int month, int year)
        {
            var result = from p in Entities
                         join n in Context.namirnica_u_katalogu on p.namirnica_u_katalogu_id equals n.id into pn
                         from n in pn where p.datum.Month == month && p.datum.Year == year
                         select new StavkaIskoristenostNamirnice
                         {
                             Namirnica_u_katalogu_id = p.namirnica_u_katalogu_id,
                             Naziv = n.naziv,
                             Vrsta = n.vrsta,
                             Iskoristeno = p.iskoristeno,
                             Mjerna_jedinica = n.mjerna_jedinica
                         };

            return result;
        }

        public override int Update(iskoristenost_namirnice entity, bool saveChanges = true)
        {
            var namirnicaKatalog = Context.namirnica_u_katalogu.SingleOrDefault(c => c.id == entity.namirnica_u_katalogu_id);

            var mjesec = entity.datum.Month;
            var godina = entity.datum.Year;

            var namirnica = Entities.SingleOrDefault(p => p.namirnica_u_katalogu_id == entity.namirnica_u_katalogu_id && p.datum.Month == mjesec && p.datum.Year == godina);
            if(namirnica != null)
            {
                namirnica.namirnica_u_katalogu = namirnicaKatalog;
                namirnica.iskoristeno += entity.iskoristeno;
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

        public override int Add(iskoristenost_namirnice entity, bool saveChanges = true)
        {
            var namirnicaKatalog = Context.namirnica_u_katalogu.SingleOrDefault(c => c.id == entity.namirnica_u_katalogu_id);
            var _namirnica = new iskoristenost_namirnice();

            _namirnica.iskoristeno = entity.iskoristeno;
            _namirnica.neiskoristeno = 0;
            _namirnica.datum = entity.datum;
            _namirnica.namirnica_u_katalogu = namirnicaKatalog;

            Entities.Add(_namirnica);
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
