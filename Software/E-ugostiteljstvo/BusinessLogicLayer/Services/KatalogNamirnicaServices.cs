using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class KatalogNamirnicaServices
    {
        ///<author>Nikola Parag</author>
        public bool AddNamirnica(namirnica_u_katalogu novanamirnica)
        {
            bool isSuccessful = false;
            using (var repo = new KatalogNamirnicaRepository())
            {
                int affectedRows = repo.Add(novanamirnica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> GetKatalogNamirnica()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().ToList();
            }
        }
        ///<author>Matej Ritoša</author>
        public List<dynamic> GetStavkeNarudzbenice(int narudzbenicaId)
        {
            using (var repo = new StavkeNarudzbeniceRepository())
            {
                return repo.GetStavkeNarudzbenice(narudzbenicaId).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase)
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetKatalogNamirnicaByName(phrase).ToList();
            }
        }
        ///<author>Matej Ritoša</author>
        public namirnica_u_katalogu GetKatalogNamirnicaById(int id)
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetKatalogNamirnicaById(id);
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> GetFiltered(string selecteditem)
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetFiltered(selecteditem).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> SortKraciRok()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.rok_uporabe).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> SortDuziRok()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderByDescending(x => x.rok_uporabe).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> SortManjaCijena()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.cijena).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica_u_katalogu> SortVecaCijena()
        {
            using (var repo = new KatalogNamirnicaRepository())
            {
                return repo.GetAll().OrderByDescending(x => x.cijena).ToList();
            }
        }

    }
}
