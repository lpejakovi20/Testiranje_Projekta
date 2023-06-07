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
    public class NamirnicaServices_Tests
    {
        [Fact]
        public void AddNamirnica_GivenNamirnicaIsNotNull_NamirnicaIsAdded()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());

            //Act
            var nova = new namirnica
            {
                namirnica_u_katalogu_id = 10,
                kolicina = 5,
                rok = DateTime.Now
            };

            var uspjeh = service.AddNamirnica(nova);

            //Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void AddNamirnica_GivenNamirnicaIsNull_NamirnicaIsNotAdded()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());

            //Act
            var uspjeh = service.AddNamirnica(null);

            //Assert
            Assert.False(uspjeh);
        }

        [Fact]
        public void UpdateNamirnica_GivenNamirnicaIsNotNull_NamirnicaIsUpdated()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());

            //Act
            var nova = new namirnica
            {
                namirnica_u_katalogu_id = 10,
                kolicina = 5,
                rok = DateTime.Now
            };

            var uspjeh = service.UpdateNamirnica(nova);

            //Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void UpdateNamirnica_GivenNamirnicaIsNull_NamirnicaIsNotUpdated()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());

            //Act
            var uspjeh = service.UpdateNamirnica(null);

            //Assert
            Assert.False(uspjeh);
        }

        [Fact]
        public void GetNamirniceIstecenogRoka_ReturnsList()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());

            //Act
            var iskoristeneNamirnice = service.GetNamirniceIstecenogRoka();

            //Assert
            Assert.IsType<List<dynamic>>(iskoristeneNamirnice);
        }


        [Fact]
        public void GetNamirniceById_GivenNamirnicaIdExists_ReturnsListOfNamirnica() {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            //Act
            var namirnice = service.GetNamirniceById(3);
            //Assert
            Assert.IsType<List<namirnica>>(namirnice);
        }

        [Fact]
        public void GetNamirniceById_GivenNamirnicaIdDoesNotExist_ReturnsEmptyList() {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            //Act
            var namirnice = service.GetNamirniceById(112);
            //Assert
            Assert.Empty(namirnice);
        }
        [Fact]
        public void GetDostupneKolicineNamirnica_ReturnsListOfNamirnica() {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            //Act
            var dostupneNamirnice = service.GetDostupneKolicineNamirnica();
            //Assert
            Assert.IsType<List<StavkaNarudzbenice>>(dostupneNamirnice);
        }


    }
}
