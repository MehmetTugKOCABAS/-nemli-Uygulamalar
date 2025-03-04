namespace ConsoleApp27
{
    internal class Program
    {


    
        static Otogaleri otogaleri = new Otogaleri();
        static int hataliGirisSayisi = 0;
        static bool devam = true;

        static void Main(string[] args)
        {
            ProgramIslemleri();
        }

        static void ProgramIslemleri()
        {
            while (devam)
            {
                MenuGoster();
                string secim = Console.ReadLine().ToUpper();

                switch (secim)
                {
                    case "1":
                    case "K":
                        ArabaKirala();
                        break;

                    case "2":
                    case "T":
                        ArabaTeslimAl();
                        break;

                    case "3":
                    case "R":
                        KiradakiArabalariListele();
                        break;

                    case "4":
                    case "M":
                        GaleridekiArabalariListele();
                        break;

                    case "5":
                    case "A":
                        TumArabalariListele();
                        break;

                    case "6":
                    case "I":
                        KiralamaIptali();
                        break;

                    case "7":
                    case "Y":
                        ArabaEkle();
                        break;

                    case "8":
                    case "S":
                        ArabaSil();
                        break;

                    case "9":
                    case "G":
                        GaleriBilgileri();
                        break;

                    default:
                        HataliGiris();
                        break;
                }

                if (hataliGirisSayisi >= 10)
                {
                    Console.WriteLine("10 adet yanlış giriş yapıldı. Program sonlandırılıyor.");
                    devam = false;
                }

                Console.WriteLine();
            }
        }

        static void MenuGoster()
        {
            Console.WriteLine("Galeri Otomasyon");
            Console.WriteLine("1- Araba Kirala (K)");
            Console.WriteLine("2- Araba Teslim Al (T)");
            Console.WriteLine("3- Kiradaki Arabaları Listele (R)");
            Console.WriteLine("4- Galerideki Arabaları Listele (M)");
            Console.WriteLine("5- Tüm Arabaları Listele (A)");
            Console.WriteLine("6- Kiralama İptali (I)");
            Console.WriteLine("7- Araba Ekle (Y)");
            Console.WriteLine("8- Araba Sil (S)");
            Console.WriteLine("9- Bilgileri Göster (G)");
            Console.Write("Seçiminiz: ");
        }

        static void ArabaKirala()
        {
            Console.Write("Kiralanacak arabanın plakası: ");
            string plakaKirala = Console.ReadLine();
            Console.Write("Kiralanma süresi: ");
            int saat;
            if (int.TryParse(Console.ReadLine(), out saat))
            {
                otogaleri.ArabaKirala(plakaKirala, saat);
            }
            else
            {
                HataliGiris();
            }
        }

        static void ArabaTeslimAl()
        {
            Console.Write("Teslim edilecek arabanın plakası: ");
            string plakaTeslim = Console.ReadLine();
            otogaleri.ArabaTeslimAl(plakaTeslim);
        }

        static void KiradakiArabalariListele()
        {
            otogaleri.KiradakiArabalariListele();
        }

        static void GaleridekiArabalariListele()
        {
            otogaleri.GaleridekiArabalariListele();
        }

        static void TumArabalariListele()
        {
            otogaleri.TumArabalariListele();
        }

        static void KiralamaIptali()
        {
            Console.Write("Kiralaması iptal edilecek arabanın plakası: ");
            string plakaIptal = Console.ReadLine();
            otogaleri.KiralamaIptali(plakaIptal);
        }

        static void ArabaEkle()
        {
            Console.Write("Plaka: ");
            string plakaEkle = Console.ReadLine();
            Console.Write("Marka: ");
            string markaEkle = Console.ReadLine();
            Console.Write("Kiralama Bedeli: ");
            int bedel;
            if (int.TryParse(Console.ReadLine(), out bedel))
            {
                Console.WriteLine("Araba Tipi:");
                Console.WriteLine("SUV için 1");
                Console.WriteLine("Hatchback için 2");
                Console.WriteLine("Sedan için 3");
                Console.Write("Araba Tipi: ");
                int tip;
                if (int.TryParse(Console.ReadLine(), out tip))
                {
                    string arabaTipi = tip == 1 ? "SUV" : tip == 2 ? "Hatchback" : tip == 3 ? "Sedan" : "";
                    if (arabaTipi != "")
                    {
                        otogaleri.ArabaEkle(plakaEkle, markaEkle, bedel, arabaTipi);
                    }
                    else
                    {
                        HataliGiris();
                    }
                }
                else
                {
                    HataliGiris();
                }
            }
            else
            {
                HataliGiris();
            }
        }

        static void ArabaSil()
        {
            Console.Write("Silinmek istenen araba plakasını girin: ");
            string plakaSil = Console.ReadLine();
            otogaleri.ArabaSil(plakaSil);
        }

        static void GaleriBilgileri()
        {
            otogaleri.GaleriBilgileri();
        }

        static void HataliGiris()
        {
            Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
            hataliGirisSayisi++;
        }
    }
}

