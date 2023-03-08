**(ERASMUS students please see the english version (README_ENG.md) of this document)**

# Inicijalne upute za prijavu 1. projekta iz kolegija Testiranje i kvaliteta programskih proizvoda

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Testiranje i kvaliteta programskih proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, testova, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod i testove je potrebno verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Povratnu informaciju na samu prijavu tima i projekta, kao i na završnu predaju ćete od nastavnika dobiti kroz sekciju Discussions (također dostupnu na GitHubu vašeg projekta). A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# E-ugostiteljstvo(Testiranje)


## Model rada na projektu
 Nastavak rada na projektu iz kolegija "Razvoj Programskih Proizvoda"

## Opis projekta

### Tema
Sustav za upravljanje količinom namirnica u ugostiteljstvu
### Domena
U ugostiteljstvu dolazi do problema organizacije narmirnica. Glavni kuhari često moraju voditi računa o količini namirnica na skladištu i ponekad im je teško procjeniti koliko namirnica troše i koju količinu namirnica trebaju naručiti. Zbog toga dolazi do bacanja hrane zbog prevelikih narudžba ili nedostatka namirnica za kuhanje jela. Zbog tih problema odlučili smo ugostiteljima olakšati proces nabave i upravljanja količinom namirnica.

Projekt je iniciajalno započet na kolegiju "Razvoj Programskih Proizvoda".

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Matej Ritoša | mritosa20@student.foi.hr | 0016150816 | mritosa
Nikola Parag | nparag20@student.foi.hr | 0035217959 | nparag20
Lovro Pejaković | lpejakovi20@student.foi.hr | 0016150223 | lpejakovi20
## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login i Registracija | Za pristup sustavu potrebna je registracija korisnika u sustav i njegova prijava. Prijava će biti omoguće pomoću skeniranja lica. | Matej Ritoša
F02 | Unos u katalog namirnica | Korisnik će imati mogućnost unošenja tj, kreiranja namirnica. Svaka namirnica će imati vlasiti generirani QR kod s kojim će se pratiti kretanje namirnice u ugostiteljskom objektu. | Nikola Parag
F03 | Pregled namirnica | Korisnicima će biti omogućeno pretraživanje, sortiranje i filtriranje po različitim kriterijima sve namirnice na skladištu. | Nikola Parag
F04 | Kreiranje narudžbenice | Korisnicima će biti omogućeno dodavanje, brisanje, i izmjena količine namirnica u narudžbenici. Narudžbenica će se moći kreirati ručno (ručnim dodavanjem stavku po stavku) ili automatski (softver prepoznaje koji artikli su pali ispod minimalnih zaliha i kreiraju stavke sa količinama dostatnim da se dođe do optimalne količine). | Matej Ritoša
F05 | Unos potrošenih namirnica | Korisnicima će biti omogućeno izdavanje namirnica u kuhinji(pri tome se generira i ispisuje dokument izdatnica). Namirnice se dodaju u stavke izdatnice korištenjem QR koda na namirnici.  | Lovro Pejaković
F06 | Pregled narudžbenica | Korisnici koji će biti prijavljeni s ulogom računovodstva će imati mogućnost pretraživanja, sortiranja i filtriranja po različitim kriterijima sve narudžbenice. Uz to biti će omogućen prikaz detalja pojedine narudžbenice te njen ispis u obliku PDF dokumenta. | Matej Ritoša
F07 | Generiranje izvještaja namirnica kojima se bliži rok trajanja | Korisnici koji će biti prijavljeni s ulogom računovodstva  imati će mogućnost generiranja i ispis izvještaja sa popisom namirnica kojima se bliži rok uporabe. | Nikola Parag
F08 | Izrada primke | Korisnici koji će biti prijavljeni s ulogom računovodstva imati mogućnost mogućnost zaprimanja namirnica na temelju izrađene narudžbenice. Sa narudžbenice se automatski dodaju stavke na primku. | Lovro Pejaković
F09 | Statistika iskorištenosti namirnica  | Sustav će računovodstvu omogućiti kreirati statistički izvještaj o iskorištenosti namirnica tokom svakog mjeseca u tekućoj godini te prikaz namirnica kojima je prošao rok. | Lovro Pejaković

## Tehnologije i oprema
Visual studio Code 2022, Visual Paradigm, Figma, Github...
