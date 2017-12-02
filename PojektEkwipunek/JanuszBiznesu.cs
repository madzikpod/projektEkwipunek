using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class JanuszBiznesu : Postac
    {
        public JanuszBiznesu(string imie, int level) : base(imie, level)
        {

            Moc = 10;
            Obrona = 8;
            Inteligencja = 12;
            Udzwig = 40;
            LevelUp(level);
        }
        
    }
}
