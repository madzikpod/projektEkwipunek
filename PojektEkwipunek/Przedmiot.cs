using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojektEkwipunek
{
    public class Przedmiot
    {
        public Przedmiot()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Opis { get; set; }
        public string Typ { get; set; }
        public double Waga { get; set; }
        //wymagania
        //właściwości
    }
}
