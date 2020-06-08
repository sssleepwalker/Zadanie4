using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите 15 элементов (цифры и символы):  ");
            List<char> th = new List<char>();
            char[] tho = new char[15];

            for (int meow = 0; meow < 15; meow++)
            {
                Console.WriteLine("\nВведите " + (meow + 1) + " элемент коллекции: ");
                tho[meow] = char.Parse(Console.ReadLine());
            }
               
            for (int meow = 0; meow < 15; meow++)
            {
                th.Add(tho[meow]);
            }
                
         
                var mersi = new List<char>();
                int blabla = 0;


            for (int meow = 0; meow < 15; meow++)
            {
                if (char.IsUpper(th[meow]))
                {
                    blabla++;
                    if (blabla > 0)
                    {
                        mersi.Add(th[meow]);
                    }
                }
            }

            List<char> kar = new List<char>();

            int krik = 0;
            for (int meow = 0; meow < 15; meow++)
            {
                if (Char.IsDigit(th[meow]))
                {
                    krik++;
                    if (krik > 0)
                    {
                        kar.Add(th[meow]);
                    }

                }
            }

            Console.WriteLine("\nКоллекция, состоящая только из чисел:");
            for (int meow = 0; meow < krik; meow++) Console.WriteLine(kar[meow]);


            Console.WriteLine("\nКоллекция, состоящая только из заглавных букв:");
            for (int meow = 0; meow < blabla; meow++) Console.WriteLine(kar[meow]);

        }
    }
}
