﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    public abstract class Alapkave:IArlap
    {
        public const double CSESZEKAVE = 180;

        public abstract double mennyibeKerul();
    }
}
