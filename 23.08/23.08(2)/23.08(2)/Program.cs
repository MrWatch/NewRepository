using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < n; i++)
            {
                int num = rand.Next(1, 100);
                list.Add(num);
            }
            Console.WriteLine("*************");
            foreach(int a in list)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine("Числa больше средне арифметического: ");
            for (int i = 0; i < n; i++)
            {
                if (list[i] > list.Average()) { Console.WriteLine(list[i]); }
            }
            Console.WriteLine("*************");
            for(int i = 0; i < n; ++i)
            {
                if (i % 2 != 0) { list.RemoveAt(i); }
            }
            foreach (int a in list)
            {
                Console.WriteLine(a);
            }            
            Console.Read();
        }
    }
}
