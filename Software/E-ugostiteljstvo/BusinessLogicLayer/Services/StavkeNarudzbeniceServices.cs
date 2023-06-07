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
    public class StavkeNarudzbeniceServices
    {
        private IStavkeNarudzbeniceRepository repo;
        public StavkeNarudzbeniceServices(IStavkeNarudzbeniceRepository repository) {
            repo = repository;
        }
        public bool AddStavkeNarudzbenice(namirnica_narudzbenica _namirnica_narudzbenica)
        {
            bool isSuccessful = false;
            using (var r = new StavkeNarudzbeniceRepository())
            {
                int affectedRows = repo.Add(_namirnica_narudzbenica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

       
    }
}
