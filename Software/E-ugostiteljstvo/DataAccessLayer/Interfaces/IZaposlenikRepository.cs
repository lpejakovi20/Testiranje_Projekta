using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces {
    public interface IZaposlenikRepository {
        zaposlenik GetZaposlenikByEmail(string phrase);
        zaposlenik GetZaposlenikById(int id);
        zaposlenik GetZaposlenikZaNarudzbenicu(int zaposlenikId);
        int Update(zaposlenik entity, bool saveChanges = true);

        int Add(zaposlenik entity, bool saveChanges = true);
    }
}
