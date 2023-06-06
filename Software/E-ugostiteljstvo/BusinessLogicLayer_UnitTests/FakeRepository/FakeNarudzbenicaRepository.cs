using DataAccessLayer.Interfaces;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository
{
    public class FakeNarudzbenicaRepository : INarudzbenicaRepository
    {
        public int Add(narudzbenica entity, bool saveChanges = true)
        {
            if(entity == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        public narudzbenica GetNarudzbenicaById(int narudzbenicaId)
        {
            throw new NotImplementedException();
        }

        public int Update(narudzbenica entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
