/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Nesneye Dayalı Programlama Proje
**				ÖĞRENCİ ADI............:Furkan Tataroğlu
**				ÖĞRENCİ NUMARASI.......:G201210089
**                         DERSİN ALINDIĞI GRUP...:2. Öğretim C 
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          //Stok Durumu Raporu List
        {
            ListBox.Items.Clear();
            string path = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stok.txt";
            string[] lines = File.ReadAllLines(path);
            string path2 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stokadedi.txt";
            string[]lines2 = File.ReadAllLines(path2);
            string bosluk = "   ";
            string bosluk2 = " ";
            string adet = "Adet";
            
            for (int i = 0; i < lines.Length; i++)
            {
                 ListBox.Items.Add(lines[i] + bosluk + Int32.Parse(lines2[i])+bosluk2+adet );
            }
        }

        private void button2_Click(object sender, EventArgs e)         //Satış Raporu List
        {
            ListBox.Items.Clear();
            string path = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\satilanurunler.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                ListBox.Items.Add(lines[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            string path = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stok.txt";
            string[] lines = File.ReadAllLines(path);
            
            string path2 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stokadedi.txt";
            string[] lines2 = File.ReadAllLines(path2);

            string path3 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\tedarikciler.txt";
            string[] lines3= File.ReadAllLines(path3);
            string bosluk = "   ";
            string bosluk2 = " ";
            string adet = "Adet";

            for (int i = 0; i < lines.Length; i++)
            {
                ListBox.Items.Add(lines[i] + bosluk + Int32.Parse(lines2[i]) + bosluk2 + adet + bosluk+ bosluk + "Tedarikçi : "+lines3[i]);
            }
        }
    }
}
