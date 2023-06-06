using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface INarudzbenicaRepository
    {
        int Update(narudzbenica entity, bool saveChanges = true);
        int Add(narudzbenica entity, bool saveChanges = true);
        narudzbenica GetNarudzbenicaById(int narudzbenicaId);
    }
}
