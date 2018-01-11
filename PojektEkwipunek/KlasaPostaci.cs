using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class KlasaPostaci
    {
        public KlasaPostaci()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Opis { get; set; }
        public double Moc { get; set; }
        public double Obrona { get; set; }
        public double Udzwig { get; set; }
        public TypPostaci Typ { get; set; }
    }
}
