using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public class Joueur 
    {

        private De de;
        public int PointDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PointDeVie > 0; }
        }
        

        public Joueur(int points)
        {
            PointDeVie = points;
            de = new De();
        }

        public void Attaquer(MonstreFacile monstre)
        {
            int tirageJoueur = LanceLeDe();
            int tirageMonstre = monstre.LanceLeDe();
            if ( tirageJoueur >= tirageMonstre)
            {
                monstre.SubitDegats();
            }
        }

        public int LanceLeDe()
        {
            return de.LanceLeDe();
        }

        public void SubitDegats(int degats)
        {
            if (!BouclierFonctionne())
            {
                PointDeVie -= degats;
            }
        }
        private bool BouclierFonctionne()
        {
            return de.LanceLeDe() <= 2;
        }
    }
}
