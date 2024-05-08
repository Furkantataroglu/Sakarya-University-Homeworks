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
    public class Cember
    {

        Nokta Merkez;
        double yariCap;
        public Cember()
        {
            Merkez = new Nokta();
            yariCap = 0;
        }
        public Cember(Nokta Merkez, double yariCap)
        {
            this.Merkez = Merkez;
            this.yariCap = yariCap;
        }
        public double YariCap { get => yariCap; set => yariCap = value; }
        public Nokta merkez { get => Merkez; set => Merkez = value; }
    }
}

