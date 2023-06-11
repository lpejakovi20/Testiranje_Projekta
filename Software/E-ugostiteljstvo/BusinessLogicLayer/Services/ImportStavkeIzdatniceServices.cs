using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using IronXL;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogicLayer.Services
{
    public class ImportStavkeIzdatniceServices
    {
        public List<string[]> ParsirajExcelDatoteku(string filePath)
        {
            List<string[]> podaci = new List<string[]>();

            WorkBook workbook = WorkBook.Load(filePath);

            WorkSheet worksheet = workbook.WorkSheets[0];

            int rowCount = worksheet.Rows.Length;
            int colCount = worksheet.Columns.Length;


            for (int row = 1; row < rowCount; row++)
            {
                string[] rowData = new string[colCount];

                for (int col = 0; col < colCount; col++)
                {
                    var cell = worksheet.GetCellAt(row, col);
                    if(cell != null)
                    {
                        string cellValue = cell.StringValue;

                        if (row == 1 && !CheckTableFormat(worksheet.GetCellAt(0, col).StringValue, col, colCount)) return null;

                        if (!CheckTypeOfValuesInRow(cellValue, col)) return null;
                        else rowData[col] = cellValue;
                    }
                }

                podaci.Add(rowData);
            }

            workbook.Close();

            return podaci;

        }

        public bool CheckTypeOfValuesInRow(string value, int col)
        {
            if (col == 0 && !int.TryParse(value, out _)) return false;
            else if (col == 5 && !DateTime.TryParse(value, out _)) return false;
            else return true;
        }

        public bool CheckTableFormat(string value, int col, int colCount)
        {
            if (colCount != 6) return false;
           
            Dictionary<int, string> expectedValues = new Dictionary<int, string>()
            {
                { 0, "Id" },
                { 1, "Naziv" },
                { 2, "Vrsta" },
                { 3, "Kolicina" },
                { 4, "MjernaJedinica" },
                { 5, "Rok_Trajanja" }
            };

            return expectedValues.ContainsKey(col) && expectedValues[col] == value;
        }

        public List<StavkaIzdatnice> CreateStavkeIzdatnice(List<string[]> parsedData)
        {
            List<StavkaIzdatnice> stavke = new List<StavkaIzdatnice>();

            Random random = new Random();
            foreach (var row in parsedData)
            {
                int id = int.Parse(row[0]);
                string naziv = row[1];
                string vrsta = row[2];
                int kolicina = int.Parse(row[3]);
                string mjernaJedinica = row[4];
                DateTime rokTrajanja = DateTime.Parse(row[5]);
                StavkaIzdatnice stavka = new StavkaIzdatnice(id, naziv, vrsta, kolicina, mjernaJedinica, rokTrajanja, GenerateRandomnumber(random));
                stavke.Add(stavka);
            }

            return stavke;
        }

        public List<StavkaIzdatnice> KeepOnlyValidOnes(List<StavkaIzdatnice> stavke)
        {
            var lista = new List<StavkaIzdatnice>();
            NamirnicaServices service = new NamirnicaServices(new NamirnicaRepository());
            foreach(var stavka in stavke)
            {
                var namirnica = service.GetNamirnicaByRokTrajanja(stavka.Rok_trajanja, stavka.Id);

                if (namirnica == null) { }
                else if (namirnica.kolicina >= stavka.Kolicina && namirnica.rok >= DateTime.Today)
                {
                    lista.Add(stavka);
                }
            }
            return lista;
        }

        public int GenerateRandomnumber(Random random)
        {
            return random.Next(100000000, 999999999);
        }
    }
}
