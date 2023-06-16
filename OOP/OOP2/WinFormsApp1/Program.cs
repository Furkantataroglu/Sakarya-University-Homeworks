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
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}