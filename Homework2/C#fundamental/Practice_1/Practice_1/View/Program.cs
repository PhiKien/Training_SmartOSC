﻿using Practice_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();
            Console.ReadKey();
        }
    }
}
