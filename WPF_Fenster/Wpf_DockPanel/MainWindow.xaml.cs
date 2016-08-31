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

namespace Wpf_DockPanel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DockPanel container = new DockPanel();

            Button knopf = new Button();
            knopf.Content = "Inhalt links";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Left);

            knopf = new Button();
            knopf.Content = "Inhalt rechts";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Right);

            knopf = new Button();
            knopf.Content = "Inhalt oben";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Top);

            knopf = new Button();
            knopf.Content = "Inhalt unten";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Bottom);

            knopf = new Button();
            knopf.Content = "Inhalt unten2";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Bottom);

            knopf = new Button();
            knopf.Content = "Inhalt unten2";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Bottom);
            knopf = new Button();
            knopf.Content = "Inhalt oben";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Top);
            knopf = new Button();
            knopf.Content = "Inhalt rechts";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Right);
            knopf = new Button();
            knopf.Content = "Inhalt rechts";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Right);

            knopf = new Button();
            knopf.Content = "Inhalt oben";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Top);

            knopf = new Button();
            knopf.Content = "Inhalt oben";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Top);


            knopf = new Button();
            knopf.Content = "Inhalt links";
            container.Children.Add(knopf);
            DockPanel.SetDock(knopf, Dock.Left);

            Content = container;
        }
    }
}
