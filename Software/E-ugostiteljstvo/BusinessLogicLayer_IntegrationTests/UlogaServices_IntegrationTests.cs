using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests {
    public class UlogaServices_IntegrationTests {
        [Fact]
        public void GetUloge_ReturnsUloge() {

            //Arrange
            UlogaServices servis = new UlogaServices(new UlogaRepository());
            //Act
            var uloge = servis.GetUloge();
            //Assert
            Assert.IsType<List<uloga>>(uloge);

        }
    }
}
