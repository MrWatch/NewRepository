using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._08_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальный индекс: ");
            int fIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечный индекс: ");
            int lIndex = Convert.ToInt32(Console.ReadLine());
            if (lIndex < fIndex || lIndex == fIndex) { Environment.Exit(0); }
            int Size = lIndex - fIndex + 1 ;
            RangeOfArray array = new RangeOfArray(Size);
            int num = 1337;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num;
                Console.Write("{0} - {1}\n",fIndex, array[i]);
                fIndex++;
            }
            Console.Read();
        }
    }
}
