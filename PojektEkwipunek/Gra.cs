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
                wymagania: new Dictionary<StatystykiPostaci, double>{ [StatystykiPostaci.Inteligencja] = 1, [StatystykiPostaci.Moc] = 2 } )
                
        };
    }
}
