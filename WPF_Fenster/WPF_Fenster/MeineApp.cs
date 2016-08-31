using System;
using System.Windows;
using System.Windows.Input;


namespace WPF_Fenster
{
    class MeineApp : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MeinFenster f1 = new MeinFenster();
            f1.Title = "Erstes Fenster";
            f1.Show();

            MeinFenster f2 = new MeinFenster();
            f2.Title = "Zweites Fenster";
            f2.Show();

            MeinFenster f3 = new MeinFenster();
            f3.Title = "drittes Fenster";
            f3.Show();

            MainWindow = Windows[2];

            ShutdownMode = ShutdownMode.OnMainWindowClose;

            Console.WriteLine("Titel des Hauptfenstes: "+MainWindow.Title);

            for (int i = 0; i < Windows.Count; i++)
            {
                Console.WriteLine("Titel Fenster["+i+"]: "+ Windows[i].Title);
            }

        }
    }
}
