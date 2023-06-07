using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests
{
    public class ZaposlenikServices_IntegrationTests
    {
        [Fact]
        public void GetZaposelnikById_GivenZaposlenikIdExists_ReturnsZaposlenik()
        {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
            var id = 7;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikById(id);
            //Assert
            Assert.Equal(dohvaceniZaposelnik.id, id);
        }

        [Fact]
        public void GetZaposelnikById_GivenZaposlenikIdNotExists_ReturnsNull()
        {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
            var id = 1;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikById(id);
            //Assert
            Assert.Null(dohvaceniZaposelnik);
        }
    }
}
