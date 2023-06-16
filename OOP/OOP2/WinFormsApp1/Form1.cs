/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2021-2022 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........:Nesneye Dayalý Programlama Proje
**				ÖÐRENCÝ ADI............:Furkan Tataroðlu
**				ÖÐRENCÝ NUMARASI.......:G201210089
**                         DERSÝN ALINDIÐI GRUP...:2. Öðretim C 
****************************************************************************/

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)          //Stok Form
        {
            stok stok=new stok();
            stok.MdiParent = this;
            stok.Show();

        }

        private void button2_Click(object sender, EventArgs e)          //Rapor Form
        {
            Rapor rapor=new Rapor();
            rapor.MdiParent = this;
            rapor.Show();
        }

        private void button3_Click(object sender, EventArgs e)          //Satýþ Form
        {
            Satis satis=new Satis();
            satis.MdiParent = this;
            satis.Show();
        }
    }
}