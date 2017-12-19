using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("Dimon");
            Console.WriteLine("Maxim");
            Console.WriteLine("VlaDDOS");
            Console.WriteLine("Artem");
            Console.WriteLine("Ivan");
            Console.WriteLine("Mykhailov");
        }
        static void function()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Own Branch changes");
            }
           
        }
    }
}
