using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int zaehler = 0;
        public MainWindow()
        {
            InitializeComponent();

            Title = "Inhalt des Fensters";

            FontFamily = new FontFamily("Verdana");
            FontWeight = FontWeights.ExtraBold;
            FontSize = 20;

            SizeToContent = SizeToContent.WidthAndHeight;

            Content = "Hier ist der Inhalt";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FontFamily = new FontFamily("Arial");
            FontWeight = FontWeights.ExtraBold;
            FontSize = 35;
            Content = "****NEUER INHALT****";
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Console.WriteLine("Render-Ereignis Nr. "+zaehler++);
        }
    }
}
