﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Partial_class
{
    class Department
    {
        readonly string Name;
        Employee[] employees;

        public Department(string name)
        {
            this.Name = name;
        }
        
        public void Show_depart()
        {
            Console.WriteLine($" Depart name : {this.Name}");
        }

        public string ReturnString()
        {
            return Name;
        }
    }
}
