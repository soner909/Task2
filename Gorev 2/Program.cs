using System;

namespace Gorev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////Bir mağazada alınan ürünün fiyatı 100 TL ve üzerinde ise 5 TL olan kargo ücreti alınmamaktadır.
            ////Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren C# konsol uygulamasını yapalım.

            //Console.Write("Urun fiyatini giriniz: ");
            //int urunFiyat = int.Parse(Console.ReadLine());
            //int kargo = 5;

            //if (urunFiyat < 100)
            //{
            //    urunFiyat = urunFiyat + kargo;
            //    Console.WriteLine("Toplam odemeniz: " + urunFiyat + " TL'dir.");
            //}
            //else
            //{
            //    Console.WriteLine("Toplam odemeniz: " + urunFiyat + " TL'dir.");
            //}
            //Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise,
            ////2.üründen %25 indirim yaparak ödenecek tutarı gösteren C# konsol uygulamasını yapın.


            //Console.Write("1. urunun fiyatini girin: ");
            //int urun1 = int.Parse(Console.ReadLine());
            //Console.Write("2. urunun fiyatini girin: ");
            //int urun2 = int.Parse(Console.ReadLine());
            //double toplam = 0;


            //if (urun1 > urun2 && urun1+urun2 > 200)
            //{
            //    urun2 = urun2 - (urun2 / 4);
            //    toplam = urun1 + urun2;
            //}
            //else if( urun1 < urun2 && urun1+urun2 > 200)

            //{
            //    urun1 = urun1 - (urun1 / 4);
            //    toplam = urun1 + urun2;
            //}
            //else
            //{
            //    toplam = urun1 + urun2;
            //}
            //Console.WriteLine("Toplam odenecek tutar: " + toplam);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //int kare = 0;
            //int toplam = 0;

            //for(int i = 1; i < 26; i++)
            //{
            //    kare = i * i;
            //    toplam += kare; 
            //}

            //Console.WriteLine("1'den 25'e kadar olan sayilarin kareleri toplami: " + toplam );


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.Write("kac adet sayi gireceksiniz? :");
            //int adet = int.Parse(Console.ReadLine());
            //int cift = 0; int tek = 0;
            //int enBuyuk = 0;
            //int enKucuk = 0;

            //for (int i = 1; i <= adet; i++)
            //{

            //    Console.Write("{0}. sayiyi giriniz: ", i);
            //    int sayi = int.Parse(Console.ReadLine());


            //        if (sayi % 2 == 0)
            //        {
            //        cift++;

            //        }
            //        if (sayi % 2 == 1)
            //        {
            //        tek = adet - cift;

            //        }

            //    while (sayi > 0)
            //    {
            //        enBuyuk = sayi;
            //        enKucuk = sayi;


            //        if (sayi > enBuyuk)
            //        {
            //            sayi = enBuyuk;
            //        }
            //        if (sayi < enKucuk)
            //        {
            //            sayi = enKucuk;
            //        }
            //    }




            //}

            //Console.WriteLine("Girilen cift sayi adedi: " + cift);
            //Console.WriteLine("Girilen tek sayi adedi: " + tek);
            //Console.WriteLine("Girilen en buyuk sayi: " + enBuyuk);
            //Console.WriteLine("Girilen en kucuk sayi: " + enKucuk);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.Write("1. Sayiyi Girin: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayiyi Girin: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //int total = 0;
            //double avg = 0;
            //for(int i = num1; i <= num2 ; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        sayac++;
            //        total += i;
            //    }
            //    avg = total / sayac;
            //}
            //Console.WriteLine("Sayilar arasinda 3'e tam bolunen {0} tane sayi var.Ve bu sayilarin ortalamasi {1}'tur.", sayac , avg);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            ////int sayac = 0;
            ////int kalanSayfa=1000;
            ////int okunanSayfa = 10;
            ////while (kalanSayfa > 0)
            ////{
            ////    kalanSayfa = kalanSayfa - okunanSayfa;
            ////    okunanSayfa = okunanSayfa + 5;
            ////    sayac++;
            ////}



            ////Console.WriteLine("Furkan kitabi {0} gunde bitirmistir.", sayac);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.Write("Bir sayi girin: ");
            //int num = int.Parse(Console.ReadLine());
            //int check = 0;


            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        check++;


            //    }

            //}
            //if (check == 0)
            //{
            //    Console.WriteLine("Sayi asaldir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi asal degildir");
            //}
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Lutfen para miktarini giriniz: ");
            int money = int.Parse(Console.ReadLine());
            
            int sayac100 = 0;int sayac50 = 0;int sayac20 = 0;int sayac10= 0;

                if (money % 10 != 0)
                {
                    Console.WriteLine("En kucuk 10TL'lik banknot mevcut");
                    Console.Write("Lutfen para miktarini giriniz: ");
                    money = int.Parse(Console.ReadLine());
                }
            
            for (int i = 0; i <= money; i+=10)
            {
                sayac100 = money / 100;
                if(money < 100)
                {
                    sayac50 = 
                }
            }
                

                
                
            }
            Console.WriteLine("{0} adet 100 TL", sayac100);
            Console.WriteLine("{0} adet 50 TL", sayac50);
            Console.WriteLine("{0} adet 20 TL", sayac20);
            Console.WriteLine("{0} adet 10 TL", sayac10);

            //kalan = money - (sayac100 * 100);

            //for(int j = 0; j <= kalan; j+=50)
            //{
            // sayac50++;
            //}


            //int kalan2 = kalan - (sayac50 * 50);

            //for (int t = 0; t <= kalan2; t += 20)
            //{
            //    sayac20++;
            //}


            //int kalan3 = kalan2 - (sayac20 * 20);

            //for (int z = 0; z <= kalan3; z += 10)
            //{
            //    sayac10++;
            //}





        }

    }
}
