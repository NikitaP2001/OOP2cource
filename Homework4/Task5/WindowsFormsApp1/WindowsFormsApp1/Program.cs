using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

            Triangle tr = new Triangle(5, 6, 9);
            Debug.WriteLine("Triangle Area: " + tr.Area() 
                + " Perimetr: " +tr.Perimetr() + "\n");

            Round Rou = new Round(25);
            Debug.WriteLine("Round Area: " + Rou.Area()
                + " Perimetr: " + Rou.Perimetr() + "\n");

            Romb Rom = new Romb(10,11);
            Debug.WriteLine("Romb Area: " + Rom.Area()
                + " Perimetr: " + Rom.Perimetr() + "\n");

            Square Sq = new Square(15);
            Debug.WriteLine("Square Area: " + Sq.Area()
                + " Perimetr: " + Sq.Perimetr() + "\n");
        }
    }
    
}
