using DataAccessLayer.Interfaces;
using EntitiesLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer_UnitTests.FakeRepository
{
    public class FakeNamirnicaRepository : INamirnicaRepository
    {
        public int Add(namirnica entity, bool saveChanges = true)
        {
            if(entity != null)
            {
                return 1;
            }
            else return 0;
        }

        public IQueryable<namirnica> GetNamirniceById(int id)
        {
            if (id < 1) {
                return null;
            }
            List<namirnica> listaNamirnica = new List<namirnica>();
            List<namirnica> praznaLista=new List<namirnica>();
            var novaNamirnica = new namirnica {
                id = 2,
                kolicina = 3,
                rok = DateTime.Now,
                namirnica_u_katalogu_id = 3
            };
            listaNamirnica.Add(novaNamirnica);
            IQueryable<namirnica> lista = listaNamirnica.AsQueryable().Take(1);
            if (novaNamirnica.namirnica_u_katalogu_id == id) {
                return lista;
            } else return praznaLista.AsQueryable();
        }

        public IQueryable<StavkaNarudzbenice> GetDostupneKolicineNamirnica()
        {
           
            List<StavkaNarudzbenice> listaNamirnica = new List<StavkaNarudzbenice>();
           
            var novaStavkaNarudzbencice = new StavkaNarudzbenice {
                Id = 2,
                Naziv = "Mlijeko",
                Vrsta = "Mliječni proizvod",
                Kolicina = 2,
                MjernaJedinica = "kg",
                Cijena = 2,
                Iznos =  4
            };
            listaNamirnica.Add(novaStavkaNarudzbencice);
            IQueryable<StavkaNarudzbenice> lista = listaNamirnica.AsQueryable().Take(1);
           
                return lista;
            
        }

        public IQueryable<StavkaIzvjestajaBlizuRoka> GetNamirniceBlizuRoka()
        {
            var lista = new List<StavkaIzvjestajaBlizuRoka>()
            {
                new StavkaIzvjestajaBlizuRoka(){id = 43,kolicina = 12, rok = DateTime.Today, naziv = "Banana"},
                new StavkaIzvjestajaBlizuRoka(){id = 44,kolicina = 12, rok = DateTime.Today, naziv = "Žele"},
                new StavkaIzvjestajaBlizuRoka(){id = 45,kolicina = 12, rok = DateTime.Today, naziv = "Parizer"}
            };
            IQueryable<StavkaIzvjestajaBlizuRoka> query = lista.AsQueryable();

            return query;
        }

        public IQueryable<namirnica> GetNamirniceByKatalogId(int namirnica_id)
        {
            var listaTocna = new List<namirnica>();
            var today = DateTime.Today;
            if(namirnica_id < 0)
            {
                IQueryable<namirnica> query1 = listaTocna.AsQueryable();
                return query1;
            }
            
            var lista = new List<namirnica>()
            {
                new namirnica(){id = 43,kolicina = 12, rok = DateTime.Today, namirnica_u_katalogu_id = 13},
                new namirnica(){id = 44,kolicina = 12, rok = DateTime.Today, namirnica_u_katalogu_id = 14},
                new namirnica(){id = 45,kolicina = 12, rok = DateTime.Today, namirnica_u_katalogu_id = 15}
            };
            foreach(var item in lista)
            {
                if (item.namirnica_u_katalogu_id == namirnica_id && item.rok >= today)
                {
                    listaTocna.Add(item);
                }
            }
            IQueryable<namirnica> query = listaTocna.AsQueryable();
            return query;
        }

        public IQueryable<dynamic> GetNamirniceIstecenogRoka()
        {
            List<dynamic> lista = new List<dynamic>();

            var nova = new
            {
                id = 10,
                naziv = "kruška",
                istekao_rok = DateTime.Now,
                vrsta = "voće",
                kolicina = "5",
                mjerna_jedinica = "kom",
                cijena = 10,
                iznos = 50
            };

            lista.Add(nova);

            IQueryable<dynamic> query = lista.AsQueryable().Take(1);

            return query;
        }

        public int Update(namirnica entity, bool saveChanges = true)
        {
            if (entity != null)
            {
                return 1;
            }
            else return 0;
        }

        public namirnica GetNamirnicaByRokTrajanja(DateTime rok, int id)
        {
            throw new NotImplementedException();
        }
    }
}
