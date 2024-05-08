/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**	
**				ÖDEV NUMARASI…...:2
**				ÖÐRENCÝ ADI...............:Furkan Tataroðlu
**				ÖÐRENCÝ NUMARASI.: G201210089
**				DERS GRUBU…………: 1. ÖÐRETÝM C
****************************************************************************/
using ShapeCollision.Shapes;

namespace ShapeCollision
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
