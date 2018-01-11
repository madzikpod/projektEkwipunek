using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class TypowaGrazyna : Postac
    {
        public TypowaGrazyna(string imie, int level) : base(imie, level)
        {
            Klasa = new KlasaPostaci
            {
                Typ = TypPostaci.TypowaGrazyna,
                Moc = 8,
                Obrona = 8,
                Udzwig = 20,
                Opis = "Czesto wystepuje na blokowskach \"No i gdzie mnie rwiesz te gałęź?!\" "
            };
            Moc = 8;
            Obrona = 8;
            Inteligencja = 14;
            Udzwig = 20;
            LevelUp(level);
        }

    }
}
