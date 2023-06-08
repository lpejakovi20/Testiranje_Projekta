using BusinessLogicLayer.Services;
using DataAccessLayer.Repositories;
using EntitiesLayer;
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

        [Fact]
        public void GetNamirniceById_GivenNamirnicaIdExists_ReturnsListOfNamirnica() {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            //Act
            var namirnice = service.GetNamirniceById(5);
            //Assert
            Assert.IsType<List<namirnica>>(namirnice);
        }

        [Fact]
        public void GetDostupneKolicineNamirnica_ReturnsListOfNamirnica() {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            //Act
            var dostupneNamirnice = service.GetDostupneKolicineNamirnica();
            //Assert
            Assert.IsType<List<StavkaNarudzbenice>>(dostupneNamirnice);
        }

        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdExists_ReturnsListWithItems()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            var id = 1019;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.IsType<List<namirnica>>(namirnice);
        }
        [Fact]
        public void GetNamirniceUskladistu_GivenNamirnicaIdExists_ReturnsCorrectItems()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            var id = 1019;
            //Act
            var namirnice = service.GetNamirniceUSkladistu(id);
            //Assert
            Assert.True(namirnice.All(item => item.namirnica_u_katalogu_id == id));
        }

        [Fact]
        public void GetNamirniceBlizuRoka_ReturnsListaNamirnicaBlizuRoka()
        {
            //Arrange
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            var today = DateTime.Today;
            var date = today.AddDays(7);
            //Act
            var namirnice = service.GetNamirniceBlizuRoka();
            //Assert
            Assert.True(namirnice.All(x => x.rok >= today && x.rok <= date));
        }
    }
}
