using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              5.Дан массив целых чисел(неупорядоченный).Реализуйте алгоритм, 
              который находит элемент с максимальным значением. Не используйте LINQ.
            */

            int[] array = new int[] { 2, 5, -9, 8, 12, 57, 5, 45, 0, 23 };
            
            int Max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > Max) 
                    Max = array[i]; 
            }
            Console.WriteLine($"Максимальное число: {Max}");

            Console.ReadLine();
        }
    }
}
