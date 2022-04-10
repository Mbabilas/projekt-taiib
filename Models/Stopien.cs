using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Stopien
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Nazwa { get; set; }
        public bool Oficerski { get; set; }
        public bool Generalski { get; set; }
        public bool Podoficerski { get; set; }
        public List<Zolnierz> Zolnierze { get; set; }
    }
}
