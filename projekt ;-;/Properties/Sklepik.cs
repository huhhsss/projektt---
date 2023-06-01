using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt____.Properties
{
    internal class Sklepik
    {
        static public void sklepik(double[] stats, string[] itemyxd)
        {
            Console.WriteLine($"Co cchesz kupić? Masz {stats[3]} coinów");

            Console.WriteLine(" 1 - ruzdzka, 2 - gwiazdki, 3 - koń, 4 - supertajemniczyitem");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                if (!itemyxd.Contains("ruzdzka") && stats[3] >= 20)
                {
                    itemyxd[0] = "ruzdzka";
                    stats[3] = stats[3] - 20;

                }
                else if (itemyxd.Contains("ruzdzka"))
                {
                    Console.WriteLine("masz juz ruzdzke");
                }
                else if (stats[3] < 20)
                {
                    Console.WriteLine("nie masz na to denarow");
                }
            }
            else if (x == 2)
            {
                if (!itemyxd.Contains("gwiazdka") && stats[3] >= 10)
                {
                    itemyxd[1] = "gwiazdka";
                    stats[3] = stats[3] - 10;
                }
                else if (itemyxd.Contains("gwiazdka") && stats[3] >= 10)
                {
                    itemyxd[1] = "2 gwiazdka";
                    stats[3] = stats[3] - 10;
                }
                else if (itemyxd.Contains("2 gwiazdka") && stats[3] >= 10)
                {
                    itemyxd[1] = "3 gwiazdka";
                    stats[3] = stats[3] - 10;
                }
                else if (stats[3] < 10)
                {
                    Console.WriteLine("nie stac cie nagwiazdka");
                }
                else if (itemyxd.Contains("3 gwiazdka"))
                {
                    Console.WriteLine("masz maksymalna ilosc gwiazek");
                }
            }

            if (x == 3)
            {
                if (!itemyxd.Contains("kon") && stats[3] >= 50)
                {
                    itemyxd[2] = "kon";
                    stats[3] = stats[3] - 50;
                }
                else if (itemyxd.Contains("kon"))
                {
                    Console.WriteLine("masz juz konia");
                }
                else if (stats[3] < 50)
                {
                    Console.WriteLine("nie masz na niego denarow");
                }
            }

            if (x == 4)
            {
                if (!itemyxd.Contains("supertajemniczyitem") && stats[3] >= 40)
                {
                    itemyxd[3] = "supertajemniczyitem";
                    stats[3] = stats[3] - 40;
                }
                else if (itemyxd.Contains("supertajemniczyitem"))
                {
                    Console.WriteLine("masz juz supertajemniczyitem");
                }
                else if (stats[3] < 40)
                {
                    Console.WriteLine("nie masz na niego denarow");
                }
            }


        }

    }
}