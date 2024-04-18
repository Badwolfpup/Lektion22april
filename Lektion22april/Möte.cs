using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion22april
{
    public class Möte
    {
        public string Titel { get; set; }
        public DateTime Datum { get; set; }

        public Möte(string titel, DateTime datum) 
        {
            Titel = titel;
            Datum = datum;
        }
    }
}
