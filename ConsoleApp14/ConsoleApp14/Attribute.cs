using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
    public class Attribute:System.Attribute
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public void Get()
        {
            Console.WriteLine("Name: " + Name + "\nCode: " + Code);
        }

    }
}