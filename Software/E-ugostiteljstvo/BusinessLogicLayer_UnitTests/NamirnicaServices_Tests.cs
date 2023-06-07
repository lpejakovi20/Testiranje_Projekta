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


        ///<author>Nikola Parag</author>
        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdIsNotValid_ReturnsEmptyList()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            var id = -123;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.Empty(namirnice);
        }
        ///<author>Nikola Parag</author>
        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdDoesNotExists_ReturnsEmptyList()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            var id = 562;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.Empty(namirnice);
        }
        ///<author>Nikola Parag</author>
        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdExists_ReturnsListWithItems()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            var id = 13;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.NotEmpty(namirnice);
        }
        ///<author>Nikola Parag</author>
        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdExists_ReturnsCorrectItems()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            var id = 13;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.True(namirnice.All(item => item.namirnica_u_katalogu_id == id));
        }
        ///<author>Nikola Parag</author>
        [Fact]
        public void GetNamirniceBlizuRoka_ReturnsListaNamirnicaBlizuRoka()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new FakeNamirnicaRepository());
            var today = DateTime.Today;
            var date = today.AddDays(7);
            //Act
            var namirnice = service.GetNamirniceBlizuRoka();
            //Assert
            Assert.True(namirnice.All(x => x.rok >= today && x.rok <= date));
        }
    }
}
