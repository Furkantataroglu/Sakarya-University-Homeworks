/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…...:2
**				ÖĞRENCİ ADI...............:Furkan Tataroğlu
**				ÖĞRENCİ NUMARASI.: G201210089
**				DERS GRUBU…………: 1. ÖĞRETİM C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCollision.Shapes
{
    public static class Carpisma
    {
        public static bool KureKure(Kure kure1, Kure kure2)
        {
            float Uzaklik = (float)Math.Sqrt(Math.Pow(kure1.merkez.X - kure2.merkez.X, 2) + Math.Pow(kure1.merkez.Y - kure2.merkez.Y, 2) + Math.Pow(kure1.merkez.Z - kure2.merkez.Z, 2));

            //CARPISMA KONTROL
            if (kure1.YariCap + kure2.YariCap > (double)Uzaklik)
                return true;
            else
                return false;
        }
        public static bool DprizmaDprizma(dPrizma dPrizma1, dPrizma dPrizma2)
        {
            double x1 = dPrizma1.merkez.X + dPrizma1.en / 2;
            double x2 = dPrizma2.merkez.X + dPrizma2.en / 2;
            double y1 = dPrizma1.merkez.Y + dPrizma1.boy / 2;
            double y2 = dPrizma2.merkez.Y + dPrizma2.boy / 2;
            double z1 = dPrizma1.merkez.Z + dPrizma1.derinlik / 2;
            double z2 = dPrizma2.merkez.Z + dPrizma2.derinlik / 2;

            //CARPISMA KONTROL
            if (Math.Abs(x1 - x2) < (dPrizma1.en / 2 + dPrizma2.en / 2) && Math.Abs(y1 - y2) < (dPrizma1.boy / 2 + dPrizma2.boy / 2) && Math.Abs(z1 - z2) < (dPrizma1.derinlik / 2 + dPrizma2.derinlik / 2))
                return true;
            else
                return false;
        }
        public static bool SilindirSilindir(Silindir silindir1, Silindir silindir2)
        {
            Nokta3D nokta1 = new Nokta3D(silindir1.merkez.X, silindir1.merkez.Y + silindir1.yukseklik / 2, silindir1.merkez.Z);
            Nokta3D nokta2 = new Nokta3D(silindir2.merkez.X, silindir2.merkez.Y + silindir2.yukseklik / 2, silindir2.merkez.Z);
            float Uzaklik = (float)Math.Sqrt(Math.Pow(nokta1.X - nokta2.X, 2) + Math.Pow(nokta1.Y - nokta2.Y, 2) + Math.Pow(nokta1.Z - nokta2.Z, 2));

            //CARPISMA KONTROL
            if (silindir1.YariCap + silindir2.YariCap > Uzaklik && Math.Abs(nokta1.Y - nokta2.Y) < ((silindir1.yukseklik + silindir2.yukseklik) / 2))
                return true;
            else
                return false;
        }
        public static bool DikdortgenDikdortgen(Dikdortgen dikdortgen1, Dikdortgen dikdortgen2)
        {
            double x1 = dikdortgen1.merkez.X + dikdortgen1.en / 2;
            double x2 = dikdortgen2.merkez.X + dikdortgen2.en / 2;
            double y1 = dikdortgen1.merkez.Y + dikdortgen1.boy / 2;
            double y2 = dikdortgen2.merkez.Y + dikdortgen1.boy / 2;

            //CARPISMA KONTROL
            if (Math.Abs(x1 - x2) < (dikdortgen1.en / 2 + dikdortgen2.en / 2) && Math.Abs(y1 - y2) < (dikdortgen1.boy / 2 + dikdortgen2.boy / 2))
                return true;
            else
                return false;
        }
        public static bool NoktaKure(Nokta nokta, Kure kure)
        {
            float Uzaklik = (float)Math.Sqrt(Math.Pow(kure.merkez.X - nokta.X, 2) + Math.Pow(kure.merkez.Y - nokta.Y, 2));

            // Çarpışma Kontrolü
            if (kure.YariCap > Uzaklik)
                return true;
            else
                return false;
        }
        public static bool KureSilindir(Kure kure, Silindir silindir)
        {
            //CARPISMA KONTROL
            if (kure.YariCap + silindir.YariCap > Math.Abs(kure.merkez.X - silindir.merkez.X) && kure.YariCap + silindir.yukseklik / 2 > Math.Abs(kure.merkez.Y - silindir.merkez.Y) && kure.YariCap + silindir.YariCap > Math.Abs(kure.merkez.Z - silindir.merkez.Z))
                return true;
            else
                return false;
        }
        public static bool NoktaDikdortgen(Nokta nokta, Dikdortgen dikdortgen)
        {
            double dikdortgenX = dikdortgen.merkez.X;
            double dikdortgenY = dikdortgen.merkez.Y;

            // Noktanın dikdörtgenin içinde olup olmadığını kontrol et
            if (nokta.X >= dikdortgenX - dikdortgen.en / 2 &&
                nokta.X <= dikdortgenX + dikdortgen.en / 2 &&
                nokta.Y >= dikdortgenY - dikdortgen.boy / 2 &&
                nokta.Y <= dikdortgenY + dikdortgen.boy / 2)
            {
                return true;
            }

            return false;
        }
        public static bool NoktaDikdortgen(Nokta nokta, dPrizma dikdortgen)
        {
            double dikdortgenX = dikdortgen.merkez.X;
            double dikdortgenY = dikdortgen.merkez.Y;

            // Noktanın dikdörtgenin içinde olup olmadığını kontrol et
            if (nokta.X >= dikdortgenX - dikdortgen.en / 2 &&
                nokta.X <= dikdortgenX + dikdortgen.en / 2 &&
                nokta.Y >= dikdortgenY - dikdortgen.boy / 2 &&
                nokta.Y <= dikdortgenY + dikdortgen.boy / 2)
            {
                return true;
            }

            return false;
        }
        public static bool KureYuzey(Kure kure, dPrizma Yuzey)
        {
            double minY = kure.merkez.Y - kure.YariCap;
            double maxY = kure.merkez.Y + kure.YariCap;

            //CARPISMA KONTROL
            if (minY < Yuzey.merkez.Y && Yuzey.merkez.Y < maxY)
                return true;
            else
                return false;
        }
        public static bool NoktaCember(Nokta nokta, Cember cember)
        {
            float Uzaklik = (float)Math.Sqrt(Math.Pow(cember.merkez.X - nokta.X, 2) + Math.Pow(cember.merkez.Y - nokta.Y, 2));

            //CARPISMA KONTROL
            if (cember.YariCap > Uzaklik)
                return true;
            else
                return false;
        }
        public static bool KureDprizma(Kure kure, dPrizma dPrizma)
        {
            //CARPISMA KONTROL
            if (kure.YariCap + dPrizma.en / 2 > Math.Abs(kure.merkez.X - dPrizma.merkez.X) && kure.YariCap + dPrizma.boy / 2 > Math.Abs(kure.merkez.Y - dPrizma.merkez.Y) && kure.YariCap + dPrizma.derinlik / 2 > Math.Abs(kure.merkez.Z - dPrizma.merkez.Z))
                return true;
            else
                return false;
        }
        public static bool kureDikdortgen(Kure kure, Dikdortgen dikdortgen)
        {
            //CARPISMA KONTROL
            if (kure.YariCap + dikdortgen.en / 2 > Math.Abs(kure.merkez.X - dikdortgen.merkez.X) && kure.YariCap + dikdortgen.boy / 2 > Math.Abs(kure.merkez.Y - dikdortgen.merkez.Y))
                return true;
            else
                return false;
        }
        public static bool CemberDikdortgen(Cember cember, Dikdortgen dikdortgen)
        {
            //CARPISMA KONTROL
            if (cember.YariCap + dikdortgen.en > Math.Abs(cember.merkez.X - dikdortgen.merkez.X) && cember.YariCap + dikdortgen.boy > Math.Abs(cember.merkez.Y - dikdortgen.merkez.Y))
                return true;
            else
                return false;
        }
        public static bool CemberCember(Cember cember1, Cember cember2)
        {
            float Uzaklik = (float)Math.Sqrt(Math.Pow(cember1.merkez.X - cember2.merkez.X, 2) + Math.Pow(cember1.merkez.Y - cember2.merkez.Y, 2));

            //CARPISMA KONTROL
            if (cember1.YariCap + cember2.YariCap > Uzaklik)
                return true;
            else
                return false;
        }
        public static bool NoktaDprizma(Nokta nokta, dPrizma dPrizma)
        {
            double minX = dPrizma.merkez.X - dPrizma.en / 2;
            double maxX = dPrizma.merkez.X + dPrizma.en / 2;
            double minY = dPrizma.merkez.Y - dPrizma.boy / 2;
            double maxY = dPrizma.merkez.Y + dPrizma.boy / 2;

            // Çarpışma kontrolü
            if (minY < nokta.Y && nokta.Y < maxY && minX < nokta.X && nokta.X < maxX)
                return true;
            else
                return false;
        }
        public static bool NoktaSilindir(Nokta nokta, Silindir silindir)
        {
            double minX = silindir.merkez.X - silindir.YariCap;
            double maxX = silindir.merkez.X + silindir.YariCap;
            double minY = silindir.merkez.Y - silindir.yukseklik / 2;
            double maxY = silindir.merkez.Y + silindir.yukseklik / 2;

            //CARPISMA KONTROL
            if (minY < nokta.Y && nokta.Y < maxY && minX < nokta.X && nokta.X < maxX)
                return true;
            else
                return false;
        }
        public static bool SilindirYuzey(Silindir silindir, dPrizma Yuzey)
        {
            double minY = silindir.merkez.Y - silindir.yukseklik / 2;
            double maxY = silindir.merkez.Y + silindir.yukseklik / 2;

            //CARPISMA KONTROL
            if (minY < Yuzey.merkez.Y && Yuzey.merkez.Y < maxY)
                return true;
            else
                return false;
        }
        public static bool dPrizmaYuzey(dPrizma dPrizma, dPrizma Yuzey)
        {
            double minY = dPrizma.merkez.Y - dPrizma.boy / 2;
            double maxY = dPrizma.merkez.Y + dPrizma.boy / 2;

            //CARPISMA KONTROL
            if (minY < Yuzey.merkez.Y && Yuzey.merkez.Y < maxY)
                return true;
            else
                return false;
        }
    }
}
