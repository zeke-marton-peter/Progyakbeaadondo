using System;
using System.Collections.Generic;
using System.Text;

namespace ProgGyakBeadando
{
    public class Gamma
    {
        public static int randNum;
        public Gamma()
        {
            Random rand = new Random();
            randNum = rand.Next(1, 100);
        }
    }
    public class Beta : Program 
    {
        public static void Rendezés()
        {
            for (int j = th - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                {
                    if (tömbz[k] > tömbz[k + 1])
                    {
                        int s = tömbz[k + 1];
                        tömbz[k + 1] = tömbz[k];
                        tömbz[k] = s;
                    }
                }
            }
        }
    }
}
