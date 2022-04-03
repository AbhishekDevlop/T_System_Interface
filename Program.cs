﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable prt = new Product();
            prt.Print();

            prt = new Student();
            prt.Print();

            prt = new Xerox();
            prt.Print();
        }
    }
}
