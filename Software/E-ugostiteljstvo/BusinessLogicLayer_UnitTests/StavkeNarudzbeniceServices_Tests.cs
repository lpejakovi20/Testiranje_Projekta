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
    public class StavkeNarudzbeniceServices_Tests {
        [Fact]
        public void AddStavkeNarudzbenice_GivenStavkaNarudzbeniceIsNotNull_StavkeNarudzbeniceIsCreated() {
            // Arrange

            StavkeNarudzbeniceServices stavkeNarudzbeniceServices = new StavkeNarudzbeniceServices(new FakeStavkeNarudzbeniceRepository());
            namirnica_narudzbenica stavka = new namirnica_narudzbenica {
                namirnica_u_katalogu_id = 2,
                narudzbenica_id = 3,
                kolicina = 20
            };

            // Act
            var uspjeh = stavkeNarudzbeniceServices.AddStavkeNarudzbenice(stavka);
            // Assert
            Assert.True(uspjeh);
        }

        [Fact]
        public void AddStavkeNarudzbenice_GivenStavkaNarudzbeniceIsNull_StavkeNarudzbeniceIsNotCreated() {
            // Arrange
            StavkeNarudzbeniceServices stavkeNarudzbeniceServices = new StavkeNarudzbeniceServices(new FakeStavkeNarudzbeniceRepository());
            // Act
            var uspjeh = stavkeNarudzbeniceServices.AddStavkeNarudzbenice(null);
            // Assert
            Assert.False(uspjeh);
        }
    }
}
