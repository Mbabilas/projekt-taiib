using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Zgloszenie
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Imie { get; set; }
        [Required, MaxLength(50)]
        public string Nazwisko { get; set; }
        [Required, MaxLength(50)]
        public string Kategoria { get; set; }       
        public bool Plec { get; set; }
        [Required, MaxLength(50)]
        public string TypZgloszenia { get; set; }
        public string TrescZgloszenia { get; set; }
        [Required]
        public bool OrzeczenieLekarskie { get; set; }
        public bool Zatwierdzony { get; set; }
        [ForeignKey(nameof(Id))]
        public Armia Armia { get; set; }

    }
}
