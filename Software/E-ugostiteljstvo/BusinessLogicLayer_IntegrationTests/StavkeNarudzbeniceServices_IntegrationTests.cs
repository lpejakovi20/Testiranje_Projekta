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
    public class StavkeNarudzbeniceServices_IntegrationTests {
        [Fact]
        public void AddStavkeNarudzbenice_GivenStavkaNarudzbeniceIsNotNull_StavkeNarudzbeniceIsCreated() {
            // Arrange
            using (var transaction = new TransactionScope()) {
                StavkeNarudzbeniceServices stavkeNarudzbeniceServices = new StavkeNarudzbeniceServices(new StavkeNarudzbeniceRepository());
                namirnica_narudzbenica stavka = new namirnica_narudzbenica {
                    namirnica_u_katalogu_id = 965498656,
                    narudzbenica_id = 809508601,
                    kolicina = 20
                };

                // Act
                var uspjeh = stavkeNarudzbeniceServices.AddStavkeNarudzbenice(stavka);
                // Assert
                Assert.True(uspjeh);
            }
        }
    }
}
