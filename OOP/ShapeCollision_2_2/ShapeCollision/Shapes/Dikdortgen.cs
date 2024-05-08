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
    public class Dikdortgen
    {
        Nokta Merkez;
        double En;
        double Boy;
        public double xHizi;
        public  double yHizi;
        public Dikdortgen()
        {
            Merkez = new Nokta();
            En = 100;
            Boy = 500;
            xHizi = 3;
            yHizi = 3;
        }
        public Dikdortgen(Nokta merkez, double en, double boy, double xhiz, double yhiz)
        {
            Merkez = merkez;
            En = en;
            Boy = boy;
            xHizi = xhiz;
            yHizi = yhiz;
        }
        public Nokta merkez { get => Merkez; set => Merkez = value; }
        public double boy { get => Boy; set => Boy = value; }
        public double en { get => En; set => En = value; }
        
        
    }
}
