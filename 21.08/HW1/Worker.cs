using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Worker : IWorker
    {
        public string Do()
        {
            return "Строитель приступил к работе.";
        }
    }
}
