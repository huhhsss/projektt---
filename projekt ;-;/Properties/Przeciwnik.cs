using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt____.Properties
{
    internal class Przeciwnik
    {
        static public void przeciwnikgenerator(double[] stats)
        {
            Random random = new Random();
            stats[1] = random.Next(50, 100);
            Console.WriteLine($"przeciwnik ma {stats[1]} hp");
            stats[2] = random.Next(5, 10);
        }

    }
}
