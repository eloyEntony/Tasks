﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.home_work_03._05._20_
{
    class Roof : IPart
    {
        public string Add_Part()
        {
            return "Roof";
        }
        public uint Count_part()
        {
            return 1;
        }
    }
}
