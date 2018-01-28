using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public static class Gra
    {
        public static List<Postac> ListaPostaci = new List<Postac>() {
            new TypowaGrazyna("Halina",11),
            new JanuszBiznesu("Janusz",5),
            new Sebix("Mateusz", 17),
            new Gimbus("Arek",1)
        };
        public static List<Przedmiot> ListaPrzedmiotow = new List<Przedmiot>()
        {
            new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "trwała", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "Odstrasza mole ", "Powoduje losowe salwy śmiechu" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } ),

            new Przedmiot(TypPrzedmiotu.Buty, "airmaxy", 1.0,
                new List<Bonus>{ new Bonus{DoCzego = StatystykiPostaci.Obrona, Premia = 3} },
                new List<string>(){ "Bieganie Cie nie meczy, chyba że po 3 piwach"},
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Moc]=2 },ograniczenieKlasowe: KtoMozeNosic.Gimbus),

            new Przedmiot(TypPrzedmiotu.Buty, "najeczki", 1.0,
                new List<Bonus>{ new Bonus{DoCzego = StatystykiPostaci.Obrona, Premia = 4},
                new Bonus{ DoCzego = StatystykiPostaci.Moc, Premia= 3} },
                new List<string>(){ "Lepsze niz airmaxy"},
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Moc]=2 }),

            new Przedmiot(TypPrzedmiotu.NakrycieGlowy, "Czapka z daszkiem", 1.0,
                new List<Bonus>{ new Bonus{DoCzego = StatystykiPostaci.Obrona, Premia = 4} },
                new List<string>(){ "Strach sie bac"},
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Moc]=2 },ograniczenieKlasowe : KtoMozeNosic.Sebix),

            new Przedmiot(TypPrzedmiotu.Stroj, "koszula na krotki rekaw", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "Kupiona w Tesco", "Tandetna" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 },ograniczenieKlasowe : KtoMozeNosic.Janusz ),

            new Przedmiot(TypPrzedmiotu.Stroj, "dres", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "sieje postrach", "szajni, 3 paski" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } ),

            new Przedmiot(TypPrzedmiotu.Bron, "walek", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "nigdy sie nie lamie ", "twardszy od golowy Janusza" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } ),

            new Przedmiot(TypPrzedmiotu.Bron, "pilot", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "Kto ma pilot ten ma włdze", "umie zmieniac kanał u sąsiadów" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } ),

            new Przedmiot(TypPrzedmiotu.Bron, "bumbox", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "głośno gra", "Powoduje raka sluchu" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 },ograniczenieKlasowe : KtoMozeNosic.Gimbus ),

            new Przedmiot(TypPrzedmiotu.Bron, "browarek", 0.5,
                new List<Bonus> { new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = 2 } },
                new List<string>(){ "chłodne najlepsze", "Powoduje zawroty głowy, po duzej ilości","z rana wchodzi jak śmietana" },
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } ),


        };
    }
}
