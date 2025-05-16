using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevuSistemi.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public int BransId { get; set; }
        public string TamAd => $"{DoktorAdi} {DoktorSoyadi}";
    }
}
