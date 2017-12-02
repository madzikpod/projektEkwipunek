using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public abstract class Postac
    {
        public Postac(string imie, int level)
        {
            Imie = imie;
            Level = level;
            Id = Guid.NewGuid();
            Ekwipenek = new List<Przedmiot>();

        }
        public Guid Id { get; private set; }
        public string Imie { get; private set; }
        public int Level { get; private set; }
        public double Moc { get; protected set; }
        public double Obrona { get; protected set; }
        public double Udzwig { get; protected set; }
        public double Inteligencja { get; protected set; }
        public string Opis { get; protected set; }
        public double Obciazenie { get; private set; }
        public List<Przedmiot> Ekwipenek { get; private set; }
        public bool DodajPrzedmiotDoEkwipunku(Przedmiot przedmiot)
        {
            if (Ekwipenek.Find(przedmiotWEkwipunku => { return przedmiotWEkwipunku.Id == przedmiot.Id; }) != null)
            {
                return false;
                // TodDo przerobic na rzucanie wyjatkow
            }
            if (Udzwig < Obciazenie + przedmiot.Waga)
            {
                return false;
            }
            Obciazenie += przedmiot.Waga;
            Ekwipenek.Add(przedmiot);

            return true;
        }
        public bool UsunPrzedmiotDoEkwipunku(Przedmiot przedmiot)
        {
            if (Ekwipenek.Find(przedmiotWEkwipunku => { return przedmiotWEkwipunku.Id == przedmiot.Id; }) == null)
            {
                return false;
            }
            Obciazenie -= przedmiot.Waga;
            Ekwipenek.Remove(przedmiot);

            return true;
        }
        protected void LevelUp(int level)
        {
            if (level > 1)
            {
                Moc = Moc + .05 * Moc * level;
                Obrona = Obrona + .05 * Obrona * level;
                Udzwig = Udzwig + .05 * Udzwig * level;
            }

        }
    }

}
