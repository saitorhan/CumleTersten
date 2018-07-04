using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumleTersten
{
    class Program
    {
        static void Main(string[] args)
        {
            baslangic:
            Console.Clear();

            Console.WriteLine("Girilen cümleyi tersten yazar.");
            Console.Write("Cümleyi Giriniz: ");
            string readLine = Console.ReadLine();
            Console.WriteLine("Sonuç:");
            for (int i = readLine.Length - 1; i >= 0; i--)
            {
                Console.Write(readLine[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Devam ENTER tuşa basınız");
            Console.ReadLine();
            goto baslangic;
        }
    }
}
