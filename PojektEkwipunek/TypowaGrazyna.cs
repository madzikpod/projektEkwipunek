using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojektEkwipunek
{
    public class TypowaGrazyna : Postac
    {
        public TypowaGrazyna(string imie, int level) : base(imie, level)
        {
            
            Moc = 10;
            Obrona = 10;
            Udzwig = 30;
            LevelUp(level);
        }
        protected override void LevelUp(int level)
        {
            Moc += level;
        }
    }
}
