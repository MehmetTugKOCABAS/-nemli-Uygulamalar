namespace ConsoleApp26
{
    internal class Program
    {
        static sinema SNM;
        static void Main(string[] args)
        {
            uygulama();
        }
        static void uygulama()
        {
            kurulum();
            menu();
            while (true)
            { 
                string secim = secimal();
                switch (secim)
                {
                    case "1":
                    case "S":
                        biletsat();
                        break;
                    case "2":
                    case "R":
                        biletiade();
                        break;
                    case "3":
                    case "D":
                        durumbilgisi();
                        break;
                    case "4":
                    case "X":
                        cikis();
                        break;
                }
            }
        }
        static void kurulum()
        {
            
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film Adi:");
            string filmadi = Console.ReadLine();
            Console.Write("Kapasite:");
            int kapasite =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Tam bilet fiyati:");
            int tam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yarim bilet fiyati:");
            int yarim = Convert.ToInt32(Console.ReadLine());
             SNM = new sinema(filmadi, kapasite, tam, yarim);
        }  
        static void menu()
        {
           Console.WriteLine("1 - Bilet Sat(S)      ");
           Console.WriteLine("2 - Bilet İade(R)     ");
           Console.WriteLine("3 - Durum Bilgisi(D)  ");
           Console.WriteLine("4 - Çıkış(x)          ");
            Console.WriteLine();
        }
        static string secimal()
        {
            string karakterler = "1234SRDX";
            int sayac = 0;

            while (true)
            {
                sayac++;
                Console.Write("Seciminiz : ");
                string giris = Console.ReadLine().ToUpper();
                int index = karakterler.IndexOf(giris);

                if (index >= 0 && giris.Length == 1)
                {
                    return giris;
                }
                else
                {
                    if (sayac == 10)
                    {
                        Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                        Environment.Exit(0);
                    }
                    Console.WriteLine();

                }
                Console.WriteLine();
            }
        }
        static void biletsat()
        {       
            
            Console.WriteLine("Bilet Sat:  ");
            Console.Write("Tam Bilet Adedi: ");
            int tamadet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi: ");
            int yarimadet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem gerçekleştirildi: ");
            SNM.biletsatisi(tamadet,yarimadet);
        }
        static void biletiade()
        {
            Console.WriteLine("Bilet Iade:  ");
            Console.Write("Tam Bilet Adedi: ");
            int tamadet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi: ");
            int yarimadet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem gerçekleştirildi: ");
            SNM.biletiade(tamadet,yarimadet);

        }
        static void durumbilgisi()
        {
            SNM.cirohesapla();
            SNM.boskoltukhesapla();
            Console.WriteLine("Durum Bilgisi:  ");
            Console.WriteLine("Film: "+SNM.film);
            Console.WriteLine("Kapasite: "+SNM.kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : "+SNM.tambiletfiya);
            Console.WriteLine("Yarım Bilet Fiyatı : "+SNM.yarimbiletfiyat);
            Console.WriteLine("Toplam Tam Bilet Adedi: "+SNM.tambiletadeti);
            Console.WriteLine("Toplam Yarım Bilet Adedi: "+SNM.yarimbiletadeti);
            Console.WriteLine("Ciro: "+SNM.ciro);
            Console.WriteLine("Boş Koltuk Adedi: "+SNM.toplamboskoltuk);
        }
        static void cikis()
        {
            Environment.Exit(0);
        }
    }
}
