using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            using (FileStream fileStream = new FileStream(@"C:\temp\fibo.txt", FileMode.OpenOrCreate))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                value = streamReader.ReadToEnd();
            }

            string[] points = value.Split(' ');
            List<int> newFiboNumbers = new List<int>();

            for (int i = 0; i < points.Length; ++i)
            {            
                int isCheck;
                if (Int32.TryParse(points[i], out isCheck))
                {
                    newFiboNumbers.Add(Int32.Parse(points[i]));
                }
            }

            int fiboLast = newFiboNumbers.Count - 1;
            int fiboAlmostLast = fiboLast - 1;
            int fiboCount = newFiboNumbers.Count;

            for (int i = 0; i < fiboCount; ++i)
            {
                int newElem = newFiboNumbers[fiboLast] + newFiboNumbers[fiboAlmostLast];
                newFiboNumbers.Add(newElem);
                ++fiboLast;
                ++fiboAlmostLast;
            }

            using (StreamWriter streamWriter = new StreamWriter(@"C:\temp\fibo.txt",false, System.Text.Encoding.Default))
            {
               foreach (int point in newFiboNumbers)
               {
                    streamWriter.Write(point+" ");
                    //Console.WriteLine(point + "- check");
               }
            }

            using (FileStream fileStream = new FileStream(@"C:\temp\AandB.txt", FileMode.OpenOrCreate))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                value = streamReader.ReadToEnd();
            }

            points = value.Split(' ');
            List<int> AandB = new List<int>();

            for (int i = 0; i < points.Length; ++i)
            {
                int forCheck;
                if (Int32.TryParse(points[i], out forCheck))
                {
                    AandB.Add(Int32.Parse(points[i]));
                }
            }

            int summ = 0;

            for (int i = 0; i < AandB.Count; ++i)
            {
                summ += AandB[i];
            }

            newFiboNumbers.Add(summ);

            using (StreamWriter streamWriter = new StreamWriter(@"C:\temp\summ.txt", false, System.Text.Encoding.Default))
            {
                    streamWriter.Write(summ);
            }
        }
    }
}