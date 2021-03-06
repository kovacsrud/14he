﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    public class Kave:Alapkave
    {
        private bool habosE;

        public Kave(bool habose)
        {
            this.habosE = habose;
        }


        public override double mennyibeKerul()
        {
            if (habosE)
            {
                return CSESZEKAVE * 1.5;
            } else
            {
                return CSESZEKAVE;
            }
        }

        public override string ToString()
        {
            String kave = "";
            if (habosE)
            {
                kave = kave + "Habos ";
            }
            else
            {
                kave = kave + "Nem habos ";
            }

            return $"{kave}, {mennyibeKerul()} Ft";
        }
    }
}
