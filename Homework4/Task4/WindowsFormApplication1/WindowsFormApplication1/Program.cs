using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApplication1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new Form1());

            Triangle tr = new Triangle();
            tr.TriangleSide[0].length = 10;
            tr.TriangleSide[1].length = 20;
            tr.TriangleSide[2].length = 15;

            Debug.WriteLine(
                "Corner a size: " + 
                tr.CornerSizeBetween(tr.TriangleSide[0], tr.TriangleSide[1]) + "\n");
            Debug.WriteLine(
                "Corner b size: " +
                tr.CornerSizeBetween(tr.TriangleSide[1], tr.TriangleSide[2]) + "\n");
            Debug.WriteLine(
                "Corner c size: " +
                tr.CornerSizeBetween(tr.TriangleSide[0], tr.TriangleSide[2]) + "\n");
            Debug.WriteLine(
                "Periemtr: " +
                tr.Perimetr + "\n");

            EquilateralTriangle tr1 = new EquilateralTriangle();
            tr1.TriangleSide[0].length = 10;
            tr1.TriangleSide[1].length = 10;
            tr1.TriangleSide[2].length = 10;

            Debug.WriteLine(
                "Area of Equilateral Triangle: " +
                tr1.Area + "\n");
        }
    }
}
