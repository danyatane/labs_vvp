using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.WriteLine("Задание 1:\n");
            Console.WriteLine("Введите длину:");
            string length = Console.ReadLine();
            double a = double.Parse(length);
            Console.WriteLine("Введите ширину:");
            string width = Console.ReadLine();
            double b = double.Parse(width);
            double S = a * b;
            double P = 2 * (a + b);
            Console.WriteLine($"\nПлощадь равна {S}\nПериметр равен {P}\n");

            //Задание 2

            Console.WriteLine("Задание 2:\n");
            Console.WriteLine("Введите диаметр окружности:");
            string diameter = Console.ReadLine();
            double d = double.Parse(diameter);
            double L = 3.14 * d;
            Console.WriteLine($"\nДлина окружности равна {L}\n");

            //Задание 3

            Console.WriteLine("Задание 3:\n");
            Console.WriteLine("Введите число a:");
            string number1 = Console.ReadLine();
            double a1 = double.Parse(number1);
            Console.WriteLine("Введите число b:");
            string number2 = Console.ReadLine();
            double b1 = double.Parse(number2);
            double sr_arifm = (a1 + b1) / 2;
            Console.WriteLine($"\nСреднее арифметическое равно {sr_arifm}\n");

            //Задание 4

            Console.WriteLine("Задание 4:\n");
            Console.WriteLine("Введите 1-ое число:");
            string num1 = Console.ReadLine();
            double chislo1 = double.Parse(num1);
            Console.WriteLine("Введите 2-oe число:");
            string num2 = Console.ReadLine();
            double chislo2 = double.Parse(num2);
            double sum = (chislo1 * chislo1) + (chislo2 * chislo2);
            double razn = (chislo1 * chislo1) - (chislo2 * chislo2);
            double proizv = (chislo1 * chislo1) * (chislo2 * chislo2);
            double chast = (chislo1 * chislo1) / (chislo2 * chislo2);
            Console.WriteLine($"\nСумма равна {sum}\nРазность равна {razn}\nПроизведение равно {proizv}\nЧастное равно {chast}\n");

            //Задание 5

            Console.WriteLine("Задание 5:\n");
            Console.WriteLine("Введите 1-ое число:");
            string numb1 = Console.ReadLine();
            double chis1 = double.Parse(numb1);
            chis1 = Math.Abs(chis1);
            Console.WriteLine("Введите 2-oe число:");
            string numb2 = Console.ReadLine();
            double chis2 = double.Parse(numb2);
            chis2 = Math.Abs(chis2);
            double sum1 = chis1 + chis2;
            double razn1 = chis1 - chis2;
            double proizv1 = chis1 * chis2;
            double chast1 = chis1 / chis2;
            Console.WriteLine($"\nСумма равна {sum1}\nРазность равна {razn1}\nПроизведение равно {proizv1}\nЧастное равно {chast1}\n");
        }
    }
}