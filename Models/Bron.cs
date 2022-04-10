using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bron
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public Model Model { get; set; }
        [ForeignKey(nameof(Id))]
        public Armia Armia { get; set; }
        public bool WUzyciu { get; set; }
    }
}
