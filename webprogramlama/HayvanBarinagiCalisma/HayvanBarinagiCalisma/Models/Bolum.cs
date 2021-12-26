using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanBarinagiCalisma.Models
{
    public class Bolum
    {
        [Key]
        public int BolumId { get; set; }
        public string BolumAdi { get; set; }

        //Hayvan ile ilişki
        public virtual List<Hayvan> Hayvanlar { get; set; }
    }
}
