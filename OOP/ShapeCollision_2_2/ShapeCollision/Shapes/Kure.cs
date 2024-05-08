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
    public class Kure
    {
        Nokta3D Merkez;
        double yariCap;
        public Kure()
        {
            Merkez = new Nokta3D();
            yariCap = 0;
        }
        public Kure(Nokta3D merkez, double yariCap)
        {
            Merkez = merkez;
            this.yariCap = yariCap;
        }
        public Nokta3D merkez { get => Merkez; set => Merkez = value; }
        public double YariCap { get => yariCap; set => yariCap = value; }
    }
}

