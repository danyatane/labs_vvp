using System;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            string[] month = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            string[] day = { "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое" };
            Console.WriteLine("Задание 1\n");
            Console.WriteLine("Введите номер дня (1-31):");
            int day_numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца (1-12):");
            int month_numb = Convert.ToInt32(Console.ReadLine());
            if (day_numb <= 20)
                Console.WriteLine($"\n{day[day_numb - 1]} {month[month_numb - 1]}\n");
            else if (day_numb > 20 && day_numb < 30)
                Console.WriteLine($"\nдвадцать {day[day_numb - 21]} {month[month_numb - 1]}\n");
            else if (day_numb == 30)
                Console.WriteLine($"\nтридцатое {month[month_numb - 1]}\n");
            else
                Console.WriteLine($"\nтридцать первое {month[month_numb - 1]}\n");

            //Задание 2

            string[] napr = { "Север", "Запад", "Юг", "Восток" };
            Console.WriteLine("Задание 2\n");
            Console.WriteLine("Введите исходное направление (С, З, Ю, В):");
            string napr_bukv = Console.ReadLine();
            Console.WriteLine("Введите команду (-1, 0, 1):");
            int komanda = Convert.ToInt32(Console.ReadLine());
            int napr_numb;
            if (napr_bukv == "С")
                napr_numb = 0;
            else if (napr_bukv == "З")
                napr_numb = 1;
            else if (napr_bukv == "Ю")
                napr_numb = 2;
            else
                napr_numb = 3;
            if (napr_numb == 3 && komanda == 1)
                Console.WriteLine("\nНаправление робота - Север\n");
            else if (napr_numb == 0 && komanda == -1)
                Console.WriteLine("\nНаправление робота - Восток\n");
            else
                Console.WriteLine($"\nНаправление робота - {napr[napr_numb + komanda]}\n");

            //Задание 3

            string[] numb_name = { "", "одно", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] numb_dec = { "", "", "двадцать ", "тридцать ", "сорок" };
            Console.WriteLine("Задание 3\n");
            Console.WriteLine("Введите число (10-40):");
            int numb_chis = Convert.ToInt32(Console.ReadLine());
            string numb_itog;
            if (numb_chis < 20)
                numb_itog = numb_name[numb_chis];
            else
                numb_itog = numb_dec[numb_chis / 10] + numb_name[numb_chis % 10];
            if (numb_chis == 1 || numb_chis == 21 || numb_chis == 31)
                Console.WriteLine($"\n{numb_itog} учебное задание\n");
            else if ((numb_chis > 21 && numb_chis < 25) || (numb_chis > 31 && numb_chis < 35))
                Console.WriteLine($"\n{numb_itog} учебных задания\n");
            else
                Console.WriteLine($"\n{numb_itog} учебных заданий\n");

            //Задание 4

            string[] chis_name = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] chis_dec = { "", "", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто " };
            string[] chis_sot = { "", "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот " };
            Console.WriteLine("Задание 4\n");
            Console.WriteLine("Введите число (100-999):");
            int chis = Convert.ToInt32(Console.ReadLine());
            string chis_itog;
            if ((chis / 10) % 10 == 1)
                chis_itog = chis_sot[chis / 100] + chis_name[chis % 100];
            else
                chis_itog = chis_sot[chis / 100] + chis_dec[(chis / 10) % 10] + chis_name[chis % 10];
            Console.WriteLine($"\nРезультат: {chis_itog}\n");

            //Задание 5

            string[] name_tsikl_1 = { "зеленой", "красной", "желтой", "белой", "черной" };
            string[] name_tsikl_2 = { "зеленого", "красного", "желтого", "белого", "черного" };
            string[] name_podtsikl = { "крысы", "коровы", "тигра", "зайца", "дракона", "змеи", "лошади", "овцы", "обезьяны", "курицы", "собаки", "свиньи" };
            Console.WriteLine("Задание 5\n");
            Console.WriteLine("Введите год:");
            int year = (Convert.ToInt32(Console.ReadLine()) - 4);
            int numb_tsikl = ((year % 60) % 10) / 2;
            int numb_podtsikl = year % 12;
            if (numb_podtsikl >= 2 && numb_podtsikl <= 4)
                Console.WriteLine($"\nГод {name_tsikl_2[numb_tsikl]} {name_podtsikl[numb_podtsikl]}\n");
            else
                Console.WriteLine($"\nГод {name_tsikl_1[numb_tsikl]} {name_podtsikl[numb_podtsikl]}\n");
        }
    }
}