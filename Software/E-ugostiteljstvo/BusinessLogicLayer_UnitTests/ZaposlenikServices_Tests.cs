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
        [Fact]
        public void GetZaposlenici_ReturnsZaposlenici() {
            //Arrange
            ZaposlenikServices servis = new ZaposlenikServices(new FakeZaposlenikRepository());
            //Act
            var zaposlenici = servis.GetZaposlenici();
            //Assert
            Assert.IsType<List<zaposlenik>>(zaposlenici);
        }

        [Fact]
        public void GetZaposelnikById_GivenZaposlenikIdExists_ReturnsZaposlenik()
        {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
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
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            var id = 99;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikById(id);
            //Assert
            Assert.Null(dohvaceniZaposelnik);
        }


        [Fact]
        public void PasswordStrenght_GivenPassowordIsLessThan8Characters_ReturnWeak() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            var password = "pass";

            // Act
            var result = zaposlenikServices.PasswordStrenght(password);

            // Assert
            Assert.False(result);
        }
           [Fact]
            public void Empty_Password_ReturnsWeak() {
                // Arrange
                ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
                var password = "";

                // Act
                var result = zaposlenikServices.PasswordStrenght(password);

                // Assert
                Assert.False(result);
            }

        [Fact]
        public void PasswordStrenght_LengthGreaterThan8_ReturnsStrong() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new FakeZaposlenikRepository());
            var password = "strongpass";

            // Act
            var result = zaposlenikServices.PasswordStrenght(password);

            // Assert
            Assert.True(result);
        }


















    }
    }
