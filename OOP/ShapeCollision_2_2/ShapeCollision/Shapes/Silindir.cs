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
    public class Silindir
    {
        Nokta3D Merkez;
        double yariCap;
        double Yukseklik;
        public Silindir()
        {
            Merkez = new Nokta3D();
            yariCap = 0;
            Yukseklik = 0;
        }
        public Silindir(Nokta3D merkez, double yariCap, double yukseklik)
        {
            Merkez = merkez;
            this.yariCap = yariCap;
            Yukseklik = yukseklik;
        }
        public Nokta3D merkez { get => Merkez; set => Merkez = value; }
        public double YariCap { get => yariCap; set => yariCap = value; }
        public double yukseklik { get => Yukseklik; set => Yukseklik = value; }
    }
}

