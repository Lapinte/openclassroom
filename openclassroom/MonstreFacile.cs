using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public class MonstreFacile 
    {
        private const int degats = 10;
        public bool EstVivant { get; private set ; }

        public MonstreFacile()
        {
            EstVivant = true;
        }

        public virtual void Attaquer(Joueur joueur)
        {
            int tirageJoueur = joueur.LanceLeDe();
            int tirageMonstre = LanceLeDe();
            if (tirageMonstre > tirageJoueur)
            {
                joueur.SubitDegats(degats);
            }
           
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }

        public int LanceLeDe()
        {
            return De.LanceLeDe();
        }
    }
}
