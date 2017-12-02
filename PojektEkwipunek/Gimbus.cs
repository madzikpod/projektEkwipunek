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
            Moc = 10;
            Obrona = 10;
            Inteligencja = 10;
            Udzwig = 30;
            LevelUp(level);
        }
        
    }
}
