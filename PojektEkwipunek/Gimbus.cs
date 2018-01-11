using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class Gimbus : Postac
    {
        public Gimbus(string imie, int level) : base(imie, level)
        {
            Klasa = new KlasaPostaci
            {
                Typ = TypPostaci.Gimbus,
                Obrona=10,
                Udzwig=10,
                Moc=10,
                Opis="Gotowy na apoklaipse zombie, ale nie na jutrzejsza klasowke z matmy. Zazwyczaj przebywa w stadach \"Pale wtedy gdy sie deneruje, zazwyczaj przed sprawdzianem z przyry\""
            };

            Moc = 10;
            Obrona = 10;
            Inteligencja = 10;
            Udzwig = 30;
            LevelUp(level);
        }
        
    }
}
