﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus10
{
    internal class Varis : Animal, ICanFly
    {
        public int WingSize { get; set; }
    }
}
