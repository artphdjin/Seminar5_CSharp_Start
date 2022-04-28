using System;

namespace Seminar5_CSharp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 34: Задайте массив заполненный случайными
            положительными трёхзначными числами. Напишите
            программу, которая покажет количество чётных чисел в
            массиве.
            [345, 897, 568, 234] -> 2
            Задача 36: Задайте одномерный массив, заполненный
            случайными числами. Найдите сумму элементов, стоящих
            на нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0
            Задача 38: Задайте массив вещественных чисел. Найдите
            разницу между максимальным и минимальным
            элементов массива.
            [3 7 22 2 78] -> 76
            */


            // Задача 34:

            Console.WriteLine("Задача 34: Задайте массив заполненный случайными " +
                "положительными трёхзначными числами. Напишите " +
                "программу, которая покажет количество чётных чисел в массиве.");

            Console.WriteLine("Введите количество элементов в массиве:");

            Random rnd = new Random();
            int task34 = 0;

            bool numberCheck = int.TryParse(Console.ReadLine(),out int task34_size);
            if (numberCheck)
            {
                int[] task34_array = new int[task34_size];
                for (int i = 0; i < task34_size; i++)
                {
                    task34_array[i] = rnd.Next(100, 999);
                    if (task34_array[i] % 2 == 0) task34++;
                }
                Console.WriteLine("[" + String.Join(", ", task34_array) + "] -> " + task34);

            }
            else Console.WriteLine("не число");

        }
    }
}
