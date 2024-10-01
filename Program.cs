using System;

class Program
{
    static void Main()
    {
        int bakiye = 8400;

        Console.WriteLine("QNB'ye Hoşgeldiniz");

        while (true)
        {
            Console.WriteLine("\nHangi işlemi yapmak istiyorsunuz?");
            Console.WriteLine("1. Bakiye Sorma");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Para Yatırma");
            Console.WriteLine("4. Çıkış");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Kalan Bakiyeniz: " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                int cekilecektutar;

                if (int.TryParse(Console.ReadLine(), out cekilecektutar))
                {
                    if (cekilecektutar > bakiye)
                    {
                        Console.WriteLine("Geçersiz tutar girdiniz. Yetersiz bakiye.");
                    }
                    else
                    {
                        bakiye -= cekilecektutar;
                        Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                int yatirilacaktutar;

                if (int.TryParse(Console.ReadLine(), out yatirilacaktutar))
                {
                    bakiye += yatirilacaktutar;
                    Console.WriteLine("Yeni bakiyeniz: " + bakiye);
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir tutar giriniz.");
                }
            }
            else if (secim == "4")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor.");
                break;
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
            }

            // Başka bir işlem yapmak isteyip istemediğini sor
            Console.WriteLine("\nBaşka bir işlem yapmak istiyor musunuz? (E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap != "E")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor.");
                break;
            }
        }

        Console.ReadLine(); // Uygulamanın kapanmasını önlemek için
    }
}
