using BusinessLogicLayer.Services;
using BusinessLogicLayer_UnitTests.FakeRepository;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_UnitTests {
    public class UlogaServices_Tests {
        [Fact]
        public void GetUloge_ReturnsUloge() {
           
            //Arrange
            UlogaServices servis = new UlogaServices(new FakeUlogaRepository());
            //Act
            var uloge = servis.GetUloge();
            //Assert
            Assert.IsType<List<uloga>>(uloge);
            
        }
    }
}
