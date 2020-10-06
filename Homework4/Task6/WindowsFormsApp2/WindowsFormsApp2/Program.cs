using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            
            EquilateralTriangle tr1 = new EquilateralTriangle(10, 0.3);
            Debug.WriteLine("Equilateral triangle Area: " + tr1.Area()
                + " Perimetr: " + tr1.Perimetr() + "\n");

            RightTriangle tr2 = new RightTriangle(10, 11);
            Debug.WriteLine("Right triangle Area: " + tr2.Area()
                + " Perimetr: " + tr2.Perimetr() + "\n");
        }
    }
}
