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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
             
             
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> urunadilist = new List<string>();          //Ürünleri list ve arrayleri kullanarak text file ye yerleştirdim
            List<string> urunadedilist = new List<string>();
            List<string> tedarikci = new List<string>();
            tedarikci.Add(tedarikeden.Text);
            urunadilist.Add(urunadi.Text);
            urunadedilist.Add(urunadedi.Text);
            string[] urunlerr = urunadilist.ToArray();
            string[] adett = urunadedilist.ToArray();
            string[] tedarikk = tedarikci.ToArray();
            string path = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stok.txt";
            string path2 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stokadedi.txt";
            string path3 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\tedarikciler.txt";
            File.AppendAllLines(path, urunlerr);
            File.AppendAllLines(path2,adett );
            File.AppendAllLines(path3, tedarikk);
            MessageBox.Show("Ürün Eklendi");

        }

        private void urunadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
