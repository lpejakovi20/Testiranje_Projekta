using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests
{
    public class IskoristenostNamirnicaServices_IntegrationTests
    {
        [Fact]
        public void AddIskoristenostNamirnice_GivenIskoristenostNamirniceIsNotNull_IskoristenostNamirniceIsAdded()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                var iskoristenost = new iskoristenost_namirnice()
                {
                    iskoristeno = 99,
                    namirnica_u_katalogu_id = 552182865,
                    datum = DateTime.Now
                };
                IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new IskoristenostNamirnicaRepository());

                //Act
                var uspjeh = service.AddIskoristenostNamirnice(iskoristenost);

                //Assert
                Assert.True(uspjeh);

                transaction.Dispose();
            }
        }

        [Fact]
        public void UpdateIskoristenostNamirnice_GivenIskoristenostNamirniceIsNotNull_IskoristenostNamirniceIsUpdated()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new IskoristenostNamirnicaRepository());
                var iskoristenost = new iskoristenost_namirnice()
                {
                    iskoristeno = 99,
                    namirnica_u_katalogu_id = 552182865,
                    datum = DateTime.Now
                };

                //Act
                var uspjeh = service.UpdateIskoristenostNamirnice(iskoristenost);

                //Assert
                Assert.True(uspjeh);

                transaction.Dispose();
            }
        }

        [Fact]
        public void GetIskoristeneNamirniceByMonth_GivenValidMonthAndYear_ReturnsList()
        {
            //Arrange
            IskoristenostNamirnicaServices service = new IskoristenostNamirnicaServices(new IskoristenostNamirnicaRepository());

            //Act
            var iskoristeneNamirnice = service.GetIskoristeneNamirniceByMonth(2, 2023);

            //Assert
            Assert.IsType<List<StavkaIskoristenostNamirnice>>(iskoristeneNamirnice);
        }
    }
}
