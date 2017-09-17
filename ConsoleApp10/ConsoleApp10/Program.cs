using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("https://habrahabr.ru/rss/interesting/");

            XmlElement rights = xdoc.DocumentElement;

            foreach (XmlElement xmlDoc in rights)
            {
                foreach (XmlElement elem in xmlDoc)
                {
                    if (elem.Name.Equals("Item"))
                    {
                        Item item = new Item();
                        item.Title = elem["title"].InnerText;
                        item.Link = elem["link"].InnerText;
                        item.Description = elem["description"].InnerText;
                        item.PubDate = DateTime.Parse(elem["pubDate"].InnerText);
                        list.Add(item);
                    }
                }
            }

            foreach (Item item in list)
            {
                Console.WriteLine("\n\n\t\t\t\n\n");
                Console.WriteLine(item.Title + "\n" + item.Description + " \n" + item.Link + "\n" + item.PubDate);
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Student.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "grade")
                    {
                        Console.WriteLine("Класс: {0}", childnode.InnerText);
                    }
                    if (childnode.Name == "letter")
                    {
                        Console.WriteLine("Буква: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}