
using System.Windows.Controls;

namespace Wpf_StackPanel
{
    public class MeinButten : Button
    {

        protected override void OnClick()
        {
            base.OnClick();
            MainWindow.container.Children.Remove(this);
        }
    }
}
