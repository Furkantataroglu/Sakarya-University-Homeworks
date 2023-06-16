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

namespace WinFormsApp1
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //Müşteri ekleme ve Satış yapma
        {
            string path = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\musteri.txt";
            List<string> musterii = new List<string>();
            List<string> musteridiger = new List<string>();
            musteridiger.Add(musterisoyad.Text + musteritel.Text + musteriadres.Text);
            musterii.Add(musteriad.Text);
           string[]musteriii=musteridiger.ToArray();
            string [] musteriler = musterii.ToArray();
            File.AppendAllLines(path, musteriler);
            File.AppendAllLines(path, musteriii);

            string path2 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stok.txt";
            string[] lines = File.ReadAllLines(path2);
            int count=0;
            for(int i = 0; i < lines.Length; i++)       //line uzunluğu bulma
            {
                if(lines[i]== textBox1.Text)
                {
                    count = i;

                }
            }
            string path3 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\stokadedi.txt";
            string[] lines3 = File.ReadAllLines(path3);

            int sonuc = Int32.Parse(lines3[count]) - Int32.Parse(textBox2.Text);
            //Yeterli Ürün Yoksa Uyarı
            if(sonuc < 0)                                                        
            {
                MessageBox.Show("Yeterli Sayıda Ürün Yok");
            }
            //Yeterli Ürün varsa satış
            else
            {
                string path4 = @"C:\Users\furka\Desktop\ndp\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\textfiles\satilanurunler.txt";
                lines3[count] = sonuc.ToString();
                File.WriteAllLines(path3, lines3);
                List<string> satis = new List<string>();
                satis.Add("Satılan Ürün :" + lines[count] +"        Kalan Adet : "+ sonuc + "        Satıldığı kişi : " + musteriad.Text +" "+musterisoyad.Text);
                string[] satisrapor = satis.ToArray();
                File.AppendAllLines(path4,satisrapor );
                MessageBox.Show("Satış Yapıldı");
            }
            





        }
       
  
    }
}
