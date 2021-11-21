using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat_de_Vanzari
{
    class Program
    {
        static void livrare_rest(string proprietate)
        {
            string verificare = proprietate.Substring(0, 1);
            if (verificare == "1")
                Console.WriteLine("Livrare marfa...");
            verificare = proprietate.Substring(1, 1);
            if (verificare == "1")
                Console.WriteLine("Returnare nickel...");
            verificare = proprietate.Substring(2, 1);
            if (verificare == "1")
                Console.WriteLine("Returnare dime...");
        }
        static void stareaA(string propietate) // aparatul are 0 centi;
        {
            livrare_rest(propietate); 
            string raspuns;
            Console.WriteLine("Doriti sa mai bagati monede? (Scrieti y pentru da si n pentru nu): ");
            raspuns = Console.ReadLine();

            if (raspuns == "y" || raspuns == "Y")
            {
                Console.WriteLine("Introduceti moneda: "); //nickel= 5, dime = 10; quarter = 25;
                raspuns = Console.ReadLine();

                switch (raspuns)
                {
                    case "n":
                    case "N":
                        stareaB("000");
                        break;
                    case "d":
                    case "D":
                        stareaC("000");
                        break;
                    case "q":
                    case "Q":
                        stareaA("110");
                        break;
                    default:
                        Console.WriteLine("Nu ati introdus o moneda valida. Va rugam incercati din nou. ");
                        break;
                }

            }
            else if (raspuns == "n" || raspuns == "N")
                Console.WriteLine("Aparatul se va inchide...");
            else
                Console.WriteLine("Eroare: Nu ati introdus o comanda reala");
        }

        static void stareaB(string propietate) // aparatul are 5 centi;
        {
            livrare_rest(propietate);
            string raspuns;
            Console.WriteLine("Doriti sa mai bagati monede? (Scrieti y pentru da si n pentru nu): ");
            raspuns = Console.ReadLine();

            if (raspuns == "y" || raspuns == "Y")
            {
                Console.WriteLine("Introduceti moneda: ");
                raspuns = Console.ReadLine();

                switch (raspuns)
                {
                    case "n":
                    case "N":
                        stareaC("000");
                        break;
                    case "d":
                    case "D":
                        stareaD("000");
                        break;
                    case "q":
                    case "Q":
                        stareaA("101");
                        break;
                    default:
                        Console.WriteLine("Nu ati introdus o moneda valida. Va rugam incercati din nou. ");
                        break;
                }

            }
            else if (raspuns == "n" || raspuns == "N")
                Console.WriteLine("Aparatul se va inchide...");
            else
                Console.WriteLine("Eroare: Nu ati introdus o comanda reala");
        }

        static void stareaC(string propietate) // aparatul are 10 centi;
        {
            livrare_rest(propietate);
            string raspuns;
            Console.WriteLine("Doriti sa mai bagati monede? (Scrieti y pentru da si n pentru nu): ");
            raspuns = Console.ReadLine();

            if (raspuns == "y" || raspuns == "Y")
            {
                Console.WriteLine("Introduceti moneda: ");
                raspuns = Console.ReadLine();

                switch (raspuns)
                {
                    case "n":
                    case "N":
                        stareaD("000");
                        break;
                    case "d":
                    case "D":
                        stareaA("100");
                        break;
                    case "q":
                    case "Q":
                        stareaA("111");
                        break;
                    default:
                        Console.WriteLine("Nu ati introdus o moneda valida. Va rugam incercati din nou. ");
                        break;
                }

            }
            else if (raspuns == "n" || raspuns == "N")
                Console.WriteLine("Aparatul se va inchide...");
            else
                Console.WriteLine("Eroare: Nu ati introdus o comanda reala");
        }

        static void stareaD(string propietate) // aparatul are 15 centi;
        {
            livrare_rest(propietate);
            string raspuns;
            Console.WriteLine("Doriti sa mai bagati monede? (Scrieti y pentru da si n pentru nu): ");
            raspuns = Console.ReadLine();

            if (raspuns == "y" || raspuns == "Y")
            {
                Console.WriteLine("Introduceti moneda: ");
                raspuns = Console.ReadLine();

                switch (raspuns)
                {
                    case "n":
                    case "N":
                        stareaA("100");
                        break;
                    case "d":
                    case "D":
                        stareaA("110");
                        break;
                    case "q":
                    case "Q":
                        stareaB("111");
                        break;
                    default:
                        Console.WriteLine("Nu ati introdus o moneda valida. Va rugam incercati din nou. ");
                        break;
                }

            }
            else if (raspuns == "n" || raspuns == "N")
                Console.WriteLine("Aparatul se va inchide...");
            else
                Console.WriteLine("Eroare: Nu ati introdus o comanda reala");
        }
        static void Main(string[] args)
        {
            stareaA("000"); // la inceput aparatul are 0 centi si nu livreaza nimica;
        }
    }
}
