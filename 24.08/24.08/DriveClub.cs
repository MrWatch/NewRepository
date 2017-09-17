using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._08
{
    public class DriveClub
    {
        protected bool isGameStarted = false;

        public MoveAction Move;
        public PosSetter MoveTo;

        public object Winner;

        public void Run()
        {
            MoveTo(0);
            isGameStarted = true;
            while (isGameStarted)
            {
                Move();

                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }
        }

        public void OnFinis(object Winner)
        {
            isGameStarted = false;
            this.Winner = Winner;
        }
    }
}
