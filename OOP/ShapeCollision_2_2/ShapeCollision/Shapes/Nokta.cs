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
    public class Nokta
    {

        public double x;
        public double y;
        public Nokta()
        {
            x = 0;
            y = 0;
        }
        public Nokta(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
}
