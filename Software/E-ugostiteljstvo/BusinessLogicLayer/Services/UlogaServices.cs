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
    public class UlogaServices
    {
        private IUlogaRepository repo;
        public UlogaServices(IUlogaRepository repository) {
            repo = repository;
        }
        public List<uloga> GetUloge()
        {
            
            using (var r = new UlogaRepository())
            {
                return repo.GetAll().ToList();
            }
        }
    }
}
