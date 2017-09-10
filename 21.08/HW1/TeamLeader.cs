using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class TeamLeader : IWorker
    {
        public string Do()
        {
            return "Бригадир сделал отчет.";
        }
    }
}
