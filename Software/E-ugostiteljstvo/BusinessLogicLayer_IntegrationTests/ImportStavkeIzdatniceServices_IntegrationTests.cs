using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xunit;

namespace BusinessLogicLayer_IntegrationTests
{
    public class ImportStavkeIzdatniceServices_IntegrationTests
    {
        [Fact]
        public void ParsirajExcelDatoteku_GivenIspravnaDatoteka_ReturnsListOfStringArrays()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo binDirectory = Directory.GetParent(currentDirectory);
            DirectoryInfo projectDirectory = binDirectory?.Parent?.Parent;

            string relativePath = Path.Combine(projectDirectory?.FullName, "Resursi", "stavkeIzdatnice.xlsx");

            //Act
            var lista = servis.ParsirajExcelDatoteku(relativePath);

            //Assert
            Assert.IsType<List<string[]>>(lista);
        }
        [Fact]
        public void ParsirajExcelDatoteku_GivenDatotekaNeispravnogFormata_ReturnsNull()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo binDirectory = Directory.GetParent(currentDirectory);
            DirectoryInfo projectDirectory = binDirectory?.Parent?.Parent;

            string relativePath = Path.Combine(projectDirectory?.FullName, "Resursi", "neispravanFormat.xlsx");

            //Act
            var lista = servis.ParsirajExcelDatoteku(relativePath);

            //Assert
            Assert.Null(lista);
        }

        [Fact]
        public void KeepOnlyValidOnes_GivenListOfStavkaIzdatnice_ReturnsOnlyValidOnes()
        {
            //Arrange
            using (var transaction = new TransactionScope())
            {
                var servis = new ImportStavkeIzdatniceServices();

                List<StavkaIzdatnice> stavke = new List<StavkaIzdatnice>
                {
                    new StavkaIzdatnice(965840602, "Salama parizer", "Prerađeni proizvodi", 5, "kom", DateTime.Parse("9.6.2023."), 11111111),
                    new StavkaIzdatnice(23312, "Salama parizer", "Prerađeni proizvodi", 10, "kom", DateTime.Parse("6.6.2023."), 11122221),
                    new StavkaIzdatnice(966113288, "Tjestenina spagheti (Barilla)", "Tjestenine", 2, "kg", DateTime.Parse("14.2.2024."), 11122221)
                };

                //Act
                var ispravne = servis.KeepOnlyValidOnes(stavke);

                var sadrzi = ispravne.Contains(stavke[1]);

                //Assert
                Assert.True(ispravne.Count<3 && !sadrzi);

            }
        }
    }
}
