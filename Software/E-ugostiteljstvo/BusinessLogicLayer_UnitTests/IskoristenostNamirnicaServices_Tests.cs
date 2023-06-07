using BusinessLogicLayer.Services;
using BusinessLogicLayer_UnitTests.FakeRepository;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_UnitTests
{
    public class IskoristenostNamirnicaServices_Tests
    {
        [Fact]
        public void AddIskoristenostNamirnice_GivenIskoristenostNamirniceIsNotNull_IskoristenostNamirniceIsAdded()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new FakeIskoristenostNamirnicaRepository());
            var iskoristenost = new iskoristenost_namirnice()
            {
                iskoristeno = 10,
                namirnica_u_katalogu_id = 5,
                datum = DateTime.Now
            };

            //Act
            var uspjeh = service.AddIskoristenostNamirnice(iskoristenost);

            //Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void AddIskoristenostNamirnice_GivenIskoristenostNamirniceIsNull_IskoristenostNamirniceIsNotAdded()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new FakeIskoristenostNamirnicaRepository());

            //Act
            var uspjeh = service.AddIskoristenostNamirnice(null);

            //Assert
            Assert.False(uspjeh);
        }

        [Fact]
        public void UpdateIskoristenostNamirnice_GivenIskoristenostNamirniceIsNotNull_IskoristenostNamirniceIsUpdated()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new FakeIskoristenostNamirnicaRepository());
            var iskoristenost = new iskoristenost_namirnice()
            {
                iskoristeno = 10,
                namirnica_u_katalogu_id = 5,
                datum = DateTime.Now
            };

            //Act
            var uspjeh = service.UpdateIskoristenostNamirnice(iskoristenost);

            //Assert
            Assert.True(uspjeh);
        }
        
        [Fact]
        public void UpdateIskoristenostNamirnice_GivenIskoristenostNamirniceIsNull_IskoristenostNamirniceIsNotUpdated()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new FakeIskoristenostNamirnicaRepository());

            //Act
            var uspjeh = service.UpdateIskoristenostNamirnice(null);

            Assert.False(uspjeh);
            //Assert
        }

        [Fact]
        public void GetIskoristeneNamirniceByMonth_GivenValidMonthAndYear_ReturnsList()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new FakeIskoristenostNamirnicaRepository());

            //Act
            var iskoristeneNamirnice = service.GetIskoristeneNamirniceByMonth(2, 2023);

            //Assert
            Assert.IsType<List<StavkaIskoristenostNamirnice>>(iskoristeneNamirnice);
        }
    }
}
