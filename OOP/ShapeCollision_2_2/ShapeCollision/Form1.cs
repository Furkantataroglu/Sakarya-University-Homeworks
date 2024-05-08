/****************************************************************************
**					SAKARYA �N�VERS�TES�
**			         B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				          PROGRAMLAMAYA G�R��� DERS�
**	
**				�DEV NUMARASI�...:2
**				��RENC� ADI...............:Furkan Tataro�lu
**				��RENC� NUMARASI.: G201210089
**				DERS GRUBU����: 1. ��RET�M C
****************************************************************************/
namespace ShapeCollision;

using ShapeCollision.Shapes;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class Form1 : Form
{
    Sekiller sekiller = new Sekiller()
    {

        nokta = new Nokta(500, 100),

        nokta3d = new Nokta3D(5, -7, 4),

        silindir = new Silindir(new Nokta3D(75, 75, -0), 40, 80),

        cember = new Cember(new Nokta(400, 150), 40),

        dikdortgenler = new List<Dikdortgen>()
        {
        new Dikdortgen(new Nokta(75, 75), 70, 140,5,5),
        new Dikdortgen(new Nokta(400, 150), 70, 140,6,6)
        },

        kure = new Kure(new Nokta3D(75, 75, 0), 55),

        dPrizma = new dPrizma(new Nokta3D(75, 75, 0), 70, 140, 3),


    };
    Silindir silindir = new Silindir(new Nokta3D(400, 150, 0), 40, 80);
    Cember cember2 = new Cember(new Nokta(75, 75), 40);
    Kure kure2 = new Kure(new Nokta3D(400, 150, 0), 25);
    dPrizma dPrizma = new dPrizma(new Nokta3D(400, 150, 0), 70, 140, 3);

    private Surface surface;
    private Timer timer = new Timer();
    public Form1()
    {
        InitializeComponent();
        surface = new Surface(800, 400);
        // Timer ayarlar�
        timer.Interval = 20; // Her 20 milisaniyede bir Timer'� tetikleye
        timer.Tick += Timer_Tick;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged; //combobox de�i�ti�inde ekrandakilerin silinmesi i�in

    }


    private void Timer_Tick(object sender, EventArgs e)
    {
        // Se�ilen �ekillere g�re hareket i�lemini ger�ekle�tirin
        if (dikdortgenCizilsinMi)
        {
            if (Carpisma.DikdortgenDikdortgen(sekiller.dikdortgenler[0], sekiller.dikdortgenler[1]))
                label2.Text = "Dikd�rtgen-Dikd�rtgen �arp���yor";
            else label2.Text = "�arp��ma Yok";
            UpdateRectangleMovement(sekiller.dikdortgenler[0], sekiller.dikdortgenler[1]);
        }
        else if (noktadikdortgenCizilsinMi)
        {
            if (Carpisma.NoktaDikdortgen(sekiller.nokta, sekiller.dikdortgenler[0]))
                label2.Text = "Dikd�rtgen-Nokta �arp���yor";
            else label2.Text = "�arp��ma Yok";
            UpdatePointMovement();
            UpdatedikdortgenMovement();
        }
        else if (noktaCembercizilsinMi)
        {
            // �arp��ma kontrol�
            if (Carpisma.NoktaCember(sekiller.nokta, sekiller.cember))
                label2.Text = "�ember-Nokta �arp���yor";
            else
                label2.Text = "�arp��ma Yok";
            UpdatePointMovement();
            UpdateCemberMovement(sekiller.cember,ref cemberhizix,ref cemberhiziy);
        }
        else if (dikdortgenCemberCizilsinMi)
        {
            if (Carpisma.CemberDikdortgen(sekiller.cember, sekiller.dikdortgenler[0]))
                label2.Text = "�ember-Dikd�rtgen �arp���yor";
            else
                label2.Text = "�arp��ma Yok";
            UpdatedikdortgenMovement();

            UpdateCemberMovement(sekiller.cember, ref cemberhizix,ref cemberhiziy);
        }
        else if (cembercember)
        {
            if (Carpisma.CemberCember(sekiller.cember, cember2))

                label2.Text = "�ember-�ember �arp���yor";
            else
                label2.Text = "�arp��ma Yok";
            UpdateCemberMovement(sekiller.cember, ref cemberhizix, ref cemberhiziy);
            UpdateCemberMovement(cember2,ref cemberhizix2,ref cemberhiziy2);

        }
       else if (noktakure)
        {
            if (Carpisma.NoktaKure(sekiller.nokta, sekiller.kure))
                label2.Text = "Nokta-Kure �arp���yor";
            else label2.Text = "�arp��ma Yok";
            UpdateKureMovement(sekiller.kure,ref kurehiziX,ref kurehiziY);
            UpdatePointMovement();

        }
        else if(noktadprizma)
        {
            if(Carpisma.NoktaDikdortgen(sekiller.nokta,sekiller.dPrizma))
            {
                label2.Text = "Nokta-Dprizma �arp���yor";
            }
            else
                label2.Text = "�arp��ma Yok";
            updateDprizmaMovement(sekiller.dPrizma, ref dxVelocity, ref dyVelocity);
            UpdatePointMovement() ;
        }
       else if (noktasilindir)
        {

            if (Carpisma.NoktaSilindir(sekiller.nokta, sekiller.silindir))
            {
                label2.Text = "Nokta-Silindir �arp���yor";
            }
            else
                label2.Text = "�arp��ma Yok";
            UpdateSilindirMovement(sekiller.silindir,ref silindirhiziX,ref silindirhiziY) ;
            UpdatePointMovement();
        }
        else if(kuresilindir)
        {
            if(Carpisma.KureSilindir(sekiller.kure,sekiller.silindir))
                label2.Text = "Kure-Silindir �arp���yor";
            else
                label2.Text = "�arp��ma Yok";

            UpdateSilindirMovement(sekiller.silindir, ref silindirhiziX, ref silindirhiziY);
            UpdateKureMovement(sekiller.kure, ref kurehiziX, ref kurehiziY);
        }
        else if(kuredprizma)
        {
            if(Carpisma.KureDprizma(sekiller.kure,sekiller.dPrizma))
            { label2.Text = "Kure-Dprizma �arp���yor"; }
            else
                label2.Text= "�arp��ma Yok";
            updateDprizmaMovement(sekiller.dPrizma,ref dxVelocity,ref dyVelocity) ;
            UpdateKureMovement(sekiller.kure, ref kurehiziX, ref kurehiziY);

        }
        else if(silindirsilindir)
        {
            if(Carpisma.SilindirSilindir(sekiller.silindir,silindir))
                label2.Text = "Silindir-Silindir �arp���yor";
            else label2.Text = "�arp��ma Yok";
            UpdateSilindirMovement(sekiller.silindir, ref silindirhiziX, ref silindirhiziY);
            UpdateSilindirMovement(silindir, ref silindirhiziX2, ref silindirhiziY2);

        }
        else if(kurekure)
        {
            if(Carpisma.KureKure(sekiller.kure,kure2))
                label2.Text = "Kure-Kure �arp���yor";
            else label2.Text = "�arp��ma Yok";
            UpdateKureMovement(sekiller.kure, ref kurehiziX, ref kurehiziY);
            UpdateKureMovement(kure2, ref kurehiziX2, ref kurehiziY2);

        }
        else if(dprizmadprizma)
        {
            if (Carpisma.DprizmaDprizma(sekiller.dPrizma, dPrizma))
            {
                label2.Text = "dprizma-dprizma �arp���yor";
            }
            else label2.Text = "�arp��ma Yok";
           
            updateDprizmaMovement(sekiller.dPrizma, ref dxVelocity, ref dyVelocity);
            updateDprizmaMovement(dPrizma, ref dxVelocity, ref dyVelocity);
        }
        else if(hepsi)
        {
            listBox1.Items.Clear();
            UpdateCemberMovement(sekiller.cember, ref cemberhizix, ref cemberhiziy);
            UpdateRectangleMovement(sekiller.dikdortgenler[0], sekiller.dikdortgenler[1]);
            updateDprizmaMovement(sekiller.dPrizma, ref dxVelocity, ref dyVelocity);
            UpdateKureMovement(sekiller.kure, ref kurehiziX, ref kurehiziY);
            UpdatePointMovement();
            UpdateSilindirMovement(sekiller.silindir, ref silindirhiziX, ref silindirhiziY);
            label1.Text = "";
            label2.Text = "";
            if (Carpisma.CemberDikdortgen(sekiller.cember, sekiller.dikdortgenler[0]) || Carpisma.CemberDikdortgen(sekiller.cember, sekiller.dikdortgenler[1]))
            {
                listBox1.Items.Add("�ember ve Dikd�rtgen �arp���yor");
            }
            if (Carpisma.NoktaCember(sekiller.nokta, cember2))
            {
                listBox1.Items.Add("�ember ve Nokta �arp���yor");
            }
            if (Carpisma.NoktaDikdortgen(sekiller.nokta, sekiller.dikdortgenler[0]) || Carpisma.NoktaDikdortgen(sekiller.nokta, sekiller.dikdortgenler[1]))
            {
                listBox1.Items.Add("�ember ve Dikd�rtgen �arp���yor");
            }
            if (Carpisma.KureDprizma(sekiller.kure, sekiller.dPrizma) || Carpisma.KureDprizma(kure2, sekiller.dPrizma))
            {
                listBox1.Items.Add("K�re ve Dikd�rtgen Prizma �arp���yor");
            }
            if (Carpisma.NoktaDprizma(sekiller.nokta, sekiller.dPrizma))
            {
                listBox1.Items.Add("Nokta ve Dikd�rtgen Prizma �arp���yor");
            }
            if (Carpisma.KureSilindir(sekiller.kure, sekiller.silindir)|| Carpisma.KureSilindir(kure2, sekiller.silindir))
            {
                listBox1.Items.Add("K�re ve Silindir �arp���yor");
            }
            if (Carpisma.NoktaKure(sekiller.nokta, sekiller.kure)|| Carpisma.NoktaKure(sekiller.nokta, kure2))
            {
                listBox1.Items.Add("K�re ve Nokta �arp���yor");
            }
            if (Carpisma.NoktaSilindir(sekiller.nokta, sekiller.silindir))
            {
                listBox1.Items.Add("Silindir ve Nokta �arp���yor");
            }
            if (Carpisma.DikdortgenDikdortgen(sekiller.dikdortgenler[0], sekiller.dikdortgenler[1]))
            {
                listBox1.Items.Add("Dikd�rtgen ve Dikd�rtgen �arp���yor");
            }
            if (Carpisma.kureDikdortgen(sekiller.kure, sekiller.dikdortgenler[0]) || Carpisma.kureDikdortgen(sekiller.kure, sekiller.dikdortgenler[1]) || Carpisma.kureDikdortgen(kure2, sekiller.dikdortgenler[0]) || Carpisma.kureDikdortgen(kure2, sekiller.dikdortgenler[1]))
            {
                listBox1.Items.Add("Kure ve Dikd�rtgen �arp���yor");
            }
          
        }






        // Form'u yeniden �izmek i�in 
        pictureBox1.Refresh();
    }


    
   int dhizix = 8; int dhiziy = 8;
    private void UpdateRectangleMovement(Dikdortgen dikdortgen,Dikdortgen dikdortgen1)
    {
       
            double newX = dikdortgen.merkez.X + dikdortgen.xHizi;
            double newY = dikdortgen.merkez.Y + dikdortgen.yHizi;

            if (newX - dikdortgen.en / 2 < 0 || newX + dikdortgen.en / 2 > this.surface.Width)
            {
                dikdortgen.xHizi = -dikdortgen.xHizi;
                newX = dikdortgen.merkez.X + dikdortgen.xHizi; // Kenara �arp�nca yeni X konumunu hesapla
            }
            if (newY - dikdortgen.boy / 2 < 0 || newY + dikdortgen.boy / 2 > this.surface.Height)
            {
                dikdortgen.yHizi = -dikdortgen.yHizi;
                newY = dikdortgen.merkez.Y + dikdortgen.yHizi; // Kenara �arp�nca yeni Y konumunu hesapla
            }

            // Yeni konumu ayarla
            dikdortgen.merkez.X = newX;
            dikdortgen.merkez.Y = newY;

        double newXx = dikdortgen1.merkez.X + dhizix;
        double newYy = dikdortgen1.merkez.Y + dhiziy;

        if (newXx - dikdortgen1.en / 2 < 0 || newXx + dikdortgen1.en / 2 > this.surface.Width)
        {
            dhizix = -dhizix;
            newXx = dikdortgen1.merkez.X + dhizix; // Kenara �arp�nca yeni X konumunu hesapla
        }
        if (newYy - dikdortgen1.boy / 2 < 0 || newYy + dikdortgen1.boy / 2 > this.surface.Height)
        {
            dhiziy = -dhiziy;
            newYy = dikdortgen1.merkez.Y + dhiziy; // Kenara �arp�nca yeni Y konumunu hesapla
        }

        // Yeni konumu ayarla
        dikdortgen1.merkez.X = newXx;
        dikdortgen1.merkez.Y = newYy;







    }
    private void UpdatedikdortgenMovement()
    {
        int xVelocity = 5; // X eksenindeki h�z
        int yVelocity = 5; // Y eksenindeki h�z
        double recnewX = sekiller.dikdortgenler[0].merkez.X + xVelocity;
        double recnewY = sekiller.dikdortgenler[0].merkez.Y + yVelocity;

        if (recnewX - sekiller.dikdortgenler[0].en / 2 < 0 || recnewX + sekiller.dikdortgenler[0].en / 2 > this.surface.Width)
        {
            sekiller.dikdortgenler[0].xHizi = -sekiller.dikdortgenler[0].xHizi;
        }
        if (recnewY - sekiller.dikdortgenler[0].boy / 2 < 0 || recnewY + sekiller.dikdortgenler[0].boy / 2 > this.surface.Height)
        {
            sekiller.dikdortgenler[0].yHizi = -sekiller.dikdortgenler[0].yHizi;
        }
        sekiller.dikdortgenler[0].merkez.X += sekiller.dikdortgenler[0].xHizi;
        sekiller.dikdortgenler[0].merkez.Y += sekiller.dikdortgenler[0].yHizi;

    }
    int dxVelocity = 5; // X eksenindeki h�z
    int dxVelocity2 = 7; 
    int dyVelocity = 5; // Y eksenindeki h�z
    int dyVelocity2 = 7; 
    void updateDprizmaMovement(dPrizma dprizma,ref int dxVelocity,ref int dyVelocity)
    {
       
        double recnewX = sekiller.dPrizma.merkez.X + dxVelocity;
        double recnewY = sekiller.dPrizma.merkez.Y + dyVelocity;

        if (recnewX - sekiller.dPrizma.en / 2 < 0 || recnewX + sekiller.dPrizma.en / 2 > this.surface.Width)
        {
            dxVelocity = -dxVelocity;
        }
        if (recnewY - sekiller.dPrizma.boy / 2 < 0 || recnewY + sekiller.dPrizma.boy / 2 > this.surface.Height)
        {
            dyVelocity = -dyVelocity;
        }

        sekiller.dPrizma.merkez.X += dxVelocity;
        sekiller.dPrizma.merkez.Y += dyVelocity;
    }
    int noktaHiziX = 5;
    int noktaHiziY = 5;
    private void UpdatePointMovement()
    {

        // Noktan�n yeni konumunu hesapla
        double newX = sekiller.nokta.X + noktaHiziX;
        double newY = sekiller.nokta.Y + noktaHiziY;



        // Kenarlara �arpma kontrol�
        if (newX < 0 || newX > this.surface.Width)
        {
            // X ekseninde kenara �arpt�, y�n� de�i�tir
            noktaHiziX = -noktaHiziX;
        }
        if (newY < 0 || newY > this.surface.Height)
        {
            // Y ekseninde kenara �arpt�, y�n� de�i�tir
            noktaHiziY = -noktaHiziY;
        }


        // Yeni konumu ayarla
        sekiller.nokta.X += noktaHiziX;
        sekiller.nokta.Y += noktaHiziY;






        // Picture box'� yeniden �iz
        pictureBox1.Refresh();
    }
    int kurehiziX = 5;
    int kurehiziX2 = 7;
    int kurehiziY = 5;
    int kurehiziY2 = 7;
    private void UpdateKureMovement(Kure kure,ref int kurehiziX,ref int kurehiziY)
    {
        // Yeni z konumu i�in rastgele bir de�er olu�tur (0 veya 1)
        Random random = new Random();
        double randomZ = random.Next(0, 2);

        // Kenarlara �arpma kontrol�
        if (kure.merkez.X < 0 || kure.merkez.X > this.surface.Width - kure.YariCap * 2)
        {
            // X ekseninde kenara �arpt�, y�n� de�i�tir
            kurehiziX = -kurehiziX;
        }
        if (kure.merkez.Y < 0 || kure.merkez.Y > this.surface.Height - kure.YariCap * 2)
        {
            // Y ekseninde kenara �arpt�, y�n� de�i�tir
            kurehiziY = -kurehiziY;
        }

        // Yeni konumu ayarla
        kure.merkez.X += kurehiziX;
        kure.merkez.Y += kurehiziY;
        kure.merkez.Z = randomZ; // Z konumunu g�ncelle

        pictureBox1.Refresh();
    }
    int silindirhiziY = 5;
    int silindirhiziY2 = 7;
    int silindirhiziX = 5;
    int silindirhiziX2 = 7;
    private void UpdateSilindirMovement(Silindir silindir, ref int silindirhiziX,ref int silindirhiziY)
    {
        Random random = new Random();
        double randomZ = random.Next(0, 2);

        // Kenarlara �arpma kontrol�
        if (silindir.merkez.X < 0 || silindir.merkez.X > this.surface.Width - silindir.YariCap * 2)
        {
            // X ekseninde kenara �arpt�, y�n� de�i�tir
            silindirhiziX = -silindirhiziX;
        }
        if (silindir.merkez.Y < 0 || silindir.merkez.Y > this.surface.Height - silindir.YariCap * 2)
        {
            // Y ekseninde kenara �arpt�, y�n� de�i�tir
            silindirhiziY = -silindirhiziY;
        }

        // Yeni konumu ayarla
        silindir.merkez.X += silindirhiziX;
        silindir.merkez.Y += silindirhiziY;
        silindir.merkez.Z = randomZ; // Z konumunu g�ncelle

        pictureBox1.Refresh();
    }
    int cemberhizix = 5;
    int cemberhizix2 = 7;

    int cemberhiziy = 5;
    int cemberhiziy2 = 7;
    private void UpdateCemberMovement(Cember cember, ref int cemberHiziX, ref int cemberHiziY)
    {

        // Noktan�n yeni konumunu hesapla
        double newX = cember.merkez.X + cemberHiziX;
        double newY = cember.merkez.Y + cemberHiziY;

        // Kenarlara �arpma kontrol�
        if (newX < 0 || newX > this.surface.Width - cember.YariCap * 2)
        {
            // X ekseninde kenara �arpt�, y�n� de�i�tir
            cemberHiziX = -cemberHiziX;
        }
        if (newY < 0 || newY > this.surface.Height - sekiller.cember.YariCap * 2)
        {
            // Y ekseninde kenara �arpt�, y�n� de�i�tir
            cemberHiziY = -cemberHiziY;
        }

        // Yeni konumu ayarla
        cember.merkez.X += cemberHiziX;
        cember.merkez.Y += cemberHiziY;

        pictureBox1.Refresh();
    }



    private bool dikdortgenCizilsinMi = false;
    private bool noktadikdortgenCizilsinMi = false;
    private bool noktaCembercizilsinMi = false;
    private bool dikdortgenCemberCizilsinMi = false;
    private bool cembercember = false;
    private bool noktakure = false;
    private bool noktadprizma = false;
    private bool noktasilindir=false;
    private bool kuresilindir= false;
    private bool kuredprizma = false;
    private bool silindirsilindir = false;
    private bool kurekure=false;
    private bool dprizmadprizma = false;
    private bool hepsi = false;
    float diameter = 10; //noktan�n dairesinin �ap�
    private void dikdortgenciz(Graphics g)
    {
        
        g.DrawRectangle(Pens.Blue, (float)(sekiller.dikdortgenler[0].merkez.X - sekiller.dikdortgenler[0].en / 2), (float)(sekiller.dikdortgenler[0].merkez.Y - sekiller.dikdortgenler[0].boy / 2), (float)sekiller.dikdortgenler[0].en, (float)sekiller.dikdortgenler[0].boy);
    }
    private void noktaciz(Graphics g)
    {
        g.FillEllipse(Brushes.Red, (float)(sekiller.nokta.X - diameter / 2), (float)(sekiller.nokta.Y - diameter / 2), diameter, diameter);
    }
    private void cemberciz(Graphics g)
    {
        g.DrawEllipse(Pens.Blue, (float)(sekiller.cember.merkez.X - sekiller.cember.YariCap), (float)(sekiller.cember.merkez.Y - sekiller.cember.YariCap), (float)(sekiller.cember.YariCap * 2), (float)(sekiller.cember.YariCap * 2));

    }
    private void kureciz(Graphics g)
    {
        int x = (int)(sekiller.kure.merkez.X - sekiller.kure.YariCap);
        int y = (int)(sekiller.kure.merkez.Y - sekiller.kure.YariCap);
        int kdiameter = (int)(sekiller.kure.YariCap * 2);
        g.FillEllipse(Brushes.Red, x, y, kdiameter, kdiameter);
    }
    private void dprizmaciz(Graphics g)
    {
        g.FillRectangle(Brushes.Red, (float)(sekiller.dPrizma.merkez.X - sekiller.dPrizma.en / 2), (float)(sekiller.dPrizma.merkez.Y - sekiller.dPrizma.boy / 2), (float)sekiller.dPrizma.en, (float)sekiller.dPrizma.boy);

    }
    SolidBrush brush = new SolidBrush(Color.Blue);
    private void silindirciz(Graphics g)
    {
        g.FillEllipse(brush, (float)(sekiller.silindir.merkez.X - sekiller.silindir.YariCap),
                                (float)(sekiller.silindir.merkez.Y - sekiller.silindir.YariCap),
                                (float)(2 * sekiller.silindir.YariCap),
                                (float)(2 * sekiller.silindir.YariCap));

        g.FillRectangle(brush, (float)(sekiller.silindir.merkez.X - sekiller.silindir.YariCap),
                               (float)(sekiller.silindir.merkez.Y),
                               (float)(2 * sekiller.silindir.YariCap),
                               (float)(sekiller.silindir.yukseklik));
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        surface.DrawBorders(e);
        Graphics g = e.Graphics;
        if (dikdortgenCizilsinMi)
        {
            foreach (var dikdortgen in sekiller.dikdortgenler)
            {
                g.DrawRectangle(Pens.Blue, (float)(dikdortgen.merkez.X - dikdortgen.en / 2), (float)(dikdortgen.merkez.Y - dikdortgen.boy / 2), (float)dikdortgen.en, (float)dikdortgen.boy);
            }
        }
       
        if (noktadikdortgenCizilsinMi)
        {

            dikdortgenciz(g);
            noktaciz(g);
        }
        if (noktaCembercizilsinMi)
        {
            // �emberi �iz
            cemberciz(g);
            noktaciz(g);
        }
        if (dikdortgenCemberCizilsinMi)
        {
            dikdortgenciz(g);
            cemberciz(g);
        }
        if (cembercember)
        {  
            g.DrawEllipse(Pens.Blue, (float)(sekiller.cember.merkez.X - sekiller.cember.YariCap), (float)(sekiller.cember.merkez.Y - sekiller.cember.YariCap), (float)(sekiller.cember.YariCap * 2), (float)(sekiller.cember.YariCap * 2));
            g.DrawEllipse(Pens.Blue, (float)(cember2.merkez.X - cember2.YariCap), (float)(cember2.merkez.Y - cember2.YariCap), (float)(cember2.YariCap * 2), (float)(cember2.YariCap * 2));
        }
        if (noktakure)
        {
            kureciz(g);
            noktaciz(g);        }
        if(noktadprizma)
        {
            dprizmaciz(g);
            noktaciz(g);

        }
        if (noktasilindir)
        {
            silindirciz(g);
            noktaciz(g);
        }
        if(kuresilindir)
        {
            silindirciz(g);
            kureciz(g);
        }
        if(kuredprizma)
        {
            kureciz(g);
            dprizmaciz(g);
        }
        if(silindirsilindir)
        {
            silindirciz(g);

            g.FillEllipse(brush, (float)(silindir.merkez.X - silindir.YariCap),
                              (float)(silindir.merkez.Y - silindir.YariCap),
                              (float)(2 * silindir.YariCap),
                              (float)(2 * silindir.YariCap));

            g.FillRectangle(brush, (float)(silindir.merkez.X - silindir.YariCap),
                                   (float)(silindir.merkez.Y),
                                   (float)(2 * silindir.YariCap),
                                   (float)(silindir.yukseklik));
        }
        if(kurekure)
        {
            int x = (int)(sekiller.kure.merkez.X - sekiller.kure.YariCap);
            int y = (int)(sekiller.kure.merkez.Y - sekiller.kure.YariCap);
            int kdiameter = (int)(sekiller.kure.YariCap * 2);
            g.FillEllipse(Brushes.Red, x, y, kdiameter, kdiameter);
            g.FillEllipse(Brushes.Red, (int)(kure2.merkez.X - kure2.YariCap), (int)(kure2.merkez.Y - kure2.YariCap), kdiameter, kdiameter);



        }
        if(dprizmadprizma)
        {
            g.FillRectangle(Brushes.Red, (float)(sekiller.dPrizma.merkez.X - sekiller.dPrizma.en / 2), (float)(sekiller.dPrizma.merkez.Y - sekiller.dPrizma.boy / 2), (float)sekiller.dPrizma.en, (float)sekiller.dPrizma.boy);
            g.FillRectangle(Brushes.Red, (float)(dPrizma.merkez.X - dPrizma.en / 2), (float)(dPrizma.merkez.Y - dPrizma.boy / 2), (float)dPrizma.en, (float)dPrizma.boy);

        }
        if(hepsi)
        {
            dikdortgenciz(g);
            cemberciz(g);
            dprizmaciz(g);
            kureciz(g);
           
            g.DrawRectangle(Pens.Blue, (float)(sekiller.dikdortgenler[1].merkez.X - sekiller.dikdortgenler[1].en / 2), (float)(sekiller.dikdortgenler[1].merkez.Y - sekiller.dikdortgenler[1].boy / 2), (float)sekiller.dikdortgenler[1].en, (float)sekiller.dikdortgenler[1].boy);

            silindirciz(g);
            noktaciz(g);
            int x = (int)(kure2.merkez.X - kure2.YariCap);
            int y = (int)(kure2.merkez.Y - kure2.YariCap);
            int kdiameter = (int)(kure2.YariCap * 2);
            g.FillEllipse(Brushes.Red, x, y, kdiameter, kdiameter);


        }
    }
    private void button1_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex == -1) // E�er bir se�im yap�lmam��sa
        {
            MessageBox.Show("Bir durum se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (comboBox1.SelectedIndex == 0)
        {
            dikdortgenCizilsinMi = true;
            timer.Start();// Timer� ba�lat
        }
        else if (comboBox1.SelectedIndex == 1)
        {
            noktadikdortgenCizilsinMi = true;
            timer.Start();
        }
        else if (comboBox1.SelectedIndex == 2)
        {
            noktaCembercizilsinMi = true;
            timer.Start();
        }
        else if (comboBox1.SelectedIndex == 3)
        {
            dikdortgenCemberCizilsinMi = true;
            timer.Start();
        }
        else if (comboBox1.SelectedIndex == 4)
        {
            cembercember = true;
            timer.Start();
        }
        else if (comboBox1.SelectedIndex == 5)
        {
            noktakure = true; timer.Start();
        }
        else if(comboBox1.SelectedIndex == 6)
        {
            noktadprizma = true;timer.Start();
        }
        else if (comboBox1.SelectedIndex == 7) 
        {
            noktasilindir = true; timer.Start();
        }
        else if(comboBox1.SelectedIndex == 8) 
        {
            kuresilindir = true; timer.Start();
        }
        else if(comboBox1.SelectedIndex == 9)
            {
            kuredprizma = true; timer.Start();
        }
        else if(comboBox1.SelectedIndex == 10)
        {
            silindirsilindir=true; timer.Start();
        }
        else if((comboBox1.SelectedIndex == 11) )
        {
            kurekure = true; timer.Start();
        }
        else if ((comboBox1.SelectedIndex == 12) )
        {
            dprizmadprizma = true; timer.Start();
        }
        else if(comboBox1.SelectedIndex == 13)
        {
            hepsi = true; timer.Start();
        }
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dikdortgenCizilsinMi = false;
        noktadikdortgenCizilsinMi = false;
        noktaCembercizilsinMi = false;
        dikdortgenCemberCizilsinMi = false;
        cembercember = false;
        noktadprizma=false;
        noktasilindir =false;
        kuresilindir = false;
        kuredprizma=false;
        noktakure =false;
        silindirsilindir=false;
        kurekure=false;
        dprizmadprizma=false;
        hepsi = false;
        listBox1.Items.Clear();
        pictureBox1.Invalidate(); // Force the picture box to repaint
    }
}
