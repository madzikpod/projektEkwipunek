using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    //właściwości ile i co zwiekszy przedmiot
    public class Bonus
    {
        public double Premia { get; set; }
        public StatystykiPostaci DoCzego { get; set; }
    }
    public enum StatystykiPostaci
    {
        Moc, Inteligencja, Obrona
    }
}
