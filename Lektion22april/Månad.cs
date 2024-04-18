using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion22april
{
    public class Månad
    {
        public string Namn { get; set; }

        public ObservableCollection<Dag> Dagar {  get; set; }  

        public Månad(string namn)
        {
            Dagar = BeräknaAntalDagar.GenereraDagarIMånad();
            Namn = namn;
        }
    }
}
