using System;

namespace _6._1_15v
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.1 Средний уровень 15v
            int[] array = new int[7];
            
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(80);
            for (int i = 0; i < 7; i++)
            {
                
                    Console.Write($"{array[i]} \t");
            }
            Console.WriteLine();
            int max = Max(array);
            int min = Min(array);
            Console.WriteLine("Максимальное значение:" + max);
            Console.WriteLine("Минимальное значение: " + min);
        }
        static int Max(int[] array)       
        {
            int a = 7;
            int max = array[0];
            for (int i = 1; i < a; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        static int Min(int[] array)
        {
            int a = 7;
            int min = array[0];
            for (int i = 1; i < a; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
    }

    }


