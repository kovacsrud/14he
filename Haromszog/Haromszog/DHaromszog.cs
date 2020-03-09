using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    public class DHaromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;

        public double a {
            get { return aOldal; }

            set {
                if (value>0)
                {
                    aOldal = value;
                } else
                {
                    throw new HaromszogHiba("Az a oldal nem lehet nulla negatív!");
                }
            }
        }

        public double b { get { return bOldal; }

            set {
                if (value > 0)
                {
                    bOldal = value;
                }
                else
                {
                    throw new HaromszogHiba("A b oldal nem lehet nulla negatív!");
                }

            }

        }

        public double c {
            get { return cOldal; }

            set
            {
                if (value > 0)
                {
                    cOldal = value;
                }
                else
                {
                    throw new HaromszogHiba("A c oldal nem lehet nulla negatív!");
                }
            }


        }

        public bool EllDerekszogu {
            get
            {
                if (Math.Pow(cOldal,2)==Math.Pow(aOldal,2)+Math.Pow(bOldal,2))
                {
                    return true;
                } else
                {
                    return false;
                }
            } 

        }

        public bool EllMegszerkesztheto {
            get
            {
                if (cOldal<aOldal+bOldal)
                {
                    return true;
                } else
                {
                    return false;
                }
            }

        }


        public bool EllNovekvoSorrend {
            get
            {
                if (aOldal<=bOldal && bOldal<=cOldal)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }



    }
}
