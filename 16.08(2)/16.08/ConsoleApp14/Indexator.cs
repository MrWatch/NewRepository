using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Indexator
    {
        public int[] array;
        public int Length;
        public Indexator(int Size)
        {
            array = new int[Size];
            Length = Size;
        }

        public int this[int index]
        {
            set
            {
                array[index] = value;
            }

            get
            {
                array[index] = array[index] * array[index];
                return array[index];                
            }
        }
    }
}
