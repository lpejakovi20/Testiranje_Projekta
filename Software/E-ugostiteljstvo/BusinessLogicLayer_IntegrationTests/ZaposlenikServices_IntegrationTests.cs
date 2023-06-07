using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests {
    public class ZaposlenikServices_IntegrationTests {
namespace BusinessLogicLayer_IntegrationTests
{
    public class ZaposlenikServices_IntegrationTests
    {
        [Fact]
        public void AddZaposlenik_GivenZaposelnikIsNotNull_ZaposlenikIsCreated() {
        public void GetZaposelnikById_GivenZaposlenikIdExists_ReturnsZaposlenik()
        {
            // Arrange
            using(var transaction = new TransactionScope()) {
                ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
                byte[] byteArray = { 0x41, 0x42, 0x43, 0x44, 0x45 };
                uloga novaUloga = new uloga {
                    id = 1,
                    naziv = "Kuhinja",
                    opis = null
                };
                zaposlenik zaposlenik = new zaposlenik { 
                    
                    ime = "Pero",
                    prezime = "Peric",
                    email = "pperic@mail.com",
                    uloga = novaUloga,
                    lozinka = "123456",
                    slika = byteArray

            };
                // Act
                var uspjeh = zaposlenikServices.AddZaposlenik(zaposlenik);
                // Assert
                Assert.True(uspjeh);

            }
            
        }
        [Fact]
        public void GetZaposelnikByEmail_GivenZaposlenikEmailExists_ReturnsZaposelnik() {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
            string email = "test@mail.com";
            var id = 7;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikByEmail(email);
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikById(id);
            //Assert
            Assert.Equal(dohvaceniZaposelnik.email, email);
            Assert.Equal(dohvaceniZaposelnik.id, id);
        }

        [Fact]
        public void GetZaposlenikNarudzbenice_GivenNarudzbenicaZaposelnikIdIsValid_ReturnsZaposlenik() {
            //Arrange
        public void GetZaposelnikById_GivenZaposlenikIdNotExists_ReturnsNull()
        {
            // Arrange
            ZaposlenikServices zaposlenikServices = new ZaposlenikServices(new ZaposlenikRepository());
            int zaposlenikId = 5;
            //Act
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikNarudzbenice(zaposlenikId);
            //Assert
            Assert.Equal(dohvaceniZaposelnik.id, zaposlenikId);
        }

        [Fact]
        public void GetZaposlenici_ReturnsZaposlenici() {
            //Arrange
            ZaposlenikServices servis = new ZaposlenikServices(new ZaposlenikRepository());
            var id = 1;
            //Act
            var zaposlenici = servis.GetZaposlenici();
            var dohvaceniZaposelnik = zaposlenikServices.GetZaposlenikById(id);
            //Assert
            Assert.IsType<List<zaposlenik>>(zaposlenici);
            Assert.Null(dohvaceniZaposelnik);
        }

    }
}
