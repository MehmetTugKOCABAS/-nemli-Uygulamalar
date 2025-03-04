using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    using System;
    using System.Collections.Generic;

    public class Otogaleri
    {
        private List<Araba> arabalar;

        public Otogaleri()
        {
            arabalar = new List<Araba>();
        }

        public void ArabaKirala(string plaka, int saat)
        {
            Araba araba = arabalar.Find(a => a.Plaka == plaka);
            if (araba == null)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
            }
            else if (araba.KiradaMi)
            {
                Console.WriteLine("Araba şu anda kirada. Farklı araba seçiniz.");
            }
            else
            {
                araba.KiradaMi = true;
                araba.KiralamaSayisi++;
                Console.WriteLine($"{plaka} plakalı araba {saat} saatliğine kiralandı.");
            }
        }

        public void ArabaTeslimAl(string plaka)
        {
            Araba araba = arabalar.Find(a => a.Plaka == plaka);
            if (araba == null)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
            }
            else if (!araba.KiradaMi)
            {
                Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
            }
            else
            {
                araba.KiradaMi = false;
                Console.WriteLine("Araba galeride beklemeye alındı.");
            }
        }

        public void KiradakiArabalariListele()
        {
            Console.WriteLine("Plaka\tMarka\tK. Bedeli\tAraba Tipi\tK. Sayısı\tDurum");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach (var araba in arabalar)
            {
                if (araba.KiradaMi)
                {
                    Console.WriteLine($"{araba.Plaka}\t{araba.Marka}\t{araba.KiralamaBedeli}\t\t{araba.ArabaTipi}\t\t{araba.KiralamaSayisi}\t\tKirada");
                }
            }
        }

        public void GaleridekiArabalariListele()
        {
            Console.WriteLine("Plaka\tMarka\tK. Bedeli\tAraba Tipi\tK. Sayısı\tDurum");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach (var araba in arabalar)
            {
                if (!araba.KiradaMi)
                {
                    Console.WriteLine($"{araba.Plaka}\t{araba.Marka}\t{araba.KiralamaBedeli}\t\t{araba.ArabaTipi}\t\t{araba.KiralamaSayisi}\t\tGaleride");
                }
            }
        }

        public void TumArabalariListele()
        {
            Console.WriteLine("Plaka\tMarka\tK. Bedeli\tAraba Tipi\tK. Sayısı\tDurum");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach (var araba in arabalar)
            {
                string durum = araba.KiradaMi ? "Kirada" : "Galeride";
                Console.WriteLine($"{araba.Plaka}\t{araba.Marka}\t{araba.KiralamaBedeli}\t\t{araba.ArabaTipi}\t\t{araba.KiralamaSayisi}\t\t{durum}");
            }
        }

        public void KiralamaIptali(string plaka)
        {
            Araba araba = arabalar.Find(a => a.Plaka == plaka);
            if (araba == null)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
            }
            else if (!araba.KiradaMi)
            {
                Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
            }
            else
            {
                araba.KiradaMi = false;
                Console.WriteLine("İptal gerçekleştirildi.");
            }
        }

        public void ArabaEkle(string plaka, string marka, int kiralamaBedeli, string arabaTipi)
        {
            if (arabalar.Exists(a => a.Plaka == plaka))
            {
                Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
            }
            else
            {
                arabalar.Add(new Araba(plaka, marka, kiralamaBedeli, arabaTipi));
                Console.WriteLine("Araba başarılı bir şekilde eklendi.");
            }
        }

        public void ArabaSil(string plaka)
        {
            Araba araba = arabalar.Find(a => a.Plaka == plaka);
            if (araba == null)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
            }
            else if (araba.KiradaMi)
            {
                Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
            }
            else
            {
                arabalar.Remove(araba);
                Console.WriteLine("Araba silindi.");
            }
        }

        public void GaleriBilgileri()
        {
            int toplamArabaSayisi = arabalar.Count;
            int kiradakiArabaSayisi = arabalar.Count(a => a.KiradaMi);
            int bekleyenArabaSayisi = toplamArabaSayisi - kiradakiArabaSayisi;
            int toplamKiralamaSuresi = arabalar.Sum(a => a.KiralamaSayisi);
            int toplamKiralamaAdedi = arabalar.Sum(a => a.KiralamaSayisi);
            int ciro = arabalar.Sum(a => a.KiralamaBedeli * a.KiralamaSayisi);

            Console.WriteLine("Toplam araba sayısı: " + toplamArabaSayisi);
            Console.WriteLine("Kiradaki araba sayısı: " + kiradakiArabaSayisi);
            Console.WriteLine("Bekleyen araba sayısı: " + bekleyenArabaSayisi);
            Console.WriteLine("Toplam araba kiralama süresi: " + toplamKiralamaSuresi);
            Console.WriteLine("Toplam araba kiralama adedi: " + toplamKiralamaAdedi);
            Console.WriteLine("Ciro: " + ciro);
        }
    }
}
