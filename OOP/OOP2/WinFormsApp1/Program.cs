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