using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojektEkwipunek
{
    public class KlasaPostaci
    {
        public KlasaPostaci()
        {
             Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Opis { get; protected set; }
        public int Moc { get; protected set; }
        public int Obrona { get; protected set; }
        public double Udzwig { get; protected set; }
    }
}
