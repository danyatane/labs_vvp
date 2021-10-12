using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1:\n");
            Console.WriteLine("Введите x1:");
            string coor_x1 = Console.ReadLine();
            double x1 = double.Parse(coor_x1);
            Console.WriteLine("Введите y1:");
            string coor_y1 = Console.ReadLine();
            double y1 = double.Parse(coor_y1);
            Console.WriteLine("Введите x2:");
            string coor_x2 = Console.ReadLine();
            double x2 = double.Parse(coor_x2);
            Console.WriteLine("Введите y2:");
            string coor_y2 = Console.ReadLine();
            double y2 = double.Parse(coor_y2);
            double otr_A = Math.Abs(x2 - x1);
            double otr_B = Math.Abs(y2 - y1);
            double otr_C = Math.Sqrt((otr_A * otr_A) + (otr_B * otr_B));
            Console.WriteLine($"\nРасстояние равно {otr_C}\n");

            //Задание 2

            Console.WriteLine("Задание 2:\n");
            Console.WriteLine("Введите A:");
            string coor_A = Console.ReadLine();
            double A = double.Parse(coor_A);
            Console.WriteLine("Введите B:");
            string coor_B = Console.ReadLine();
            double B = double.Parse(coor_B);
            Console.WriteLine("Введите C:");
            string coor_C = Console.ReadLine();
            double C = double.Parse(coor_C);
            double AC = Math.Abs(C - A);
            double BC = Math.Abs(C - B);
            double sum_AC_BC = AC + BC;
            Console.WriteLine($"\nAC равен {AC}\nBC равен {BC}\nСумма AC и BC равна {sum_AC_BC}\n");

            //Задание 3

            Console.WriteLine("Задание 3:\n");
            Console.WriteLine("Введите A:");
            string coord_A = Console.ReadLine();
            double A1 = double.Parse(coord_A);
            Console.WriteLine("Введите B:");
            string coord_B = Console.ReadLine();
            double B1 = double.Parse(coord_B);
            Console.WriteLine("Введите C:");
            string coord_C = Console.ReadLine();
            double C1 = double.Parse(coord_C);
            double AC1 = Math.Abs(C1 - A1);
            double BC1 = Math.Abs(C1 - B1);
            double proizv_AC_BC = AC1 * BC1;
            Console.WriteLine($"\nПроизведение AC и BC равно {proizv_AC_BC}\n");

            //Задание 4

            Console.WriteLine("Задание 4:\n");
            Console.WriteLine("Введите x1:");
            string coor_x1_1 = Console.ReadLine();
            double x1_1 = double.Parse(coor_x1_1);
            Console.WriteLine("Введите y1:");
            string coor_y1_1 = Console.ReadLine();
            double y1_1 = double.Parse(coor_y1_1);
            Console.WriteLine("Введите x2:");
            string coor_x2_1 = Console.ReadLine();
            double x2_1 = double.Parse(coor_x2_1);
            Console.WriteLine("Введите y2:");
            string coor_y2_1 = Console.ReadLine();
            double y2_1 = double.Parse(coor_y2_1);
            double length = Math.Abs(x2_1 - x1_1);
            double width = Math.Abs(y2_1 - y1_1);
            double P = 2 * (length + width);
            double S = length * width;
            Console.WriteLine($"\nПериметр равен {P}\nПлощадь равна {S}\n");

            //Задание 5

            Console.WriteLine("Задание 5:\n");
            Console.WriteLine("Введите x1:");
            string coor_x1_2 = Console.ReadLine();
            double x1_2 = double.Parse(coor_x1_2);
            Console.WriteLine("Введите y1:");
            string coor_y1_2 = Console.ReadLine();
            double y1_2 = double.Parse(coor_y1_2);
            Console.WriteLine("Введите x2:");
            string coor_x2_2 = Console.ReadLine();
            double x2_2 = double.Parse(coor_x2_2);
            Console.WriteLine("Введите y2:");
            string coor_y2_2 = Console.ReadLine();
            double y2_2 = double.Parse(coor_y2_2);
            Console.WriteLine("Введите x3:");
            string coor_x3_2 = Console.ReadLine();
            double x3_2 = double.Parse(coor_x3_2);
            Console.WriteLine("Введите y3:");
            string coor_y3_2 = Console.ReadLine();
            double y3_2 = double.Parse(coor_y3_2);
            double stor_A = Math.Sqrt((Math.Abs(x1_2 - x2_2) * Math.Abs(x1_2 - x2_2)) + (Math.Abs(y1_2 - y2_2) * Math.Abs(y1_2 - y2_2)));
            double stor_B = Math.Sqrt((Math.Abs(x2_2 - x3_2) * Math.Abs(x2_2 - x3_2)) + (Math.Abs(y2_2 - y3_2) * Math.Abs(y2_2 - y3_2)));
            double stor_C = Math.Sqrt((Math.Abs(x1_2 - x3_2) * Math.Abs(x1_2 - x3_2)) + (Math.Abs(y1_2 - y3_2) * Math.Abs(y1_2 - y3_2)));
            double pol_P = (stor_A + stor_B + stor_C) / 2;
            double S1 = Math.Sqrt(pol_P * (pol_P - stor_A) * (pol_P - stor_B) * (pol_P - stor_C));
            Console.WriteLine($"\nПериметр равен {pol_P * 2}\nПлощадь равна {S1}");
        }
    }
}