/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Object oriented Programming Course
                                        Homework I

**				ÖĞRENCİ ADI............:Furkan Tataroğlu
**				ÖĞRENCİ NUMARASI.......:G201210089
**              DERSİN ALINDIĞI GRUP...:2. Öğretim C
****************************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Sifre             //Sifre bilgilerini tutacak olan class
{


    public static int buyukHarf = 0;
    public static int kucukHarf = 0;
    public static int numaraSayisi = 0;
    public static int sembolSayisi = 0;
    public static void sifreBilgiler(string sifre)     //kullanicidan sifreyi alacak olan fonksiyon
    {

        for (int i = 0; i < sifre.Length; i++)           //buyuk harf sayisi sayma
        {
            if (char.IsUpper(sifre[i]))
            {
                buyukHarf++;
            }

        }




        for (int i = 0; i < sifre.Length; i++)          //kucuk harf sayisi sayma
        {
            if (char.IsLower(sifre[i]))
            {
                kucukHarf++;
            }

        }




        for (int i = 0; i < sifre.Length; i++)              //rakam sayma
        {
            if (char.IsNumber(sifre[i]))
            {
                numaraSayisi++;
            }

        }




        for (int i = 0; i < sifre.Length; i++)                  //ozel karakter sayma
        {
            if (!char.IsNumber(sifre[i]) && !char.IsLower(sifre[i]) && !char.IsUpper(sifre[i]))
            {
                sembolSayisi++;
            }

        }



    }
}
namespace ÖDEV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;       //ana text rengi beyaz

            bool a = true;
            bool f = true;

            int puan = 0;


            while (a = true)
            {


                f = true;
                while (f == true)
                {
                    Sifre.buyukHarf = 0;                    //dongu tamamlandiginda puan resetlenecek
                    Sifre.kucukHarf = 0;
                    Sifre.sembolSayisi = 0;
                    Sifre.numaraSayisi = 0;
                    puan = 0;


                    Console.WriteLine("\n" + "Sifreniz en az 9 karakterli olmali ve en az bir adet buyuk harf, " +
                         "kucuk harf, rakam, sembol içermelidir, boşluk içermemelidir.");
                    Console.Write("Lutfen olusturmak istediginiz sifreyi giriniz: ");

                    string s = Console.ReadLine();
                    Sifre.sifreBilgiler(s);
                    for (int i = 0; i < Sifre.buyukHarf; ++i)        //puan sistemi
                    {
                        if (i < 2) { puan++; }
                    }

                    for (int i = 0; i < Sifre.kucukHarf; ++i)
                    {
                        if (i < 2) { puan++; }
                    }

                    for (int i = 0; i < Sifre.sembolSayisi; ++i)    //max 100 puan olmasi icin i<3
                    {
                        if (i < 3) { puan++; }
                    }

                    for (int i = 0; i < Sifre.numaraSayisi; ++i)
                    {
                        if (i < 2) { puan++; }
                    }

                    if (s.Length >= 9) { puan++; }


                    //sifrenin gecerli olup olmadigini kontrol edecek
                    if (s.Length < 9 || s.Contains(" ") || Sifre.buyukHarf < 1
                        || Sifre.kucukHarf < 1 || Sifre.sembolSayisi < 1 || Sifre.numaraSayisi < 1)
                    { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Sifreniz Gecerli Degil"); Console.ForegroundColor = ConsoleColor.White; f = false; }
                    //puanlama
                    if (puan < 7) { Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Genel puaniniz 70 puani gecmeli." + " Puaniniz: " + puan * 10); Console.ForegroundColor = ConsoleColor.White; }
                    if (puan >= 7 && puan < 9) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Sifreniz gecerli." + " Puaniniz: " + puan * 10); Console.ForegroundColor = ConsoleColor.White; }
                    if (puan >= 9 && puan <= 10) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Sifreniz gecerli ve guclu." + " Puaniniz: " + puan * 10); Console.ForegroundColor = ConsoleColor.White; }
                    //ekrana bilgileri yazma
                    Console.WriteLine("Buyuk Harf Sayisi: " + Sifre.buyukHarf);
                    Console.WriteLine("Kucuk Harf Sayisi: " + Sifre.kucukHarf);
                    Console.WriteLine("Rakam Sayisi: " + Sifre.numaraSayisi);
                    Console.WriteLine("Ozel Karakter Sayisi: " + Sifre.sembolSayisi);











                }
            }
            Console.ReadLine();

        }
    }
}

