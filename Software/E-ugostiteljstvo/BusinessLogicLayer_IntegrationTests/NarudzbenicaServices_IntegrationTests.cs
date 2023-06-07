using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Transactions;

namespace BusinessLogicLayer_IntegrationTests {
    public class NarudzbenicaServices_IntegrationTests {
        [Fact]
        public void AddNarudzbenica_GivenNarudzbenicaIsNotNull_NarudzbenicaIsCreated() {
            // Arrange
            using (var transaction = new TransactionScope()) {
                NarudzbenicaServices narudzbenicaServices = new NarudzbenicaServices(new NarudzbenicaRepository());
                narudzbenica narudzbenica = new narudzbenica {

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
        }

        [Fact]
        public void GetNarudzbeniceById_GivenNarudzbenicaExists_ReturnsNarudzbenica() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            var id = 6672858;
            //Act
            var narudzbenica = servis.GetNarudzbenicaById(6672858);
            //Assert
            Assert.Equal(narudzbenica.id,id);
        }

        [Fact]
        public void GetNarudzbenice_ReturnsNarudzbenice() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenica = servis.GetNarudzbenice();
            //Assert
            Assert.IsType<List<narudzbenica>>(narudzbenica);
        }

        [Fact]
        public void SortirajPoDatumu_ReturnsNarudzbeniceSortedByDate() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoDatumu();
            var sortirane = narudzbenice.OrderBy(o => o.datum_kreiranja);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoBrojuStavkiNajmanji_ReturnsNarudzbeniceSortedByNumberOfStavkiAscending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoBrojuStavkiNajmanji();
            var sortirane = narudzbenice.OrderBy(o => o.broj_stavki);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoBrojuStavkiNajveci_ReturnsNarudzbeniceSortedByNumberOfStavkiDescending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoBrojuStavkiNajveci();
            var sortirane = narudzbenice.OrderByDescending(o => o.broj_stavki);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }

        [Fact]
        public void SortirajPoIznosuNajmanji_ReturnsNarudzbeniceSortedByAmountAscending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoIznosuNajmanji();
            var sortirane = narudzbenice.OrderBy(o => o.sveukupan_iznos);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }
        [Fact]
        public void SortirajPoIznosuNajveci_ReturnsNarudzbeniceSortedByAmountDescending() {
            //Arrange
            NarudzbenicaServices servis = new NarudzbenicaServices(new NarudzbenicaRepository());
            //Act
            var narudzbenice = servis.SortirajPoIznosuNajveci();
            var sortirane = narudzbenice.OrderByDescending(o => o.sveukupan_iznos);
            //Assert
            Assert.True(narudzbenice.SequenceEqual(sortirane));

        }


    }
}
