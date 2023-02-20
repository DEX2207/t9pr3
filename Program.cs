using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t9pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Заполните массив: ");
            //int[] mass = new int[6];
            //int i;
            //for (i=0;i<mass.Length;i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < mass.Length; i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}
            //Console.ReadLine();

            //2
            //Write("Введите размер массива: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int[] mass = new int[n];
            //int i;
            //for (i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(-20, 20);
            //}
            //    foreach (int el in mass)
            //{
            //    Write($"{el}\t");
            //}
            //ReadLine();

            //3
            WriteLine("Заполните массив: ");
            int[] mass = new int[6];
            int i;
            for (i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass[{i}]=");
                mass[i] = Convert.ToInt32(ReadLine());
            }
            int max=mass[0];
            for(i=1;i<mass.Length;i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                }
            }
            WriteLine($"max={max}");
            ReadLine();
        }
    }
}
