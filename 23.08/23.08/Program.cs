using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа: ");
            for(int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0) { sum += list[i]; }
            }
            list.Remove(list.Max());
            Console.WriteLine("Второе максимальное число: {0} - {1}" ,list.IndexOf(list.Max()), list.Max());
            Console.WriteLine("Сумма четных элементов массива: " + sum);
            Console.Read();
        }
    }
}
