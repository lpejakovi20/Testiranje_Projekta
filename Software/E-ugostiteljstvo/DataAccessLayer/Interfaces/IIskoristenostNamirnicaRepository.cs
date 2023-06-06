using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IIskoristenostNamirnicaRepository
    {
        IQueryable<StavkaIskoristenostNamirnice> GetIskoristeneNamirniceByMonth(int month, int year);
        int Update(iskoristenost_namirnice entity, bool saveChanges = true);
        int Add(iskoristenost_namirnice entity, bool saveChanges = true);
    }
}
