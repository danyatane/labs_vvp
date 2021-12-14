using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите размер файла:\n");
            double size = Convert.ToInt32(Console.ReadLine());
            double size_kb = size / 1024;
            size = Math.Ceiling(size_kb);
            Console.WriteLine($"Размер файла равен {size} Кбайт\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите A:\n");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:\n");
            int B = Convert.ToInt32(Console.ReadLine());
            int answ2 = A / B;
            Console.WriteLine($"Кол-во отрезков В равно {answ2}\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите A:\n");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:\n");
            int B1 = Convert.ToInt32(Console.ReadLine());
            int answ3 = A1 % B1;
            Console.WriteLine($"Незанятая часть А равна {answ3}\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите число:\n");
            string numb = Console.ReadLine();
            Console.WriteLine($"Результат: {numb[1]}{numb[0]}\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите число:\n");
            string chis = Console.ReadLine();
            Console.WriteLine($"Результат: {chis[1]}{chis[2]}{chis[0]}");
        }
    }
}
