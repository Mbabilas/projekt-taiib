using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public string Przeznaczenie { get; set; }
        public string Typ { get; set; }
        public int Mnoznik { get; set; }
        public List<Bron> Bronie { get; set; }
    }
}
