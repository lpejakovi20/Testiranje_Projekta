using BusinessLogicLayer.Services;
using BusinessLogicLayer_UnitTests.FakeRepository;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_UnitTests
{
    public class KatalogNamirnica_Tests
    {
        [Fact]
        public static void AddUKatalog_GivenNovaNamirnicaIsNull_NovaNamirnicaUKataloguIsNotCreated()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());


            //Act
            var uspjeh = katalogServices.AddNamirnica(null);
            //Assert
            Assert.False(uspjeh);

        }

        [Fact]
        public static void AddUKatalog_GivenNovaNamirnicaIsNotNull_NovaNamirnicaUKataloguIsCreated()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            var novaNamirnica = new namirnica_u_katalogu
            {
                id = 23,
                naziv = "Brašno",
                vrsta = "Meso",
                minimalne_zalihe = 12,
                optimalne_zalihe = 25,
                mjerna_jedinica = "kg",
                rok_uporabe = 14,
                cijena = 15,
                zaposlenik_id = 1
            };

            //Act
            var uspjeh = katalogServices.AddNamirnica(novaNamirnica);
            //Assert
            Assert.True(uspjeh);

        }

        [Fact]

        public static void GetFiltered_GivenSelectedItemIsNotNull_ReturnsFilteredKatalogList()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            var odabraniFilter = "Meso";
            //Act
            var filtriranaLista = katalogServices.GetFiltered(odabraniFilter);
            //Assert
            Assert.IsType<List<namirnica_u_katalogu>>(filtriranaLista);
        }
        [Fact]

        public static void GetFiltered_GivenSelectedItemIsNotNull_ReturnsCorrectItems()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            var odabraniFilter = "Meso";
            //Act
            var filtriranaLista = katalogServices.GetFiltered(odabraniFilter);
            //Assert
            Assert.True(filtriranaLista.All(obj => obj.vrsta == "Meso"));
        }

        [Fact]

        public static void GetKatalogNamirnicaByName_GivenNameIsNull_ReturnsEmptyList()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());

            //Act
            var filtriranaLista = katalogServices.GetKatalogNamirnicaByName(null);
            //Assert
            Assert.Empty(filtriranaLista);
        }
        [Fact]

        public static void GetKatalogNamirnicaByName_GivenNameIsNotNull_ReturnsFilledList()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            var phrase = "Jabuka";
            //Act
            var filtriranaLista = katalogServices.GetKatalogNamirnicaByName(phrase);
            //Assert
            Assert.NotEmpty(filtriranaLista);
        }
        [Fact]

        public static void GetKatalogNamirnicaByName_GivenNameIsNotNull_ReturnsCorrectItems()
        {
            //Arange
            KatalogNamirnicaServices katalogServices = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            var phrase = "Ananas";
            //Act
            var filtriranaLista = katalogServices.GetKatalogNamirnicaByName(phrase);
            //Assert
            Assert.True(filtriranaLista.All(obj => obj.naziv.Contains(phrase)));
        }

        [Fact]
        public void GetKatalogNamirniceById_GivenNamirnicaIdExists_RetrurnsNamirnicaUKatalogu() {
            //Arrange
            KatalogNamirnicaServices servis = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            int idNamirnice = 125;
            //Act
            var namirnicaIzKatalog = servis.GetKatalogNamirnicaById(idNamirnice);
            //Assert
            Assert.Equal(namirnicaIzKatalog.id, idNamirnice);

        }
        [Fact]
        public void GetKatalogNamirniceById_GivenNamirnicaIdDoesntExists_RetrurnsNull() {
            //Arrange
            KatalogNamirnicaServices servis = new KatalogNamirnicaServices(new FakeKatalogNamirnicaRepository());
            int idNamirnice = 12;
            //Act
            var namirnicaIzKatalog = servis.GetKatalogNamirnicaById(idNamirnice);
            //Assert
            Assert.Null(namirnicaIzKatalog);

        }
    }
}
