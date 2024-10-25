using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4AtaP
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new int[11]; // Задати масив довжиною 11 (згідно з вашим варіантом)
            Random rand = new Random(); // Генератор випадкових чисел
            for (int i = 0; i < array.Length; i++) // Заповнити масив випадковими числами в діапазоні від 0 до 15
            {
                array[i] = rand.Next(0, 16);
            }
            Console.WriteLine("Вихідний масив:"); // Вивести вихідний масив
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int sum = 0;
            int count = 0;
            foreach (var num in array) // Обчислення середнього арифметичного парних елементів
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count > 0) // Вивести середнє арифметичне парних елементів
            {
                double average = (double)sum / count;
                Console.WriteLine($"Середнє арифметичне парних елементів: {average}");
            }
            else
            {
                Console.WriteLine("Немає парних елементів.");
            }
        }
    }
}


/*
namespace task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть довжину масиву: ");
            int length = int.Parse(Console.ReadLine()); // Введення довжини масиву
            int[] array = new int[length]; // Створення масиву
            Random rand = new Random(); // Генератор випадкових чисел
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-8, 16); // Заповнення масиву випадковими числами в діапазоні від -8 до 15
            }
            Console.WriteLine("Вихідний масив:");
            foreach (var num in array)
            {
                Console.Write(num + " "); // Виведення вихідного масиву
            }
            Console.WriteLine();
            List<int> positiveIndices = new List<int>(); // Збір індексів позитивних елементів (включаючи нулі)
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    positiveIndices.Add(i);
                }
            }
            for (int i = 0; i < positiveIndices.Count / 2; i++) // Заміна місцями позитивних елементів
            {
                int firstIndex = positiveIndices[i];
                int lastIndex = positiveIndices[positiveIndices.Count - 1 - i];
                int temp = array[firstIndex];
                array[firstIndex] = array[lastIndex];
                array[lastIndex] = temp;
            }
            Console.WriteLine("Оброблений масив:");
            foreach (var num in array)
            {
                Console.Write(num + " "); // Виведення обробленого масиву
            }
            Console.WriteLine();
        }
    }
}
*/