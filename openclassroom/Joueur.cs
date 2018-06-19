using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public class Joueur
    {

        public int PointDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PointDeVie > 0; }
        }


        public Joueur(int points)
        {
            PointDeVie = points;
        }

        public void Attaquer(MonstreFacile monstre)
        {
            int tirageJoueur = LanceLeDe();
            int tirageMonstre = monstre.LanceLeDe();
            if (tirageJoueur >= tirageMonstre)
            {
                monstre.SubitDegats();
            }
        }

        public void Attaquer(BossDeFin boss)
        {
            int degats = LanceLeDe(25);
            boss.SubitDegats(degats);
        }

        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }

        public int LanceLeDe(int tailleDuDe)
        {
            return De.LanceLeDe(tailleDuDe);
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
            return De.LanceLeDe() <= 2;
        }
    }
}
