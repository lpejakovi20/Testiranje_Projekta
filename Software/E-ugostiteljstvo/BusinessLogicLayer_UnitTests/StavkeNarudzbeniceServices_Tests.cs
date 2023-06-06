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
    public class StavkeNarudzbeniceServices_Tests
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
    }
}
