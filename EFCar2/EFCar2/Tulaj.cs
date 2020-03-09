using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCar2
{
    [Table("Tulaj")]
    public class Tulaj
    {
        [Key]
        public int Id { get; set; }
        public string Nev { get; set; }
        public int SzuletesEve { get; set; }
        public virtual Auto auto { get; set; }
    }
}
