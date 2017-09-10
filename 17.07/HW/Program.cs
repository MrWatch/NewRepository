using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static int des = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.WriteLine("Введите символы: ");            
            string sim = Console.ReadLine();
            int dotIndex = sim.IndexOf('.');
            if (dotIndex >= 0)
            {
                sim = sim.Substring(0, dotIndex + 1);
            }
            var chars = sim.ToCharArray();
            
            Task1(chars);

            Task4(1, 4);
            Console.WriteLine("Task2");
            Console.WriteLine("Введите номер билета: ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            Task2(ch, ticketNumber);
            Console.WriteLine("Task3");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            Task3(text);
            Console.WriteLine("Task4");
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число больше второго:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) { Console.WriteLine("Error.Числа введены неверно."); Environment.Exit(0); }
            Task4(a, b);
            Console.WriteLine("Task5");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Task5(num);
            Console.ReadLine();
        }
        static void Task1(char[] sim)
        {
            int space = 0;
            int count = 0;
            for(int i = 0; i < sim.Length; i++)
            {
                if(sim[i]==' ') { space++; }
                if (sim[i] != '\0'&&sim[i]!=' ') { count++; }
            }
            Console.WriteLine("Количество пробелов: {0}\nКоличество символов: {1}", space, count);
            
        }
        static void Task2(char[] ch, int[] ticketNumber)
        {
            if (ch.Length == 6)
            {
                int lNumber = 0;
                int rNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        lNumber += ticketNumber[i];
                    }

                    else rNumber += ticketNumber[i];
                }

                if (lNumber == rNumber)
                {
                    Console.WriteLine("У вас счастливый билет");
                }

                else Console.WriteLine("У вас не счастливый билет");
            }

            else Console.WriteLine("Число введено не правильно!");
        }
        static void Task3(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
        static void Task4(int a, int b)
        {
            for (int i = a; i <= b; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void Task5(int n)
        {
            int newN = 0;
            while (n != 0)
            {
                newN *= des;
                newN += n % des;
                n = n / des;
            }
            Console.WriteLine("Новое число: " + newN);
        }
    }
}