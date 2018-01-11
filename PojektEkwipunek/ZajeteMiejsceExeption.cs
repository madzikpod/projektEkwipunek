using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektEkwipunek
{
    public class ZajeteMiejsceExeption:Exception
    {
        public ZajeteMiejsceExeption(string message) : base(message)
        {

        }
    }
}
