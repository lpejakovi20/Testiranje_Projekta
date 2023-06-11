using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IKatalogNamirnicaRepository
    {
        int Add(namirnica_u_katalogu entity, bool saveChanges = true);
        int Delete(namirnica_u_katalogu entity, bool saveChanges = true);
        IQueryable<namirnica_u_katalogu> GetAll();
        IQueryable<namirnica_u_katalogu> GetKatalogNamirnicaByName(string phrase);
        namirnica_u_katalogu GetKatalogNamirnicaById(int id);
        IQueryable<namirnica_u_katalogu> GetFiltered(string selecteditem);
        int Update(namirnica_u_katalogu entity, bool saveChanges = true);
    }
}
