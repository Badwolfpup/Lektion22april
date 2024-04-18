using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion22april
{
    public static class BeräknaAntalDagar
    {
        static int månad = 1;
        static int veckodag = 1;


        public static ObservableCollection<Dag> GenereraDagarIMånad()
        {
            ObservableCollection<Dag> dag = new ObservableCollection<Dag>();
            if (veckodag > 1)
            {
                for (int j = AntalDagPerMånad(månad - 1) - (veckodag - 1); j <= AntalDagPerMånad(månad - 1); j++)
                {
                    dag.Add(new Dag(j));
                }
            }
            for (int k = 1; k <= AntalDagPerMånad(månad); k++)
            {
                dag.Add(new Dag(k));
            }
            veckodag = (dag.Count() % 7) + 1;
            månad++;
            return dag;
        }

        private static int AntalDagPerMånad(int månad)
        {
            if (new[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(månad)) return 31;
            else if (new[] { 4, 6, 9, 11 }.Contains(månad)) return 30;
            else
            {
                if (DateTime.Now.Year % 4 == 0) return 29;
                else return 28;
            }

        }
    }
}
