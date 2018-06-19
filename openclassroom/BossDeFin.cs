using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public class BossDeFin
    {
        public int PointDeVie { get; private set; }
        public bool EstVivant
        {
            get { return PointDeVie > 0; }
        }

        public BossDeFin(int pv)
        {
            PointDeVie = pv;
        }

        public void SubitDegats(int degats)
        {
            PointDeVie -= degats;
        }

        public void Attaquer(Joueur joueur)
        {
            int degats = LanceLeDe(25);
            joueur.SubitDegats(degats);
        }

        public int LanceLeDe(int tailleDuDe)
        {
            return De.LanceLeDe(tailleDuDe);
        }
    }
}
