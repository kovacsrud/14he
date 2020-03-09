using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCar2
{
    public class AutoContext:DbContext
    {
        public DbSet<Auto> Autok { get; set; }
        public DbSet<Tulaj> Tulajok { get; set; }
    }
}
