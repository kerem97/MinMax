using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {

     static void minmax(int[]x,ref int eb , ref int ek)
        {
            eb = ek = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > eb)
                    eb = x[i];
                if (x[i] < ek)
                    ek = x[i];
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                dizi[i] = rnd.Next(100);
                Console.WriteLine(" " + dizi[i]);
            }
            int a=0, b = 0;
            minmax(dizi, ref a, ref b);
            Console.WriteLine("\n\n Eb={0},Ek={1}", a, b);
            Console.ReadKey();

                

        }
    }
}
