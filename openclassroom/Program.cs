using System;

namespace openclassroom
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            AfficherMenu();
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                {
                    Jeu1();
                    Console.WriteLine("Appuyez sur une touche pour retourner au Menu");
                    Console.ReadKey();
                    AfficherMenu();
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
                {
                    Jeu2();
                    Console.WriteLine("Appuyez sur une touche pour retourner au Menu");
                    Console.ReadKey();
                    AfficherMenu();
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Q)
                {
                    break;
                }
                else
                {
                    consoleKeyInfo = Console.ReadKey(true);
                }
            }
        }

        private static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("Veuillez choisir votre mode de jeu : ");
            Console.WriteLine();
            Console.WriteLine("\t1- Affrontez des monstres");
            Console.WriteLine("\t2- Affrontez le Boss Final");
            Console.WriteLine("\tQ- Quitter");
        }

        private static void Jeu1()
        {
            var joueur1 = new Joueur(150);
            int compteurFacile = 0;
            int compteurDifficile = 0;
            while (joueur1.EstVivant)
            {
                MonstreFacile monstre = FabriqueDeMonstre();
                while (monstre.EstVivant && joueur1.EstVivant)
                {
                    joueur1.Attaquer(monstre);
                    if (monstre.EstVivant)
                    {
                        monstre.Attaquer(joueur1);
                    }
                }

                if (joueur1.EstVivant)
                {
                    if (monstre is MonstreDifficile)
                    {
                        compteurDifficile++;
                    }
                    else
                    {
                        compteurFacile++;
                    }
                }
                else
                {
                    Console.WriteLine("Snif, vous êtes mort...");
                    break;
                }
            }
            Console.WriteLine("Bravo!!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", compteurFacile, compteurDifficile, compteurFacile + compteurDifficile * 2);
        }

        private static MonstreFacile FabriqueDeMonstre()
        {
            if (random.Next(2) == 0)
            {
                return new MonstreFacile();
            }
            else
            {
                return new MonstreDifficile();
            }
        }

        private static void Jeu2()
        {
            var joueur = new Joueur(150);
            var boss = new BossDeFin(250);
            while (boss.EstVivant && joueur.EstVivant)
            {
                joueur.Attaquer(boss);
                if (boss.EstVivant)
                {
                    boss.Attaquer(joueur);
                }
            }
            if (joueur.EstVivant)
            {
                Console.WriteLine("Félicitations vous avez vaincu le Boss de fin! Il vous reste {0} points de vie", joueur.PointDeVie);
            }
            else
            {
                Console.WriteLine("Snif vous êtes mort... Il restait {0} points de vie au Boss de Fin", boss.PointDeVie);
            }
        }
    }
}
