using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCar2
{
    [Table("Auto")]
    public class Auto
    {
        public Auto()
        {
            Tulajok = new HashSet<Tulaj>();
        }
        [Key]
        public int Id { get; set; }
        public string Gyartmany { get; set; }
        public string Tipus { get; set; }
        public int GyartasEve { get; set; }
        public virtual ICollection<Tulaj> Tulajok { get; set; }
    }
}
