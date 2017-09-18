using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book { Name = "Оно", Price = 9.99, Author = "Steven King", Year = 1986 };

            BinaryFormatter binFormat = new BinaryFormatter();
            // Сохранить объект в локальном файле.
            using (Stream fStream = new FileStream("file.txt",
               FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, book);
            }
            using (Stream fStream = new FileStream("file.txt",
               FileMode.Open))
            {
                binFormat.Deserialize(fStream);
            }
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (Attribute Attr in attrs)
            {
                Attr.Name="Name";
                Console.WriteLine(Attr.Name);
            }
            Console.Read();
        }
    }
}
