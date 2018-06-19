using System;
using System.Collections.Generic;
using System.Text;

namespace openclassroom
{
    public static class De
    {
        private static Random random = new Random();

        public static int LanceLeDe()
        {
            return random.Next(1, 7);
        }

        public static int LanceLeDe(int tailleDuDe)
        {
            return random.Next(1, tailleDuDe+1);
        }
    }
}
