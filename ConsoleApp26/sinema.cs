using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class sinema
    {
        public string film { get; set; }
        public int kapasite { get; set; }
        public int tambiletfiya { get; set; }
        public int yarimbiletfiyat{ get; set; }
        public int tambiletadeti { get; set; }
        public int yarimbiletadeti { get; set; }
        public double ciro { get; set; }
        public int toplamboskoltuk { get; set; }
        public sinema(string Film,int Kapasite,int  Tambiletfiyat,int Yarimfiyat)
        {
            film = Film;
            kapasite = Kapasite;
            tambiletfiya = Tambiletfiyat;
            yarimbiletfiyat = Yarimfiyat;
        }
        public void biletsatisi(int tamadet,int yarimadet)
        {
            tambiletadeti += tamadet;
            yarimbiletadeti += yarimadet;
            
        }
        public void biletiade(int tamadet, int yarimadet)
        {
            tambiletadeti -= tamadet;
            yarimbiletadeti -= yarimadet;

        }
        public void cirohesapla()
        {
            ciro = (tambiletfiya * tambiletadeti) + (yarimbiletfiyat*yarimbiletadeti);
        }
        public void boskoltukhesapla()
        {
            toplamboskoltuk = kapasite - (tambiletadeti+yarimbiletadeti);
        }
    }

}
