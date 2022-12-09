using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Сформировать массив из 15 целых чисел, выбранных случайным 
    образом из интервала [-10, 30]. Найти среднее арифметическое 
    положительных элементов. */

namespace Lab_4_1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[15];
            Random random = new Random();

            int count = 0;
            double sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-10, 30);                
                if (Array[i] > 0)
                {
                    count++;
                    sum += Array[i];
                }
            }
            double sred = sum / count;
            Console.WriteLine($"sred={sred}");

            foreach (var item in Array)            
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // Linq
            var res = (decimal)Array.Where(i => i > 0).Average();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
