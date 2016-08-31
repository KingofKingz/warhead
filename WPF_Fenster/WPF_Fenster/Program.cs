using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Fenster
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Öffnen von einem WPF-Fenster");   

            MeineApp app = new MeineApp();

            app.Run();
        }
    }
}
