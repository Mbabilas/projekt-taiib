using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Zolnierz
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Imie { get; set; }
        [Required, MaxLength(50)]
        public string Nazwisko { get; set; }
        [Required]
        public DateTime DataUrodzenia { get; set; }
        [Required, MaxLength(50)]
        public string MiejsceUrodzenia { get; set; }
        [MaxLength(11),Required]
        public int Pesel { get; set; }
        [ForeignKey(nameof(Id))]
        public Dywizja Dywizja { get; set; }
        [ForeignKey(nameof(Id))]
        public Stopien Stopien { get; set; }
    }
}
