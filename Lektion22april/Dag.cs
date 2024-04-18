using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion22april
{
    public class Dag
    {
        public int Dagen { get; set; }

        public ObservableCollection<Möte> Möten { get; set; }

        public Dag(int dagen)
        {
            Möten = new ObservableCollection<Möte>();
            Dagen = dagen;
        }
    }
}
