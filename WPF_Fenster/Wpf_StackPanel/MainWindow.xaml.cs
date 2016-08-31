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

namespace Wpf_StackPanel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static StackPanel container = new StackPanel();
        public MainWindow()
        {
            InitializeComponent();


            for (int i = 0; i < 30; i++)
            {
                MeinButten knopf = new MeinButten();
                knopf.Content = "Inhalt " + i;
                container.Children.Add(knopf);
            }
            Content = container;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Content != null)
                Content = null;
            else
                Content = container;
        }
    }
}
