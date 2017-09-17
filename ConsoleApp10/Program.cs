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
            
            XmlDocument document = new XmlDocument();
            document.Load("Request.xml");

            XmlNode root = document.DocumentElement;

                           
            Requests request = new Requests();
            request.ForwardUrl = root["forwardUrl"].InnerText;
            request.Language = root["language"].InnerText;
                   
            request.UserId = long.Parse(root["userId"].InnerText);

            Console.WriteLine(root.Name);
            foreach (XmlNode child in root.ChildNodes)
                {              
                   Console.WriteLine("  " + child.Name);

                if (child.HasChildNodes)
                {
                    foreach (XmlNode child2 in child.ChildNodes)
                    {
                        if (child2.HasChildNodes)
                        {
                            Console.WriteLine("    " + child2.Name);  
                            foreach (XmlNode child3 in child2.ChildNodes)
                            {                            
                                 Console.WriteLine("      " + child3.Name);
                            }                                              
                        }                        
                    }                    
                }                
            }                                     
            Console.ReadLine();          
        }
    }
}
