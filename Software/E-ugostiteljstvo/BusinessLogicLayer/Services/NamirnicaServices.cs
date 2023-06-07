using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class NamirnicaServices
    {
        private INamirnicaRepository repo;
        public NamirnicaServices(INamirnicaRepository repository)
        {
            repo = repository;
        }
        ///<author>Matej Ritoša</author>
        public List<namirnica> GetNamirniceById(int id)
        {
            using (var r = new NamirnicaRepository())
            {
                return repo.GetNamirniceById(id).ToList();
            }
        }
        ///<author>Lovro Pejaković</author>
        public List<dynamic> GetNamirniceIstecenogRoka()
        {
            using (var r = new NamirnicaRepository())
            {
                return repo.GetNamirniceIstecenogRoka().ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<namirnica> GetNamirniceUSkladistu(int namirnica_id)
        {
            using (var r = new NamirnicaRepository())
            {
                return repo.GetNamirniceByKatalogId(namirnica_id).ToList();
            }
        }
        ///<author>Nikola Parag</author>
        public List<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka()
        {
            using (var r = new NamirnicaRepository())
            {
                return repo.GetNamirniceBlizuRoka().ToList();
            }
        }
        ///<author>Matej Ritoša</author>
        public List<StavkaNarudzbenice> GetDostupneKolicineNamirnica()
        {
            using (var r = new NamirnicaRepository())
            {
                return repo.GetDostupneKolicineNamirnica().ToList();
            }
        }
        ///<author>Lovro Pejaković</author>
        public bool UpdateNamirnica(namirnica product)
        {
            bool isSuccessful = false;
            using (var r = new NamirnicaRepository())
            {
                int affectedRows = repo.Update(product);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        ///<author>Lovro Pejaković</author>
        public bool AddNamirnica(namirnica _namirnica)
        {
            bool isSuccessful = false;
            using (var r = new NamirnicaRepository())
            {
                int affectedRows = repo.Add(_namirnica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
