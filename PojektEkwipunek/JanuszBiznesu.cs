using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class JanuszBiznesu : Postac
    {
        public JanuszBiznesu(string imie, int level) : base(imie, level)
        {
            Klasa = new KlasaPostaci
            {
                Typ = TypPostaci.JanuszBiznesu,
                Moc=10,
                Obrona=8,
                Udzwig=40,
                Opis="Janusz Biznesu sprzedaje auto \"To ma wiecej koni niz krzyzacy pod Grunwaldem\" "
            };
            Moc = 10;
            Obrona = 8;
            Inteligencja = 12;
            Udzwig = 40;
            LevelUp(level);
        }
        
    }
}
