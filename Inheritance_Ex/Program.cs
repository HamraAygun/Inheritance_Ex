using Inheritance_Ex;
using System;
using System.Collections;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Kiralık_Ev Kiralıkev1 = new Kiralık_Ev();

        Kiralıkev1.Şehir = "İstanbul";
        Kiralıkev1.KiralamaFiyatı = 7000;
        Kiralıkev1.EşyaDurumu = 'E';
        Kiralıkev1.BulunduğuKat = 3;
        Kiralıkev1.EmlakTipi = "Kiralık";
        Kiralıkev1.BinaYaşı = 5;
        Kiralıkev1.DepozitoBedeli = 3000;
        Kiralıkev1.OdaSayısı = "3+1";
        Kiralıkev1.m2 = 150;


        Satilik_Ev Satilikev1= new Satilik_Ev();

        Satilikev1.EmlakTipi = "Satılık";
        Satilikev1.İpotekDurumu = 'H';
        Satilikev1.BulunduğuKat = 5;
        Satilikev1.Şehir = "İzmir";
        Satilikev1.BinaYaşı = 2;
        Satilikev1.DepremRiski = 'H';
        Satilikev1.TapuHarcıYüzdesi = "%4";
        Satilikev1.m2 = 200;
        Satilikev1.Fiyat = 2000000;

        Satilik_Ev Satilikev2= new Satilik_Ev();

        Satilikev2.EmlakTipi = "Satılık";
        Satilikev2.İpotekDurumu = 'H';
        Satilikev2.BulunduğuKat = 3;
        Satilikev2.Şehir = "İzmir";
        Satilikev2.BinaYaşı = 1;
        Satilikev2.DepremRiski = 'H';
        Satilikev2.TapuHarcıYüzdesi = "%4";
        Satilikev2.m2 = 150;
        Satilikev2.Fiyat = 3000000;


        Console.WriteLine("Kiralık evi görmek için 1, Satılık evleri görmek için 2 tuşuna basınız.");
        int a;
        a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("Bulunduğu Şehir:" + Kiralıkev1.Şehir + "Kiralama Fiyatı:" + Kiralıkev1.KiralamaFiyatı + "Eşya Durumu" + Kiralıkev1.EşyaDurumu + "Bulunduğu Kat" + Kiralıkev1.BulunduğuKat);
            break;

            case 2:
                Console.WriteLine("İzmir'deki satılık ev için 1, İstanbul'daki ev için 2'ye basınız.");

                int b;
                b = Convert.ToInt32(Console.ReadLine());

                switch (b)
                {
                    case 1:
                        Console.WriteLine("Evin Fiyatı:" + Satilikev1.Fiyat + " " + "Bulunduğu Kat:" + Satilikev1.BulunduğuKat + " " + "Evin M2'si:" + Satilikev1.m2 + " " +  "Tapu Harcı Yüzdesi:" + Satilikev1.TapuHarcıYüzdesi);
                    break;

                    case 2:
                        Console.WriteLine("Evin Fiyatı:" + Satilikev2.Fiyat + " " + "Bulunduğu Kat:" + Satilikev2.BulunduğuKat + " " + "Evin M2'si:" + Satilikev2.m2 + " " + "m2" + " " +  "Tapu Harcı Yüzdesi:" + Satilikev2.TapuHarcıYüzdesi);
                        break;
                }
                break;
        }
        Console.ReadKey ();
    }
}