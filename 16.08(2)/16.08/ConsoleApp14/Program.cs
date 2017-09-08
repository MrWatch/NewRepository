using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexator arr = new Indexator(5);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 2;
                Console.Write("{0}\t", arr[i]);
            }
            Console.Read();
        }
    }
}
