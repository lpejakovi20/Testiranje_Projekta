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
    ///<author>Matej Ritoša</author>
    public class NarudzbenicaServices
    {
        private INarudzbenicaRepository repo;
        public NarudzbenicaServices(INarudzbenicaRepository repository)
        {
            repo = repository;
        }
        public bool AddNarudzbenica(narudzbenica _narudzbenica)
        {
            bool isSuccessful = false;
            using (var pero = new NarudzbenicaRepository())
            {
                int affectedRows = repo.Add(_narudzbenica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<narudzbenica> GetNarudzbenice()
        {
            using (var repo = new NarudzbenicaRepository())
            {
                return repo.GetAll().ToList();
            }
        }
        public List<narudzbenica> SortirajPoDatumu()
        {
            using (var repo = new NarudzbenicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.datum_kreiranja).ToList();
            }
        }
        public List<narudzbenica> SortirajPoBrojuStavkiNajmanji()
        {
            using (var repo = new NarudzbenicaRepository())
            {
                return repo.GetAll().OrderBy(x => x.broj_stavki).ToList();
            }
        }
        public List<narudzbenica> SortirajPoBrojuStavkiNajveci()
        {
            using (var repo = new NarudzbenicaRepository())
            {
                
                return repo.GetAll().OrderByDescending(x => x.broj_stavki).ToList();

            }
        }

        public List<narudzbenica> SortirajPoIznosuNajmanji()
        {
            using (var repo = new NarudzbenicaRepository())
            {

                return repo.GetAll().OrderBy(x => x.sveukupan_iznos).ToList();

            }
        }

        public List<narudzbenica> SortirajPoIznosuNajveci()
        {
            using (var repo = new NarudzbenicaRepository())
            {

                return repo.GetAll().OrderByDescending(x => x.sveukupan_iznos).ToList();

            }
        }

        public narudzbenica GetNarudzbenicaById(int narudzbenicaId)
        {
            using (var repo = new NarudzbenicaRepository())
            {
                return repo.GetNarudzbenicaById(narudzbenicaId);
            }
        }
    }
}
