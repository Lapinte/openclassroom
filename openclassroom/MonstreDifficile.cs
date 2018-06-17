using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    class MonstreDifficile : MonstreFacile
    {
        private const int degatsSort = 5;

        public override void Attaquer(Joueur joueur)
        {
            base.Attaquer(joueur);
            joueur.SubitDegats(SortMagique());
        }

        private int SortMagique()
        {
            int valeur = de.LanceLeDe();
            if ( valeur == 6)
            {
                return 0;
            }
            else
            {
                return valeur * degatsSort;
            }
        }

    }
}
