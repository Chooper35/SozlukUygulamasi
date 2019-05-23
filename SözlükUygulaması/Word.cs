using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SözlükUygulaması
{
    public class Word
    {
        public int Id { get; set; }
        public string İngilizceKelime { get; set;}
        public string TürkceKelime { get; set; }
        public string KelimeTürü { get; set; }
        public int ÖgrenmeDurumu { get; set; }
        public DateTime GirilenTarih { get; set;}
    }
}
