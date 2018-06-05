using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    class MonstreFacile : De
    {
        public bool Vivant { get; set ; }
        public MonstreFacile()
        {
            Vivant = true;
        }

        public void Attaquer(Joueur joueur)
        {
            int tirageJoueur = joueur.LanceLeDe();
            int tirageMonstre = LanceLeDe();
            if (tirageMonstre > tirageJoueur)
            {
                joueur.SubitDegats(LanceLeDe());
            }
           
        }
    }
}
