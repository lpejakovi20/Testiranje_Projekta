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
    public class NarudzbenicaRepository : Repository<narudzbenica>, INarudzbenicaRepository
    {
        public NarudzbenicaRepository() : base(new DBModel())
        {
        }

        public override int Update(narudzbenica entity, bool saveChanges = true)
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

        public override int Add(narudzbenica entity, bool saveChanges = true)
        {
            var zaposlenik = Context.zaposlenik.SingleOrDefault(c => c.id == entity.zaposlenik_id);
            var _narudzbenica = new narudzbenica();

            _narudzbenica.id = entity.id;
            _narudzbenica.datum_kreiranja = entity.datum_kreiranja;
            _narudzbenica.sveukupan_iznos = entity.sveukupan_iznos;
            _narudzbenica.broj_stavki = entity.broj_stavki;
            _narudzbenica.zaposlenik = zaposlenik;
         

            Entities.Add(_narudzbenica);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }

        }
        public narudzbenica GetNarudzbenicaById(int narudzbenicaId)
        {
            var query = (from p in Entities
                         where p.id == narudzbenicaId
                         select p).FirstOrDefault<narudzbenica>();

            return query;
        }

       public override IQueryable<narudzbenica> GetAll() {
            var query = from p in Entities
                        select p;
            return query;
        }
    }
}
