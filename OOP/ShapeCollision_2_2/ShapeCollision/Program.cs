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
