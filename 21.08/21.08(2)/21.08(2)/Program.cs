using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._08_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите полное имя: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите количество оценок: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] grade = new int[count];
            Console.WriteLine("Введите оценки: ");
            for(int i = 0; i < grade.Length; ++i)
            {
                grade[i] = Convert.ToInt32(Console.ReadLine());
            }
            student.Name = name;
            student.FullName = fullName;
            student.Grades = grade;
            Console.Clear();
            Console.WriteLine("Имя: " + student.GetName() + "\nПолное имя: " + student.GetFullName() + "\nСредняя оценка: " + student.GetAvgGrade());
            Console.Read();
        }
    }
}
