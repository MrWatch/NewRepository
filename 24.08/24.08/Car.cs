using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._08
{
    public class Car : MoveObj
    {
        public int Speed;
        public override void Move()
        {
            Position += Speed;
        }
    }
}
