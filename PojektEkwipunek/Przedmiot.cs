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
            this.Bonusy = new List<Bonus>();
            this.Wlasciwosci = new List<string>();
            this.Wymagania = new Dictionary<StatystykiPostaci, double>();
        }

        public Przedmiot(TypPrzedmiotu typ, string nazwa, double waga, List<Bonus> bonusy, List<string> wlasciwosci,
            KtoMozeNosic ograniczenieKlasowe = KtoMozeNosic.Wszyscy,
            Dictionary<StatystykiPostaci, double> wymagania = null) : this(typ, nazwa, waga)
        {
            this.Bonusy = bonusy;
            this.Wlasciwosci = wlasciwosci;
            this.OgraniczeniaKlasowe = ograniczenieKlasowe;
            if (wymagania != null)
            {
                Wymagania = wymagania;
            }

        }
        public Guid Id { get; private set; }
        public string Opis { get; set; }
        public TypPrzedmiotu Typ { get; private set; }
        public double Waga { get; private set; }
        public string Nazwa { get; private set; }
        //wymagania co potrzeba aby zalozyc
        public Dictionary<StatystykiPostaci, double> Wymagania { get; private set; }
        //właściwości ile i co zwiekszy przedmiot
        public List<string> Wlasciwosci { get; set; }
        public List<Bonus> Bonusy { get; private set; }
        public KtoMozeNosic OgraniczeniaKlasowe { get;  set; }

    }

    public enum TypPrzedmiotu
    {
        Bron, Stroj, Buty, NakrycieGlowy
    }
    [Flags]
    public enum KtoMozeNosic
    {
        Wszyscy = 0,
        Janusz = 1,
        Grazyna = 2,
        Sebix = 4,
        Gimbus = 8
    }

}
