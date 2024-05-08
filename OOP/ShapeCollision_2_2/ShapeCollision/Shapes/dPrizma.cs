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
    public class dPrizma
    {
        Nokta3D Merkez;
        double En;
        double Boy;
        double Derinlik;
        public dPrizma()
        {
            Merkez = new Nokta3D();
            En = 0;
            Boy = 0;
            Derinlik = 0;
        }
        public dPrizma(Nokta3D merkez, double en, double boy, double derinlik)
        {
            Merkez = merkez;
            En = en;
            Boy = boy;
            Derinlik = derinlik;
        }
        public Nokta3D merkez { get => Merkez; set => Merkez = value; }
        public double en { get => En; set => En = value; }
        public double boy { get => Boy; set => Boy = value; }
        public double derinlik { get => Derinlik; set => Derinlik = value; }
    }
}
