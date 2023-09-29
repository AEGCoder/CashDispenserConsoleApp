internal class Program
{
    private static void Main(string[] args)
    {



        int AnaPara = 2500;
        string GecerliSifre = "ab18";
        int girisHakki = 3;
        int secim = 0;

        Console.WriteLine("Bankamatik Uygulamasına Hoşgeldiniz");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Menü");
            Console.WriteLine("-----");
            AnaMenu:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Kartlı İşlem");
            Console.WriteLine("2. Kartsız İşlem");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz?");
            Console.ResetColor();
            secim = Convert.ToInt32(Console.ReadLine());
            // kartlı işlem bölümü
            if (secim == 1)

            {
               
                do
                {
                    Console.WriteLine("Lütfen şifrenizi giriniz");
                    string sifre = Console.ReadLine();
                    if (sifre == GecerliSifre)
                    {
                        girisHakki = 3;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("1 ) Para Çekmek için");
                            Console.WriteLine("2 ) Para Yatırmak için");
                            Console.WriteLine("3 ) Para Transferleri");
                            Console.WriteLine("4 ) Eğitim Ödemeleri");
                            Console.WriteLine("5 ) Ödemeler");
                            Console.WriteLine("6 ) Bilgi Güncelleme");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("9 ) Ana Menü");
                            Console.WriteLine("0 ) Çıkış");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz?");
                            Console.ResetColor();
                            secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz");
                                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                                if (cekilecekTutar <= AnaPara)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    AnaPara -= cekilecekTutar;
                                    Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Yetersiz bakiye");
                                    Console.ResetColor();
                                }
                            }
                            else if (secim == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("1) Kredi Kartına");
                                Console.WriteLine("2) Kendi Hesabınıza");
                                Console.ResetColor();
                                secim = Convert.ToInt32(Console.ReadLine());

                                if (secim == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Lütfen kredi kartı numarasını giriniz");
                                    Console.ResetColor();
                                    string kartNo = Console.ReadLine();
                                    if (kartNo.Length >= 12)
                                    {
                                        Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                                        int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                                        if (AnaPara >= yatirilacakTutar)
                                        {
                        
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            AnaPara -= yatirilacakTutar;

                                            Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Yetersiz bakiye");
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Kredi kartı numarası 12 haneli olmalıdır");
                                        Console.ResetColor();
                                    }
                                }
                                else if (secim == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                                    AnaPara += yatirilacakTutar;
                                    Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                    Console.ResetColor();
                                }
                                else
                                {   
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    Console.ResetColor();
                                }
                            }
                            else if (secim == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("1) Başka Hesaba EFT");
                                Console.WriteLine("2) Başka Hesaba Havale");
                                Console.ResetColor();
                                secim = Convert.ToInt32(Console.ReadLine());

                                if (secim == 1)
                                {
                                    Console.WriteLine("Lütfen EFT numarasını giriniz?");
                                    string eftNo = Console.ReadLine();
                                    if (eftNo.Length == 14 && eftNo.Substring(0, 2) == "tr")
                                    {
                                        Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz...");
                                        int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                                        if (AnaPara >= yatirilacakTutar)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            AnaPara -= yatirilacakTutar;
                                            Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Yetersiz bakiye");
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("EFT numarası 12 haneli olmalıdır ve tr ile başlamalıdır");
                                        Console.ResetColor();
                                    }
                                }
                                else if (secim == 2)
                                {
                                    Console.WriteLine("Lütfen hesap numarasını giriniz");
                                    string hesapNo = Console.ReadLine();
                                    if (hesapNo.Length == 11)
                                    {
                                        Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                                        int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                                        if (AnaPara >= yatirilacakTutar)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            AnaPara -= yatirilacakTutar;
                                            Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Yetersiz bakiye");
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Hesap numarası 11 haneli olmalıdır");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    Console.ResetColor();
                                }
                            }
                            else if (secim == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                                Console.ResetColor();
                            }
                            else if (secim == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1) Elektrik Faturası");
                                Console.WriteLine("2) Telefon Faturası");
                                Console.WriteLine("3) İnternet Faturası");
                                Console.WriteLine("4) Su Faturası");
                                Console.WriteLine("5) OGS Ödemeleri");
                                Console.ResetColor();
                                secim = Convert.ToInt32(Console.ReadLine());

                                if (secim >= 1 && secim <= 5)
                                {
                                    Console.WriteLine("Lütfen fatura tutarını giriniz");
                                    int faturaTutari = Convert.ToInt32(Console.ReadLine());
                                    if (AnaPara >= faturaTutari)
                                    {
                                       Console.ForegroundColor = ConsoleColor.Magenta;
                                        AnaPara -= faturaTutari;
                                        Console.WriteLine("Kalan bakiyeniz: " + AnaPara);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Yetersiz bakiye");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    Console.ResetColor();
                                }
                            }
                            else if (secim == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("1 ) Şifre Değiştirme");
                                Console.ResetColor();
                                secim = Convert.ToInt32(Console.ReadLine());
                                if (secim == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Yeni şifrenizi giriniz");
                                    GecerliSifre = Console.ReadLine();
                                    Console.WriteLine("Şifreniz başarıyla güncellendi.");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Hatalı seçim yaptınız");
                                    Console.ResetColor();
                                }
                            }
                            else if (secim == 9)
                            {
                                   goto AnaMenu;
                            }
                            else if (secim == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hatalı seçim yaptınız");
                                Console.ResetColor();
                            }
                        } while (true);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        girisHakki--;
                        Console.WriteLine("Şifreniz yanlış");
                        Console.WriteLine("Kalan giriş hakkınız: " + girisHakki);
                        Console.ResetColor();
                        if (girisHakki > 0)
                        {
                            Console.WriteLine("Tekrar şifre girin.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Giriş hakkınız tükendi. Çıkış yapılıyor...");
                            Environment.Exit(0);
                            Console.ResetColor();
                        }
                    }
                } while (girisHakki > 0);
            }
            // Kartsız işlem bölümü
            else if (secim == 2)
            {

                int kartsizSecim = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Kartsız İşlem Menüsü");
                    Console.WriteLine("-----");
                    Console.WriteLine("1. CepBank Para Çekmek");
                    Console.WriteLine("2. Para Yatırmak");
                    Console.WriteLine("3. Kredi Kartı Ödeme");
                    Console.WriteLine("4. Eğitim Ödemeleri");
                    Console.WriteLine("5. Ödemeler");
                    Console.WriteLine("9. Ana Menü");
                    Console.WriteLine("0. Çıkış");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.ResetColor();
                    kartsizSecim = Convert.ToInt32(Console.ReadLine());

                    if (kartsizSecim == 1)
                    {
                        int denemeHakki = 3;
                        bool dogruBilgi = false;

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("TC Kimlik Numarasını Giriniz:");
                            string tcKimlik = Console.ReadLine();

                            Console.WriteLine("Cep Telefonu Numarasını Giriniz:");
                            string cepTelefonu = Console.ReadLine();
                            Console.ResetColor();

                            // TC kimlik ve cep telefonu numarası doğruluğu kontrol edilir
                            if (tcKimlik.Length == 11 && cepTelefonu.Length == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                dogruBilgi = true;
                                AnaPara += 1000; // 1000 birim ödeme yapılır
                                Console.WriteLine("Ödeme başarıyla yapıldı. Yeni bakiye: " + AnaPara);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                denemeHakki--;
                                Console.WriteLine("Bilgiler yanlış. Kalan deneme hakkı: " + denemeHakki);
                                Console.ResetColor();
                                if (denemeHakki == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Deneme hakkınız tükendi. 1 saat boyunca işlem yapamayacaksınız.");
                                    Console.ResetColor();
                                    break; 
                                }
                            }
                        } while (!dogruBilgi);
                    }
                    else if (kartsizSecim == 2)
                    {
                        int altSecim2 = 0;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Para Yatırma Menüsü");
                            Console.WriteLine("-----");
                            Console.WriteLine("1. Nakit Ödeme");
                            Console.WriteLine("2. Hesaptan Ödeme");
                            Console.WriteLine("9. Ana Menü");
                            Console.WriteLine("0. Çıkış");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                            Console.ResetColor();
                            altSecim2 = Convert.ToInt32(Console.ReadLine());

                            if (altSecim2 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Kredi kartı numarasını giriniz:");
                                string kartNo = Console.ReadLine();
                                System.Console.WriteLine("Tc kimlik numarasını giriniz:");
                                string tcKimlik = Console.ReadLine();
                                Console.ResetColor();

                                if (kartNo.Length >= 12 && tcKimlik.Length == 11)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Ödeme işlemi gerçekleştiriliyor...");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Kredi kartı numarası en az 12 haneli olmalıdır ve TC kimlik numarası 11 haneli olmalıdır.");
                                    Console.ResetColor();
                                }
                            }
                            else if (altSecim2 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Kredi kartı numarasını giriniz:");
                                string kartNo = Console.ReadLine();
                                Console.WriteLine("Hesap numarasını giriniz:");
                                string hesapNo = Console.ReadLine();
                                Console.ResetColor();

                                if (kartNo.Length >= 12 && hesapNo.Length == 11)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Ödeme işlemi gerçekleştiriliyor...");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Kredi kartı numarası en az 12 haneli olmalıdır ve hesap numarası 11 haneli olmalıdır.");
                                    Console.ResetColor();
                                }
                            }
                            else if (altSecim2 == 9)
                            {
                                // Ana menüye dön
                                break;
                            }
                            else if (altSecim2 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hatalı seçim yaptınız");
                                Console.ResetColor();
                            }
                        } while (true);
                    }
                    else if (kartsizSecim == 3)
                    {
                        int kartsizSecim3 = 0;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Başka Hesaba İşlem Menüsü");
                            Console.WriteLine("-----");
                            Console.WriteLine("1. Başka Hesaba EFT");
                            Console.WriteLine("2. Başka Hesaba Havale");
                            Console.WriteLine("9. Ana Menü");
                            Console.WriteLine("0. Çıkış");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                            Console.ResetColor();
                            kartsizSecim3 = Convert.ToInt32(Console.ReadLine());

                            if (kartsizSecim3 == 1)
                            {
                                Console.WriteLine("EFT numarasını giriniz:...");
                                string eftNo = Console.ReadLine();

                                if (eftNo.Length == 14 && eftNo.StartsWith("tr", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine("Yatırılacak para miktarını giriniz:");
                                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                                    if (AnaPara >= yatirilacakTutar)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        AnaPara -= yatirilacakTutar;
                                        Console.WriteLine("EFT işlemi başarıyla gerçekleştirildi. Yeni bakiye: " + AnaPara);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Yetersiz bakiye");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("EFT numarası 14 haneli olmalıdır ve 'tr' ile başlamalıdır.");
                                    Console.ResetColor();
                                }
                            }
                            else if (kartsizSecim3 == 2)
                            {
                                Console.WriteLine("Hesap numarasını giriniz:");
                                string hesapNo = Console.ReadLine();

                                if (hesapNo.Length == 11)
                                {
                                    Console.WriteLine("Yatırılacak para miktarını giriniz:");
                                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

                                    if (AnaPara >= yatirilacakTutar)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        AnaPara -= yatirilacakTutar;
                                        Console.WriteLine("Havale işlemi başarıyla gerçekleştirildi. Yeni bakiye: " + AnaPara);
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Yetersiz bakiye");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Hesap numarası 11 haneli olmalıdır.");
                                    Console.ResetColor();
                                }
                            }
                            else if (kartsizSecim3 == 9)
                            {
                                // Ana menüye dön
                                break;
                            }
                            else if (kartsizSecim3 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hatalı seçim yaptınız");
                                Console.ResetColor();
                            }
                        } while (true);
                    }
                    else if (kartsizSecim == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eğitim Ödemeleri sayfası arızalı");
                        Console.ResetColor();
                    }
                    else if (kartsizSecim == 5)
                    {
                        int kartsizSecim5 = 0;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Fatura Ödeme Menüsü");
                            Console.WriteLine("-----");
                            Console.WriteLine("1. Elektrik Faturası");
                            Console.WriteLine("2. Telefon Faturası");
                            Console.WriteLine("3. İnternet Faturası");
                            Console.WriteLine("4. Su Faturası");
                            Console.WriteLine("5. OGS Ödemeleri");
                            Console.WriteLine("9. Ana Menü");
                            Console.WriteLine("0. Çıkış");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                            Console.ResetColor();
                            kartsizSecim5 = Convert.ToInt32(Console.ReadLine());

                            if (kartsizSecim5 >= 1 && kartsizSecim5 <= 5)
                            {
                                Console.WriteLine("Lütfen fatura tutarını giriniz?");
                                int faturaTutari = Convert.ToInt32(Console.ReadLine());

                                if (AnaPara >= faturaTutari)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    AnaPara -= faturaTutari;
                                    Console.WriteLine("Fatura ödeme işlemi başarıyla gerçekleştirildi. Yeni bakiye: " + AnaPara);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Yetersiz bakiye");
                                    Console.ResetColor();
                                }
                            }
                            else if (kartsizSecim5 == 9)
                            {
                                // Ana menüye dön
                                break;
                            }
                            else if (kartsizSecim5 == 0)
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hatalı seçim yaptınız");
                                Console.ResetColor();
                            }
                        } while (true);
                    }
                    else if (kartsizSecim == 9)
                    {
                        // Ana menüye dön
                        break;
                    }
                    else if (kartsizSecim == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Çıkış yapılıyor...");
                        Environment.Exit(0);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı seçim yaptınız");
                        Console.ResetColor();
                    }
                } while (true);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı seçim yaptınız");
                Console.ResetColor();
            }

        } while (true);







    }

}