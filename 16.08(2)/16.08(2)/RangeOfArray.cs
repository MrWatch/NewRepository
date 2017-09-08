using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _16._08_2_
{
    public class RangeOfArray
    {
        public int[] array;
        public int Length;
        public RangeOfArray(int Size)
        {
            array = new int[Size];
            Length = Size;
        }
        public int this[int index]
        {
            set
            {
                index = value;
            }
            get
            {
                return array[index];
            }
        }
    }
}