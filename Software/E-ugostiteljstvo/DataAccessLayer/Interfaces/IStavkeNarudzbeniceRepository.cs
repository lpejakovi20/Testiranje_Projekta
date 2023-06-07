using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces {
    public interface IStavkeNarudzbeniceRepository {

        int Update(namirnica_narudzbenica entity, bool saveChanges = true);
        int Add(namirnica_narudzbenica entity, bool saveChanges = true);
        IQueryable<dynamic> GetStavkeNarudzbenice(int narudzbenicaId);
    }
}
