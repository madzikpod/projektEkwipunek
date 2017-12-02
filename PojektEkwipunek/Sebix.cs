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
            Moc = 14;
            Obrona = 10;
            Inteligencja = 6;
            Udzwig = 60;
            LevelUp(level);
        }
    }
}
