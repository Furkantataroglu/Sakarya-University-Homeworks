/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2021-2022 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........:Nesneye Dayal� Programlama Proje
**				��RENC� ADI............:Furkan Tataro�lu
**				��RENC� NUMARASI.......:G201210089
**                         DERS�N ALINDI�I GRUP...:2. ��retim C 
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

        private void button3_Click(object sender, EventArgs e)          //Sat�� Form
        {
            Satis satis=new Satis();
            satis.MdiParent = this;
            satis.Show();
        }
    }
}