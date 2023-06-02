using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer.Services
{
    ///<author>Matej Ritoša</author>
    public class StavkeNarudzbeniceServices
    {
        public bool AddStavkeNarudzbenice(namirnica_narudzbenica _namirnica_narudzbenica)
        {
            bool isSuccessful = false;
            using (var repo = new StavkeNarudzbeniceRepository())
            {
                int affectedRows = repo.Add(_namirnica_narudzbenica);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

       
    }
}
