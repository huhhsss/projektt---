using projekt____.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projekt____
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //dane szystkie
            string[] itemyxd = { " ", " ", " ", " " };
            double[] stats = { 100, 100, 20, 30 };
            // 0 - hp, 1 -  enemyhp, 2 - damage, 3 - coins


            Console.WriteLine("Czy chcesz zaczać?");
            int decyzja = int.Parse(Console.ReadLine());


            if (decyzja == 1)
            {
                Console.WriteLine("Hej, wybierz swoj pseudonim");
                string imie = Console.ReadLine();
                

                Console.WriteLine("Dawno dawno temu był sobie rycerz. Pewnego razu w zamku w ktorym mieszkal pojawiły się demony. Pomoz mu zwalczyc zle duchy i uciec z zamku.");



                Console.WriteLine("=========================================");
                Console.WriteLine("=============LEVEL 1 : ZAMEK=============");
                Console.WriteLine("=========================================");

                Console.WriteLine("Twoje statystyki:");
                Console.WriteLine($"hp {stats[0]}, denary {stats[3]}");
                Console.WriteLine("Itemy = brak");


                Console.WriteLine("Co chcesz teraz zrobić?       1 - walka        2 - sklep");

                int decyzja2 = int.Parse(Console.ReadLine());
                if (decyzja2 == 1)
                {
                    Console.WriteLine("Dzielny rycerz postanowil walczyc z demonami");
                    Przeciwnik.przeciwnikgenerator(stats);
                    Console.WriteLine("Walczysz teraz z przeciwnikiem");
                    while (stats[1] > 0 && stats[0] > 0)
                    {
                        Console.WriteLine("jak chcesz walczyc");
                        int decyzja3 = int.Parse(Console.ReadLine());

                        if (decyzja3 == 1)
                        {
                            Walkalvl1.Walka1lmao(stats);
                            decyzja3 = 0;
                        }
                        else if (decyzja3 == 2)
                        {
                            Wiekszawalkalvl1.Innawalka(stats, itemyxd);
                            decyzja3 = 0;

                        }

                    }


                    if (stats[0] > 0)
                    {

                        Console.WriteLine("wygrales");
                        Console.WriteLine($"Twoje hp {stats[0]}");
                        stats[3] = stats[3] + 50;
                        Console.WriteLine("Czy chcesz się uleczyć?");
                        int decyzja10 = int.Parse(Console.ReadLine());
                        if (decyzja10 == 1)
                        {
                            Leczenie.leczenie(stats, itemyxd);
                        }
                    }



                    Console.WriteLine("Rycerz poruszał się i poruszał kolejnymi korytarzami, dazac do wyjscia. Napotkal kolejnego ducha");
                    Console.WriteLine("Podejmij decyzje: Rucerz walczy - 1, rycerz wieje - 2");
                    int decyzja4 = int.Parse(Console.ReadLine());

                    if (decyzja4 == 1)
                    {
                        Console.WriteLine("cos");
                        Przeciwnik.przeciwnikgenerator(stats);
                        Console.WriteLine("Walczysz teraz z przeciwnikiem");
                        while (stats[1] > 0 && stats[0] > 0)
                        {
                            Console.WriteLine("jak chcesz walczyc");
                            int decyzja5 = int.Parse(Console.ReadLine());

                            if (decyzja5 == 1)
                            {
                                Walkalvl1.Walka1lmao(stats);
                                decyzja5 = 0;
                            }
                            else if (decyzja5 == 2)
                            {
                                Wiekszawalkalvl1.Innawalka(stats, itemyxd);
                                decyzja5 = 0;

                            }

                        }
                        if (stats[0] > 0)
                        {
                            Console.WriteLine("wygrales");
                            Console.WriteLine(stats[0]);
                            Console.WriteLine(stats[0]);
                            stats[3] = stats[3] + 50;
                            Console.WriteLine("Czy chcesz się uleczyć?");
                            int decyzja10 = int.Parse(Console.ReadLine());
                            if ( decyzja10 == 1)
                            {
                                Leczenie.leczenie(stats, itemyxd);
                            }
                        }

                    }
                    else if (decyzja4 == 2)
                    {
                        Console.WriteLine("Rycerz zwial, koniec gry");
                    }

                    Console.WriteLine("Rycerzowi udało się pokonac lvl zamek, potrzebujesz 200 denarow by przejsc na nastepny poziom, masz tyle? czy idziesz walczyc");
                    Console.WriteLine($"Twoje denary = {itemyxd[3]}");

                    int decyzja7 = int.Parse(Console.ReadLine());

                    if (decyzja7 == 1)
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine("=============LEVEL 1 : PODROZ============");
                        Console.WriteLine("=========================================");

                        Console.WriteLine("c.d.n");
                    }

                    else if (decyzja7 == 2)
                    {
                        int decyzja8 = 1;
                        while (decyzja8 == 1)
                        {
                            Przeciwnik.przeciwnikgenerator(stats);
                            Console.WriteLine("Walczysz teraz z przeciwnikiem");
                            while (stats[1] > 0 && stats[0] > 0)
                            {
                                Console.WriteLine("jak chcesz walczyc");
                                int decyzja9 = int.Parse(Console.ReadLine());

                                if (decyzja9 == 1)
                                {
                                    Walkalvl1.Walka1lmao(stats);
                                    decyzja9 = 0;
                                }
                                else if (decyzja9 == 2)
                                {
                                    Wiekszawalkalvl1.Innawalka(stats, itemyxd);
                                    decyzja9 = 0;

                                }
                                if (stats[0] > 0)
                                {
                                    Console.WriteLine("wygrales");
                                    Console.WriteLine(stats[0]);
                                    Console.WriteLine(stats[0]);
                                    stats[3] = stats[3] + 50;
                                    decyzja8 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Czy chcesz dalej walczyc dla zabawy?");

                                }

                            }
                            if ( decyzja8 == 2)
                            {
                                Console.WriteLine("KONIECGRY przemoc to nie rozwiazanie");
                            }

                        }

                    }
                    else if (decyzja2 == 2)
                    {
                        int decyzja6 = 1;

                        while (decyzja6 == 1)
                        {

                            Sklepik.sklepik(stats, itemyxd);
                            Console.WriteLine($"Twoje itemy:{itemyxd[0]}, {itemyxd[1]}, {itemyxd[2]}, {itemyxd[3]}");
                            decyzja6 = 0;
                            decyzja6 = int.Parse(Console.ReadLine());
                        }







                    }

                    Console.ReadKey();


                    // 0 - hp, 1 -  enemyhp, 2 - damage, 3 - coins

                }



            }


        }


    }


}