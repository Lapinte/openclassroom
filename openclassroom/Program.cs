using System;

namespace openclassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            var joueur1 = new Joueur();
            var pv = joueur1.PointDeVie;
            Console.WriteLine(joueur1.PointDeVie);

            while (pv != 0)
            {
                var monstre = new MonstreFacile();

                while (monstre.Vivant == true)
                {
                    joueur1.Attaquer(monstre);
                    monstre.Attaquer(joueur1);
                }
                Console.WriteLine(joueur1.PointDeVie);
            }
            Console.WriteLine(joueur1.PointDeVie);
            Console.ReadKey();
        }
    }
}
