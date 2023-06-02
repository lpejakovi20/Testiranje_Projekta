using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class ZaposlenikServices
    {
        ///<author>Matej Ritoša</author>
        public bool AddZaposlenik(zaposlenik _zaposlenik)
        {
            bool isSuccessful = false;
            using (var repo = new ZaposlenikRepository())
            {
                int affectedRows = repo.Add(_zaposlenik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        ///<author>Matej Ritoša</author>
        public List<zaposlenik> GetZaposlenici()
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetAll().ToList();
            }
        }
        ///<author>Lovro Pejaković</author>
        public object GetZaposlenikById(int id)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikById(id);
            }
        }
        ///<author>Matej Ritoša</author>
        public zaposlenik GetZaposlenikByEmail(string phrase)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikByEmail(phrase);
            }
        }
        ///<author>Matej Ritoša</author>
        public zaposlenik GetZaposlenikNarudzbenice(int zaposlenikId)
        {
            using (var repo = new ZaposlenikRepository())
            {
                return repo.GetZaposlenikZaNarzdzbenicu(zaposlenikId);
            }
        }
    }
}
