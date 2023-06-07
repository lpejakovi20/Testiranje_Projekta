using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository {
    public class FakeStavkeNarudzbeniceRepository : IStavkeNarudzbeniceRepository {
        public int Add(namirnica_narudzbenica entity, bool saveChanges = true) {
            if (entity != null) {
                return 1;
            } else return 0;
        }

        public IQueryable<dynamic> GetStavkeNarudzbenice(int narudzbenicaId) {
            throw new NotImplementedException();
        }

        public int Update(namirnica_narudzbenica entity, bool saveChanges = true) {
            throw new NotImplementedException();
        }
    }
}
