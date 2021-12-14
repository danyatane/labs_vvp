using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите А:");
            int A_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B_1 = Convert.ToInt32(Console.ReadLine());
            if (A_1 == B_1)
            {
                A_1 = 0;
                B_1 = 0;
            }
            else if (A_1 > B_1)
                B_1 = A_1;
            else
                A_1 = B_1;
            Console.WriteLine($"\nРезультат:\nA = {A_1}\nB = {B_1}\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите 1-ое число:");
            double chis_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число:");
            double chis_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-ое число:");
            double chis_3 = Convert.ToInt32(Console.ReadLine());
            double answ_2;
            if (chis_1 > chis_3 && chis_2 > chis_3)
                answ_2 = chis_1 + chis_2;
            else if (chis_1 > chis_2 && chis_3 > chis_2)
                answ_2 = chis_1 + chis_3;
            else
                answ_2 = chis_2 + chis_3;
            Console.WriteLine($"\nОтвет: {answ_2}\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите A(x):");
            double A_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите A(y):");
            double A_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B(x):");
            double B_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B(y):");
            double B_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C(x):");
            double C_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C(y):");
            double C_y = Convert.ToInt32(Console.ReadLine());
            double rasst_B = Math.Sqrt(Math.Pow(Math.Abs(A_x - B_x), 2) + Math.Pow(Math.Abs(A_y - B_y), 2));
            double rasst_C = Math.Sqrt(Math.Pow(Math.Abs(A_x - C_x), 2) + Math.Pow(Math.Abs(A_y - C_y), 2));
            if (rasst_B < rasst_C)
                Console.WriteLine($"\nТочка B ближе, расстояние от точки A равно {rasst_B}\n");
            else
                Console.WriteLine($"\nТочка C ближе, расстояние от точки A равно {rasst_C}\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите координату x:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            double y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("\nТочка находится в 1-ой четверти\n");
            else if (x < 0 && y > 0)
                Console.WriteLine("\nТочка находится во 2-ой четверти\n");
            else if (x < 0 && y < 0)
                Console.WriteLine("\nТочка находится в 3-ей четверти\n");
            else
                Console.WriteLine("\nТочка находится в 4-ой четверти\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите число:");
            int chis_5 = Convert.ToInt32(Console.ReadLine());
            if (chis_5 < 0 && chis_5 % 2 == 0)
                Console.WriteLine("\nОтрицательное четное число\n");
            else if (chis_5 < 0 && chis_5 % 2 != 0)
                Console.WriteLine("\nОтрицательное нечетное число\n");
            else if (chis_5 == 0)
                Console.WriteLine("\nНулевое число\n");
            else if (chis_5 > 0 && chis_5 % 2 == 0)
                Console.WriteLine("\nПоложительное четное число\n");
            else
                Console.WriteLine("\nПоложительное нечетное число\n");

            //Задание 6

            Console.WriteLine("Задание 6\n");
            Console.WriteLine("Введите число (1-999):");
            int chis_6 = Convert.ToInt32(Console.ReadLine());
            string chis_length;
            if (chis_6 < 10)
                chis_length = "одно";
            else if (chis_6 > 99)
                chis_length = "трех";
            else
                chis_length = "дву";
            if (chis_6 % 2 == 0)
                Console.WriteLine($"\nЧетное {chis_length}значное число\n");
            else
                Console.WriteLine($"\nНечетное {chis_length}значное число\n");
        }
    }
}