using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2
{

    class program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Jouer(Personnage monPerso)
        {
            Sauvage PokemonSauvage = new Sauvage("Roucool");
            bool victoire = true;
            bool suivant = false;

            while (!PokemonSauvage.EstMort())
            {
                //Tour du monstre
                PokemonSauvage.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if(monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                //tour du poke
                monPerso.Attaquer(PokemonSauvage);
                Console.WriteLine();
                Console.ReadKey(true);

            }

            if(victoire)
            {
                monPerso.gagnerExperience(10);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteritiques());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Un nouveau pokemon sauvage apparait, voulez - vous fuire ? (O/N)");
                    string saisie = Console.ReadLine().ToUpper();
                    if(saisie == "N")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if(saisie == "O")
                    {
                        Environment.Exit(0);
                    }

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("T'es mort");
                Console.ReadKey();
            }

        }


        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pokemenf");
            Console.WriteLine();
            Console.WriteLine("Choisie ton pokemon de départ :");
            Console.WriteLine("1. Salameche");
            Console.WriteLine("2. Bulbizarre");
            Console.WriteLine("3. Carapute");
            Console.WriteLine("4. Quittez");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Salameche ");
                    Console.WriteLine();
                    Jouer(new Salameche("Pokemon"));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Bulbizarre ");
                    Console.WriteLine();
                    Jouer(new Bulbizarre("Pokemon"));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Carapute ");
                    Console.WriteLine();
                    Jouer(new Carapute("Pokemon"));
                    break;
                case "4":
                    break;
                       

            }


        }




    }








}
