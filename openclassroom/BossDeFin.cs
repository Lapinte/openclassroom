using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public class BossDeFin
    {
        private De de;
        public int PointDeVie { get; private set; }
        public bool EstVivant
        {
            get
            {
                return (PointDeVie > 0);
            }
        }

        private void Attaquer (Joueur joueur)
        {

        }
    }
}
