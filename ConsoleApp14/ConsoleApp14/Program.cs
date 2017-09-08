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
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://awdokanwdoawnodnawo.ru/");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();
            }catch { Console.WriteLine("Error 404"); }
            

            int[] array=new int[5];
            try
            {
                for (int i = 0; i < 6; ++i)
                {
                    Console.Write(array[i]);
                }
            }
            catch { Console.WriteLine("\nError 405"); }
            Console.Read();
        }
    }
}
