using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    class Joueur : De
    {
        private int pointDeVie;

        public int PointDeVie
        {
            get
            {
                return pointDeVie;
            }
        }

        public Joueur()
        {
            pointDeVie = 150;
        }

        public void Attaquer(MonstreFacile monstre)
        {
            int tirageJoueur = LanceLeDe();
            int tirageMonstre = monstre.LanceLeDe();
            if ( tirageJoueur >= tirageMonstre)
            {
                monstre.Vivant = false;
            }
            else
            {
                monstre.Vivant = true;
            }
        }

        public void SubitDegats(int degat)
        {
            if (degat <= 2)
            {
                pointDeVie = PointDeVie;
            }
            else
            {
                pointDeVie = pointDeVie - 10;
            }
        }
    }
}
