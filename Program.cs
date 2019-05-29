using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {

            int n = 5, max, k = 0;
            int[] mass = new int[n];
            Random aRand = new Random();
            Console.WriteLine("Введите ваш массив (5 элементов)");
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i] + " ");
            }
            max = mass[0];
            for (int i = 0; i < n; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];

                }

            }
            for (int i = 0; i < n; i++)
            {

                if (mass[i] == max)
                {
                    k++;
                }
            }
            Console.Write("\n");
            Console.WriteLine("Максимальный элемент элемент " + max);
            Console.WriteLine("Количество максимальных элемент элементов " + k);

        }
    }
}
