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
    public class KatalogNamirnicaServices_IntegrationTests {
        [Fact]
        public void GetKatalogNamirniceById_GivenNamirnicaIdExists_RetrurnsNamirnicaUKatalogu() {
            //Arrange
            KatalogNamirnicaServices servis = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            int idNamirnice = 548621104;
            //Act
            var namirnicaIzKatalog = servis.GetKatalogNamirnicaById(idNamirnice);
            //Assert
            Assert.Equal(namirnicaIzKatalog.id, idNamirnice);

        }

        [Fact]
        public void AddUKatalog_GivenNovaNamirnicaIsNotNull_NovaNamirnicaUKataloguIsCreated()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                
                var novaNamirnica = new namirnica_u_katalogu()
                {
                    id = 234,
                    naziv = "Brašno",
                    vrsta = "Meso",
                    minimalne_zalihe = 12,
                    optimalne_zalihe = 25,
                    mjerna_jedinica = "kg",
                    rok_uporabe = 14,
                    cijena = 15,
                    zaposlenik_id = 7,
                    
                };
                KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
                //Act
                var uspjeh = katalogServices.AddNamirnica(novaNamirnica);
                //Assert
                Assert.True(uspjeh);
            }
        }
        [Fact]
        public void GetFiltered_GivenSelectedItemIsNotNull_ReturnsFilteredKatalogList()
        {
        //Arrange
            
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            var odabraniFilter = "Meso";
        //Act
            var filtriranaLista = katalogServices.GetFiltered(odabraniFilter);
        //Assert
            Assert.IsType<List<namirnica_u_katalogu>>(filtriranaLista);
        }

        [Fact]
        public void GetFiltered_GivenSelectedItemIsNotNull_ReturnsCorrectItems()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            var odabraniFilter = "Meso";
            //Act
            var filtriranaLista = katalogServices.GetFiltered(odabraniFilter);
            //Assert
            Assert.True(filtriranaLista.All(obj => obj.vrsta == "Meso"));
        }

        [Fact]
        public void GetKatalogNamirnicaByName_GivenNameIsNotNull_ReturnsFilledList()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            var name = "Jabuka";
            //Act
            var filtriranaLista = katalogServices.GetKatalogNamirnicaByName(name);
            //Assert
            Assert.NotEmpty(filtriranaLista);
        }
        [Fact]
        public void GetKatalogNamirnicaByName_GivenNameIsNotNull_ReturnsCorrectItems()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            var name = "Jabuka";
            //Act
            var filtriranaLista = katalogServices.GetKatalogNamirnicaByName(name);
            //Assert
            Assert.True(filtriranaLista.All(obj => obj.naziv.Contains(name)));
        }

        [Fact]
        public void GetKatalogNamirnica_RetrurnsKatalogNamirnica()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
            
            //Act
            var namirnicaIzKatalog = katalogServices.GetKatalogNamirnica();
            //Assert
            Assert.NotEmpty(namirnicaIzKatalog);
        }
        [Fact]
        public void GetKatalogNamirnica_RetrurnsSortiranoPoKracemRokuTrajanja()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());

            //Act
            var namirnice = katalogServices.SortKraciRok();
            var sortirane = namirnice.OrderBy(o => o.rok_uporabe);
            //Assert
            Assert.True(namirnice.SequenceEqual(sortirane));
        }
        [Fact]
        public void GetKatalogNamirnica_RetrurnsSortiranoPoDuzemRokuTrajanja()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());

            //Act
            var namirnice = katalogServices.SortDuziRok();
            var sortirane = namirnice.OrderByDescending(o => o.rok_uporabe);
            //Assert
            Assert.True(namirnice.SequenceEqual(sortirane));
        }

        [Fact]
        public void GetKatalogNamirnica_RetrurnsSortiranoPoManjojCijeni()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());

            //Act
            var namirnice = katalogServices.SortManjaCijena();
            var sortirane = namirnice.OrderBy(o => o.cijena);
            //Assert
            Assert.True(namirnice.SequenceEqual(sortirane));
        }
        [Fact]
        public void GetKatalogNamirnica_RetrurnsSortiranoPoVecojCijeni()
        {
            //Arrange

            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());

            //Act
            var namirnice = katalogServices.SortVecaCijena();
            var sortirane = namirnice.OrderByDescending(o => o.cijena);
            //Assert
            Assert.True(namirnice.SequenceEqual(sortirane));
        }

        [Fact]
        public void DeleteFromKatalog_GivenSelectedNamirnicaIsNotNull_SelectedNamirnicaUKataloguIsDeleted()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {

                var namirnicaDelete = new namirnica_u_katalogu()
                {
                    id = 101958092,
                    naziv = "nista",
                    vrsta = "Riba",
                    minimalne_zalihe = 12,
                    optimalne_zalihe = 12,
                    mjerna_jedinica = "kom",
                    rok_uporabe = 12,
                    cijena = 12,
                    zaposlenik_id = 7,

                };
                KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new KatalogNamirnicaRepository());
                //Act
                var uspjeh = katalogServices.DeleteNamirnica(namirnicaDelete);
                //Assert
                Assert.True(uspjeh);
            }
        }

    }
}
