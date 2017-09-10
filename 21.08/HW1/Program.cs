using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPart> parts = new List<IPart>();
            Team team = new Team();
            Console.Write(team.Do()+"\n");
            Worker worker = new Worker();
            Console.Write(worker.Do()+"\n");
            Basement basement = new Basement();
            Walls walls = new Walls();
            Door door = new Door();
            Window window = new Window();
            Roof roof = new Roof();
            parts.Add(basement);
            if (parts.Contains(basement)) { Console.WriteLine("Фундамент был построен."); }
            parts.Add(walls);
            if (parts.Contains(walls)) { Console.WriteLine("4 стены были построены."); }
            parts.Add(door);
            if (parts.Contains(door)) { Console.WriteLine("Дверь была построена."); }
            parts.Add(window);
            if (parts.Contains(window)) { Console.WriteLine("4 окна были построены."); }
            parts.Add(roof);
            if (parts.Contains(roof)) { Console.WriteLine("Крыша была построена."); }
            TeamLeader leader = new TeamLeader();
            Console.Write(leader.Do());
            Console.WriteLine("\n"+@" ///|\\\"+"\n |     |"+"\n | # # |"+"\n |   []|"+"\n =======");            
            Console.Read();
        }
    }
}
