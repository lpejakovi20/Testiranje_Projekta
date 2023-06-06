using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests
{
    public class NamirnicaServices_IntegrationTests
    {
        [Fact]
        public void AddNamirnica_GivenNamirnicaIsNotNull_NamirnicaIsAdded()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());

                //Act
                var nova = new namirnica
                {
                    namirnica_u_katalogu_id = 552182865,
                    kolicina = 99,
                    rok = DateTime.Now
                };

                var uspjeh = service.AddNamirnica(nova);

                //Assert
                Assert.True(uspjeh);
            }
        }

        [Fact]
        public void UpdateNamirnica_GivenNamirnicaIsNotNull_NamirnicaIsUpdated()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());

                //Act
                string dateString = "2023-04-24";
                DateTime dateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                var nova = new namirnica
                {
                    namirnica_u_katalogu_id = 552182865,
                    kolicina = 99,
                    rok = dateTime
                };

                var uspjeh = service.UpdateNamirnica(nova);

                //Assert
                Assert.True(uspjeh);
            }
        }

        [Fact]
        public void GetNamirniceIstecenogRoka_ReturnsList()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());

            //Act
            var iskoristeneNamirnice = service.GetNamirniceIstecenogRoka();

            //Assert
            Assert.IsType<List<dynamic>>(iskoristeneNamirnice);
        }
    }
}
