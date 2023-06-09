using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    public class ZaposlenikServices {
        private IZaposlenikRepository repo;

        public ZaposlenikServices(IZaposlenikRepository repository) {
            repo = repository;
        }

        ///<author>Matej Ritoša</author>
        public bool AddZaposlenik(zaposlenik _zaposlenik) {
            bool isSuccessful = false;
            using (var r = new ZaposlenikRepository()) {
                int affectedRows = repo.Add(_zaposlenik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        ///<author>Matej Ritoša</author>
        public List<zaposlenik> GetZaposlenici() {
            using (var r = new ZaposlenikRepository()) {
                return repo.GetAll().ToList();
            }
        }
        ///<author>Lovro Pejaković</author>
        public zaposlenik GetZaposlenikById(int id) {
            using (var r = new ZaposlenikRepository()) {
                return repo.GetZaposlenikById(id);
            }
        }
        ///<author>Matej Ritoša</author>
        public zaposlenik GetZaposlenikByEmail(string phrase) {
            using (var r = new ZaposlenikRepository()) {
                return repo.GetZaposlenikByEmail(phrase);
            }
        }
        ///<author>Matej Ritoša</author>
        public zaposlenik GetZaposlenikNarudzbenice(int zaposlenikId) {
            using (var r = new ZaposlenikRepository()) {
                return repo.GetZaposlenikZaNarudzbenicu(zaposlenikId);
            }
        }
        ///<author>Matej Ritoša</author>
        public bool PasswordStrenght(string password) {
            if (password.Length < 8) {
                return false;
            }

            // Add more strength criteria as per your requirements

            return true;


        }

       
    }
}
