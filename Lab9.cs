using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int answ1 = N % 60;
            Console.WriteLine($"Кол-во секунд равно {answ1}\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите K:");
            int K = Convert.ToInt32(Console.ReadLine());
            int answ2 = K % 7;
            Console.WriteLine($"Номер дня недели - {answ2}\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите K:");
            int K1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N:");
            int N1 = Convert.ToInt32(Console.ReadLine());
            int answ3 = (K1 + N1 - 1) % 7;
            Console.WriteLine($"Номер дня недели - {answ3}\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int C = Convert.ToInt32(Console.ReadLine());
            int S_pr = A * B;
            int S_kv = C * C;
            int kol_vo_kv = (A / C) * (B / C);
            int S_bez_kv = (A * B) - (C * C * kol_vo_kv);
            Console.WriteLine($"Кол-во квадратов равно {kol_vo_kv}\nПлощадь незанятой части равна {S_bez_kv}\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Год принадлежит {((year - 1) / 100) + 1}-му столетию");
        }
    }
}
