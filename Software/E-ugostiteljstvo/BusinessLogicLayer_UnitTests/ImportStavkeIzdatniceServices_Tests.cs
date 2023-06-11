using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogicLayer_UnitTests
{
    public class ImportStavkeIzdatniceServices_Tests
    {
        [Fact]
        public void CheckTypeOfValuesInRow_GivenFirstColumnCellNotAnInteger_ReturnsFalse()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.CheckTypeOfValuesInRow("test", 0);

            //Assert
            Assert.False(vrijednost);
        }
        [Fact]
        public void CheckTypeOfValuesInRow_GivenFifthColumnCellNotADateTime_ReturnsFalse()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.CheckTypeOfValuesInRow("test", 5);

            //Assert
            Assert.False(vrijednost);
        }

        [Fact]
        public void CheckTypeOfValuesInRow_GivenFirstColumnCellIsAnInteger_ReturnsTrue()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.CheckTypeOfValuesInRow("965840602", 0);

            //Assert
            Assert.True(vrijednost);
        }

        [Fact]
        public void CreateStavkeIzdatnice_GivenParsedData_ReturnsListOfStavkaIzdatnice()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            List<string[]> parsedData = new List<string[]>
            {
                new string[] { "965840602", "Salama parizer", "Prerađeni proizvodi", "5", "kom", "9.6.2023." },
                new string[] { "965840602", "Salama parizer", "Prerađeni proizvodi", "10", "kom", "10.6.2023." },
                new string[] { "966113288", "Tjestenina spagheti (Barilla)", "Tjestenine", "2", "kg", "14.2.2024." }
            };

            //Act
            var stavke = servis.CreateStavkeIzdatnice(parsedData);

            //Assert
            Assert.IsType<List<StavkaIzdatnice>>(stavke);
            Assert.Equal(parsedData[2][0], stavke[2].Id.ToString());
        }

        [Fact]
        public void GenerateRandomnumber_GivenObjectRandom_ReturnsRandomNineDigitNumber()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.GenerateRandomnumber(new Random());

            //Assert
            Assert.True(vrijednost.ToString().Length == 9);
        }

        [Fact]
        public void CheckTableFormat_GivenColumnCountNotEqualSix_ReturnsFalse()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.CheckTableFormat("test", 0, 10);

            //Assert
            Assert.False(vrijednost);
        }

        [Fact]
        public void CheckTableFormat_GivenFirstColumnNameEqualId_ReturnsTrue()
        {
            //Arrange
            var servis = new ImportStavkeIzdatniceServices();

            //Act
            var vrijednost = servis.CheckTableFormat("Id", 0, 6);

            //Assert
            Assert.True(vrijednost);
        }
    }
}
