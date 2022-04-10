using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Armia
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Nazwa { get; set; }
        public int MozliwosciBojowe { get; set; }
        public int SilyLadowe { get; set; }
        public int SilyPowietrzne { get; set; }
        public int SilyMorskie { get; set; }
        public List<Bron> Bronie { get; set; }
        public List<Zgloszenie> Zgloszenia { get; set; }
        public List<Dywizja> Dywizje { get; set; }
    }
}
