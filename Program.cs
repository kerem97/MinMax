using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {

     static void minmax(int[]x,ref int max , ref int min)
        {
            max = min = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max)
                    max = x[i];
                if (x[i] < min)
                    min = x[i];
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(100);
                Console.WriteLine(" " + array[i]);
            }
            int a=0, b = 0;
            minmax(array, ref a, ref b);
            Console.WriteLine("\n\n Max={0},Min={1}", a, b);
            Console.ReadKey();

                

        }
    }
}
