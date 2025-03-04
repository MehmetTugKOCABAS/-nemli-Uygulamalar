using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class Araba
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public int KiralamaBedeli { get; set; }
        public string ArabaTipi { get; set; }
        public int KiralamaSayisi { get; set; }
        public bool KiradaMi { get; set; }

        public Araba(string plaka, string marka, int kiralamaBedeli, string arabaTipi)
        {
            Plaka = plaka;
            Marka = marka;
            KiralamaBedeli = kiralamaBedeli;
            ArabaTipi = arabaTipi;
            KiralamaSayisi = 0;
            KiradaMi = false;
        }
    }
}

