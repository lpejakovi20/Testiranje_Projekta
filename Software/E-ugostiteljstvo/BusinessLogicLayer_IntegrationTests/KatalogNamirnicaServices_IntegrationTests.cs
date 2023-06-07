using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests {
    public class KatalogNamirnicaServices_IntegrationTests {
        [Fact]
        public void GetKatalogNamirniceById_GivenNamirnicaIdExists_RetrurnsNamirnicaUKatalogu() {
            //Arrange
            KatalogNamirnicaServices servis = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            int idNamirnice = 548621104;
            //Act
            var namirnicaIzKatalog = servis.GetKatalogNamirnicaById(idNamirnice);
            //Assert
            Assert.Equal(namirnicaIzKatalog.id, idNamirnice);

        }
    }
}
