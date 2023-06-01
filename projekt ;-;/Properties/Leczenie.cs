using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt____.Properties
{
    internal class Leczenie
    {
        public static void leczenie(double[] stats, string[] itemyxd)
        {
            if (stats[0] < 100 && itemyxd.Contains("supertajemniczyitem"))
            {
                if (stats[0] + 1 / 2 * stats[0] < 100)
                {
                    stats[0] = stats[0] + 1 / 2 * stats[0];
                    Console.WriteLine("Pradawne siły cię uleczyły");
                }
                else if (stats[0] + 1 / 2 * stats[0] > 100)
                {
                    stats[0] = 100;
                    Console.WriteLine("Pradawne siły cię uleczyły");
                }
            }
            else if (!itemyxd.Contains("supertajemniczyitem"))
            {
                Console.WriteLine("Nie posiadasz supertajemniczegoitemu");
            }
            else if (stats[0] == 100)
            {
                Console.WriteLine("Masz full hp");
            }
        }
    }
}
