using System;

using System.Windows;
using System.Windows.Media;

namespace WPF_Fenster
{
    class MeinFenster : Window
    {
        public MeinFenster()
        {
            Title = "Meine eigenes Fenster";
            Background = Brushes.LightGreen;

            Height = 200;
            Width = 300;
        }
    }
}
