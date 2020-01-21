using System;

namespace ProgGyakBeadando
{
    public class Program
    {
        public static int[] tömbz;
        public static int th;
        static void Main(string[] args)
        {
            Console.WriteLine("Mennyi legyen a tömb hossza?");
            th = Convert.ToInt32(Console.ReadLine());
            tömbz = new int[th];
            for (int i = 0; i < tömbz.Length; i++)
            {
                _ = new Gamma();
                tömbz[i] = Gamma.randNum;
            }
            
            Console.WriteLine("Még nem rendezett tömb:");
            for (int i = 0; i < th; i++)
            {
                Console.Write(tömbz[i] + " ");
            }
            Console.WriteLine();
            Beta.Rendezés();
            Console.WriteLine("Már rendezett tömb:");
            for (int i = 0; i < th; i++)
            {
                Console.Write(tömbz[i] + " ");

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
