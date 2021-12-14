using System;

namespace Lab10
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
            if (A_1 > 2 && B_1 <= 3)
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 2

            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите А:");
            int A_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int C_2 = Convert.ToInt32(Console.ReadLine());
            if (B_2 > A_2 && B_2 < C_2)
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 3

            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите число:");
            int chis_3 = Convert.ToInt32(Console.ReadLine());
            if (chis_3 % 2 == 0 && chis_3 >= 10 && chis_3 < 100)
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 4

            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите число:");
            string chis_4 = Console.ReadLine();
            if ((chis_4[1] > chis_4[0] && chis_4[1] < chis_4[2]) || (chis_4[1] < chis_4[0] && chis_4[1] > chis_4[2]))
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 5

            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите число:");
            string chis_5 = Console.ReadLine();
            if (chis_5[0] == chis_5[3] && chis_5[1] == chis_5[2])
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 6

            Console.WriteLine("Задание 6\n");
            Console.WriteLine("Введите А:");
            int A_6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B_6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int C_6 = Convert.ToInt32(Console.ReadLine());
            if ((A_6 * A_6 + B_6 * B_6) == (C_6 * C_6) || (A_6 * A_6 + C_6 * C_6) == (B_6 * B_6) || (C_6 * C_6 + B_6 * B_6) == (A_6 * A_6))
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");

            //Задание 7

            Console.WriteLine("Задание 7\n");
            Console.WriteLine("Введите А:");
            int A_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C:");
            int C_7 = Convert.ToInt32(Console.ReadLine());
            if (A_7 + B_7 > C_7 && A_7 + C_7 > B_7 && B_7 + C_7 > A_7)
                Console.WriteLine("Высказывание истинно\n");
            else
                Console.WriteLine("Высказывание ложно\n");
        }
    }
}
