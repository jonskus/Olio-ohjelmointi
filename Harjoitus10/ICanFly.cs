﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal interface ICanFly
    {
        int WingSize { get; set; }
        private static void Fly() { }
    }
}
