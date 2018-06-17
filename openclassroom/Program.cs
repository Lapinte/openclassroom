using System;

namespace openclassroom
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Jeu1();
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
 
           
        
    }
}
