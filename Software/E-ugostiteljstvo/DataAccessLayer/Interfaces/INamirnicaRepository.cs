using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface INamirnicaRepository
    {
        int Update(namirnica entity, bool saveChanges = true);
        IQueryable<namirnica> GetNamirniceById(int id);
        namirnica GetNamirnicaByRokTrajanja(DateTime rok, int id);
        IQueryable<namirnica> GetNamirniceByKatalogId(int namirnica_id);
        int Add(namirnica entity, bool saveChanges = true);
        IQueryable<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka();
        IQueryable<dynamic> GetNamirniceIstecenogRoka();
        IQueryable<StavkaNarudzbenice> GetDostupneKolicineNamirnica();
    }
}
