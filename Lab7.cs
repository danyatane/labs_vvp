using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите значение угла в градусах:\n");
            double ugol1 = Convert.ToDouble(Console.ReadLine());
            double answ1 = ugol1 / 180;
            Console.WriteLine($"угол равен {answ1}pi\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите значение угла в радианах (без pi):\n");
            double ugol2 = Convert.ToDouble(Console.ReadLine());
            double answ2 = ugol2 * 180;
            Console.WriteLine($"угол равен {answ2}°\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите X (кг):\n");
            double X_kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите А (руб):\n");
            double A_rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y (кг):\n");
            double Y_kg = Convert.ToDouble(Console.ReadLine());
            double one_kg = A_rub / X_kg;
            double answ3 = one_kg * Y_kg;
            Console.WriteLine($"1 кг стоит {one_kg} руб.\n{Y_kg} кг стоит {answ3} руб.\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите V1:\n");
            double V1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите V2:\n");
            double V2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите S:\n");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Т:\n");
            double T = Convert.ToDouble(Console.ReadLine());
            double answ4 = (V1 + V2) * T + S;
            Console.WriteLine($"Расстояние через {T} часов будет равно {answ4}\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите A\n");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B\n");
            double B = Convert.ToDouble(Console.ReadLine());
            if (A == 0)
            {
                Console.WriteLine("A не может быть равен 0\n");
            }
            else
            {
                double answ5 = -B / A;
                Console.WriteLine($"x равен {answ5}\n");
            }

            //Задание 6

            Console.WriteLine("Задание 6\n");
            Console.WriteLine("Введите A1:\n");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B1:\n");
            double B1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C1:\n");
            double C1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A2:\n");
            double A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B2:\n");
            double B2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C2:\n");
            double C2 = Convert.ToDouble(Console.ReadLine());
            double x = ((C2 * B1) - (B2 * C1)) / ((A2 * B1) - (B2 * A1));
            double y = (C1 - (A1 * x)) / B1;
            Console.WriteLine($"x равен {x}\ny равен {y}");
        }
    }
}
