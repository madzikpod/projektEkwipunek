using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class Przedmiot
    {
        public Przedmiot(TypPrzedmiotu typ, string nazwa, double waga)
        {
            if (waga <= 0)
            {
                throw new ArgumentException("Waga musi byc powyzej zera");
            }
            if (string.IsNullOrEmpty(nazwa))
            {
                throw new ArgumentException("Wypelnij pole Nazwa poprawnie");
            }
            Id = Guid.NewGuid();
            this.Nazwa = nazwa;
            this.Waga = waga;
            this.Typ = typ;
        }
        public Guid Id { get; private set; }
        public string Opis { get; set; }
        public TypPrzedmiotu Typ { get; private set; }
        public double Waga { get; private set; }
        public string Nazwa { get; private set; }
        //wymagania
        //właściwości

    }

    public enum TypPrzedmiotu
    {
        Bron, Stroj, Buty, NakrycieGlowy
    }
}
