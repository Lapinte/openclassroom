using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    class De
    {
        public int LanceLeDe()
        {
            Random random = new Random();
            int tirage = random.Next(1, 7);
            return tirage;
        }
    }
}
