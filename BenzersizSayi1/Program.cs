using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.Write("Kaç adet sayı olsun:");
            a = int.Parse(Console.ReadLine());
            int[] sayi1 = new int[a];
            Random rnd = new Random();
            int i = 0;
            while (i < a)
            {
                int sayi2 = rnd.Next(1, 10000);
                if (sayi1.Contains(sayi2))
                    continue;
                sayi1[i] = sayi2;
                i++;
            }
            Array.Sort(sayi1);
            foreach (int sayi2 in sayi1)
                Console.WriteLine(sayi2);
            Console.ReadKey();
        }
    }
}
