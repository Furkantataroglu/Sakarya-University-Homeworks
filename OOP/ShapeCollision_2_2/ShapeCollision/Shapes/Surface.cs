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
    public class Surface
    {

        public int Width { get; set; }
        public int Height { get; set; }

        public Surface(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void DrawBorders(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);

            e.Graphics.DrawLine(pen, 0, 0, Width, 0); // Üst kenar
            e.Graphics.DrawLine(pen, 0, 0, 0, Height); // Sol kenar
            e.Graphics.DrawLine(pen, Width, 0, Width, Height); // Sağ kenar
            e.Graphics.DrawLine(pen, 0, Height, Width, Height); // Alt kenar
        }
    }
}
