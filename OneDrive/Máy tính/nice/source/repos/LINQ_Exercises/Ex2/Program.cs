﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            Query query = new Query();
            Menu.showMenu(method, query);
        }
    }
}
