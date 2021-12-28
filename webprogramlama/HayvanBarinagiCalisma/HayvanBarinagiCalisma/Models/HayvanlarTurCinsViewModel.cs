using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ciftlik.Models
{
    public class HayvanlarTurCinsViewModel
    {
        public List<Hayvan> Hayvanlar { get; set; }
        public List<Tur> Turler { get; set; }
        public List<Cins> Cinsler { get; set; }
        public List<Bolum> Bolumler { get; set; }
    }
}
