using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt____.Properties
{
    internal class Walkalvl1
    {
        static public void Walka1lmao(double[] stats)
        {
            if (stats[0] > 0 && stats[1] > 0)
            {
                Random random = new Random();
                stats[1] = stats[1] - random.Next(10, 15);
                stats[0] = stats[0] - stats[2];
                Console.WriteLine($"Twoj przeciwnik ma {stats[1]}");
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
    }
        





}