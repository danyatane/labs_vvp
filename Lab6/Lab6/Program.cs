using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите А:");
            string A_1 = Console.ReadLine();
            double A1 = double.Parse(A_1);
            Console.WriteLine("Введите B:");
            string B_1 = Console.ReadLine();
            double B1 = double.Parse(B_1);
            double vsp_1 = A1;
            A1 = B1;
            B1 = vsp_1;
            Console.WriteLine($"\nA = {A1}\nB = {B1}\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите А:");
            string A_2 = Console.ReadLine();
            double A2 = double.Parse(A_2);
            Console.WriteLine("Введите B:");
            string B_2 = Console.ReadLine();
            double B2 = double.Parse(B_2);
            Console.WriteLine("Введите C:");
            string C_2 = Console.ReadLine();
            double C2 = double.Parse(C_2);
            double vsp_2 = B2;
            B2 = A2;
            A2 = C2;
            C2 = vsp_2;
            Console.WriteLine($"\nA = {A2}\nB = {B2}\nC = {C2}\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите А:");
            string A_3 = Console.ReadLine();
            double A3 = double.Parse(A_3);
            Console.WriteLine("Введите B:");
            string B_3 = Console.ReadLine();
            double B3 = double.Parse(B_3);
            Console.WriteLine("Введите C:");
            string C_3 = Console.ReadLine();
            double C3 = double.Parse(C_3);
            double vsp_3 = C3;
            C3 = A3;
            A3 = B3;
            B3 = vsp_3;
            Console.WriteLine($"\nA = {A3}\nB = {B3}\nC = {C3}\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите x:");
            string x_4 = Console.ReadLine();
            double x4 = double.Parse(x_4);
            double answ_4 = 3 * Math.Pow(x4, 6) - 6 * x4 * x4 - 7;
            Console.WriteLine($"\nОтвет: {answ_4}\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите x:");
            string x_5 = Console.ReadLine();
            double x5 = double.Parse(x_5);
            double answ_5 = 4 * Math.Pow((x5 - 3), 6) - 7 * Math.Pow((x5 - 3), 3) + 2;
            Console.WriteLine($"\nОтвет: {answ_5}\n");

            //Задание 6

            Console.WriteLine("Задание 6\n");
            Console.WriteLine("Введите А:");
            string A_6 = Console.ReadLine();
            double A6 = double.Parse(A_6);
            double vsp_6 = Math.Pow(A6, 6);
            double answ_6 = A6 * A6 * vsp_6;
            Console.WriteLine($"\nОтвет: {answ_6}\n");

            //Задание 7

            Console.WriteLine("Задание 7\n");
            Console.WriteLine("Введите А:");
            string A_7 = Console.ReadLine();
            double A7 = double.Parse(A_7);
            double vsp_7_1 = Math.Pow(A7, 5);
            double vsp_7_2 = Math.Pow(A7, 7);
            double answ_7 = A7 * A7 * A7 * vsp_7_1 * vsp_7_2;
            Console.WriteLine($"\nОтвет: {answ_7}\n");
        }
    }
}