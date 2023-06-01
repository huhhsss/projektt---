using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt____.Properties
{
    internal class Wiekszawalkalvl1
    {
        static public void Innawalka(double[] stats, string[] itemyxd)
        {

            if (itemyxd.Contains("ruzczka"))
            {
                if (stats[0] > 0 && stats[1] > 0)
                {
                    Random random = new Random();
                    stats[1] = stats[1] - random.Next(15, 25);
                    stats[0] = stats[0] - stats[2];
                    Console.WriteLine(stats[1]);
                }
                else if (stats[0] > 0 && stats[1] <= 0)
                {
                    Console.WriteLine("wygrales");

                }
                else if (stats[0] <= 0 && stats[1] >= 0)
                {
                    Console.WriteLine("przegrales");
                }
            }
            else
            {
                Console.WriteLine("nie mozesz wykonac tego ataku");


            }


        }
    }
}
