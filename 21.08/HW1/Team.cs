﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Team : IWorker
    {
        public string Do()
        {
            return "Команда приступила к работе.";
        }
    }
}
