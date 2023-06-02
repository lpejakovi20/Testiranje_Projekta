using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Repositories
{
    ///<author>Nikola Parag</author>
    public class KatalogNamirnicaRepository : Repository<namirnica_u_katalogu>
    {
        public KatalogNamirnicaRepository() : base(new DBModel())
        {
        }

        public override int Add(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            var zaposlenik = Context.zaposlenik.SingleOrDefault(c => c.id == entity.zaposlenik_id);
            var novanamirnica = new namirnica_u_katalogu();
            novanamirnica.vrsta = entity.vrsta;
            novanamirnica.naziv = entity.naziv;
            novanamirnica.id = entity.id;
            novanamirnica.mjerna_jedinica = entity.mjerna_jedinica;
            novanamirnica.minimalne_zalihe = entity.minimalne_zalihe;
            novanamirnica.optimalne_zalihe = entity.optimalne_zalihe;
            novanamirnica.rok_uporabe = entity.rok_uporabe;
            novanamirnica.cijena = entity.cijena;
            novanamirnica.zaposlenik_id = zaposlenik.id;


            Entities.Add(novanamirnica);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }

        }

        public IQueryable<namirnica_u_katalogu> GetAll()
        {
            var query = from p in Entities.Include("zaposlenik")
                        select p;
            return query;
        }

        public IQueryable<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase)
        {
            var query = from p in Entities.Include("zaposlenik") where p.naziv.Contains(phrase)
                        select p;
            return query;
        }

        public namirnica_u_katalogu GetKatalogNamirnicaById(int id)
        {
            var query = (from p in Entities.Include("zaposlenik")
                        where p.id == id
                        select p).FirstOrDefault<namirnica_u_katalogu>();
            return query;
        }

        public IQueryable<namirnica_u_katalogu> GetFiltered(string selecteditem)
        {
            var query = from p in Entities.Include("zaposlenik")
                        where p.vrsta.Contains(selecteditem)
                        select p;
            return query;
        }
        public override int Update(namirnica_u_katalogu entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
