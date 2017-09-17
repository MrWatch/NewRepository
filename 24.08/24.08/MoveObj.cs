using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._08
{
    public abstract class MoveObj
    {
        public FinishAction Finish;
        public string Name;

        int _pos;
        public int Position
        {
            get { return _pos; }
            set
            {
                _pos = value;
                Console.WriteLine(this + " на позиции " + _pos);
                if (_pos >= 100) Finish(this);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public void JoinGame(DriveClub Game)
        {
            // Подписываемся на игру
            Game.Move += this.Move;
            Game.MoveTo += this.MoveTo;
            Finish = Game.OnFinis;
        }

        public abstract void Move();

        public void MoveTo(int Position)
        {
            this.Position = Position;
        }
    }
}
