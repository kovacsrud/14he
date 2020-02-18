using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCarMigration
{
    [Table("Auto")]
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        public string Gyartmany { get; set; }
        public string Tipus { get; set; }
        public int GyartasiEv { get; set; }
        public string Gyariszam { get; set; }
        //public string Rendszam { get; set; }
    }
}
