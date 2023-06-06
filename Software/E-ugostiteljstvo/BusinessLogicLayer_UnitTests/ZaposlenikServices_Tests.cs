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
    public class ZaposlenikServices_Tests {
        [Fact]
        public void AddZaposlenik_GivenZaposelnikIsNotNull_ZaposlenikIsCreated() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            zaposlenik zaposlenik = new zaposlenik {

                id = 20,
                ime = "Pero",
                prezime = "Peric",
                email = "pperic@mail.com",
                lozinka = "123456",
                slika = null
            };
            // Act
            var uspjeh = zaposlenikServices.AddZaposlenik(zaposlenik);
            // Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void AddZaposlenik_GivenZaposelnikIsNull_ZaposlenikIsNotCreated() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            // Act
            var uspjeh = zaposlenikServices.AddZaposlenik(null);
            // Assert
            Assert.False(uspjeh);
        }

        [Fact]
        public void GetZaposelnikByEmail_GivenZaposlenikEmailExists_ReturnsZaposelnik() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            string email = "test@mail.com";
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikByEmail(email);
            //Assert
            Assert.Equal(dohvaceniZaposelnik.email, email);
        }

        [Fact]
        public void GetZaposelnikByEmail_GivenZaposlenikEmailDoesntExists_ReturnsNull() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            string email = "test2@mail.com";
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikByEmail(email);
            //Assert
            Assert.Null(dohvaceniZaposelnik);
        }
        [Fact]
        public void GetZaposelnikByEmail_GivenZaposlenikEmailIsEmpty_ReturnsNull() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            string email = "";
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikByEmail(email);
            //Assert
            Assert.Null(dohvaceniZaposelnik);
        }

        [Fact]
        public void GetZaposlenikNarudzbenice_GivenNarudzbenicaZaposelnikIdIsValid_ReturnsZaposlenik() {
            //Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            int zaposlenikId = 5;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikNarudzbenice(zaposlenikId);
            //Assert
            Assert.Equal(dohvaceniZaposelnik.id, zaposlenikId);
        }
        [Fact]
        public void GetZaposlenikNarudzbenice_GivenNarudzbenicaZaposelnikIdIsNotValid_ReturnsNull() {
            //Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            int zaposlenikId = -2;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikNarudzbenice(zaposlenikId);
            //Assert
            Assert.Null(dohvaceniZaposelnik);
        }
    }
}
