using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MoveAction();
public delegate void PosSetter(int Position); 
public delegate void FinishAction(object Winner);
namespace _24._08
{
    public enum Cars : long { Грузовик, Автобус, Легковая, Спортивная}
    class Program
    {
        static void Main(string[] args)
        {
            DriveClub game = new DriveClub();

            Random rand = new Random();
            Cars name = (Cars)rand.Next(1,4);
            Cars name2 = (Cars)rand.Next(1,4);

            int speed1=rand.Next(1,100);
            int speed2 = rand.Next(1, 100);
            MoveObj car1 = new Car() { Name = name.ToString(), Speed = speed1 };
            MoveObj car2 = new Car() { Name = name2.ToString(), Speed = speed2 };

            car1.JoinGame(game);
            car2.JoinGame(game);

            game.Run();

            Console.WriteLine("Победил " + game.Winner+" машина");

            Console.ReadLine();
        }

    }
}
