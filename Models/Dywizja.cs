using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dywizja
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Nazwa { get; set; }
        public string MiejsceStacjonowania { get; set; }
        public int Personel { get; set; }
        public List<Zolnierz> Zolnierze { get; set; }
        [ForeignKey(nameof(Id))]
        public Armia Armia { get; set; }
    }
}
