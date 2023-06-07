using BusinessLogicLayer.Services;
using BusinessLogicLayer_UnitTests.FakeRepository;
using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_UnitTests
{
    public class NarudzbenicaServices_Tests
    {
        [Fact]
        public static void AddNarudzbenica_GivenNarudzbenicaIsNull_NarudzbenicaIsNotCreated()
        {
            //Arange
           NarudzbenicaServices narudzbenicaServices = new NarudzbenicaServices(new FakeNarudzbenicaRepository());

            
            //Act
           var uspjeh = narudzbenicaServices.AddNarudzbenica(null);
            //Assert
            Assert.False(uspjeh);

        }
        [Fact]
        public void AddNarudzbenica_GivenNarudzbenicaIsNotNull_NarudzbenicaIsCreated()
        {
            // Arrange

            NarudzbenicaServices narudzbenicaServices = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            narudzbenica narudzbenica = new narudzbenica
            {

                id = 212,
                datum_kreiranja = DateTime.Now,
                sveukupan_iznos = 5,
                broj_stavki = 5,
                zaposlenik_id = 1

            };

            // Act

            var uspjeh = narudzbenicaServices.AddNarudzbenica(narudzbenica);
            // Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void GetNarudzbeniceById_GivenNarudzbenicaExists_ReturnsNarudzbenica() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            var id = 125;
            //Act
            var narudzbenica = servis.GetNarudzbenicaById(id);
            //Assert
            Assert.Equal(narudzbenica.id, id);
        }
        [Fact]
        public void GetNarudzbeniceById_GivenNarudzbenicaIsNotValid_ReturnsNull() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenica = servis.GetNarudzbenicaById(0);
            //Assert
            Assert.Null(narudzbenica);
        }
        [Fact]
        public void GetNarudzbeniceById_GivenNarudzbenicaDoesntExist_ReturnsNull() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenica = servis.GetNarudzbenicaById(12);
            //Assert
            Assert.Null(narudzbenica);
        }
        [Fact]
        public void GetNarudzbenice_ReturnsNarudzbenice() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenica = servis.GetNarudzbenice();
            //Assert
            Assert.IsType<List<narudzbenica>>(narudzbenica);
        }
        [Fact]
        public void SortirajPoDatumu_ReturnsNarudzbeniceSortedByDate() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoDatumu();
            var sortirane = narudzbenice.OrderBy(o => o.datum_kreiranja);      
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoBrojuStavkiNajmanji_ReturnsNarudzbeniceSortedByNumberOfStavkiAscending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoBrojuStavkiNajmanji();
            var sortirane = narudzbenice.OrderBy(o => o.broj_stavki);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoBrojuStavkiNajveci_ReturnsNarudzbeniceSortedByNumberOfStavkiDescending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoBrojuStavkiNajveci();
            var sortirane = narudzbenice.OrderByDescending(o => o.broj_stavki);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoIznosuNajmanji_ReturnsNarudzbeniceSortedByAmountAscending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoIznosuNajmanji();
            var sortirane = narudzbenice.OrderByDescending(o => o.sveukupan_iznos);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoIznosuNajveci_ReturnsNarudzbeniceSortedByAmountDescending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new FakeNarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoIznosuNajveci();
            var sortirane = narudzbenice.OrderByDescending(o => o.sveukupan_iznos);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }

    }
}
