using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class Sebix : Postac
    {
        public Sebix(string imie, int level) : base(imie, level)
        {
            Klasa = new KlasaPostaci
            {
                Typ = TypPostaci.Sebix,
                Moc = 14,
                Obrona = 10,
                Udzwig = 60,
                Opis = "Przepotezny wladca osiedla, łatwy do rozpoznaia po czapce i dresie"
            };

            Moc = 14;
            Obrona = 10;
            Inteligencja = 6;
            Udzwig = 60;
            LevelUp(level);
        }
    }
}
