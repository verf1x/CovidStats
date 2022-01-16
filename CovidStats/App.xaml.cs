using System.Windows;
using CovidStats.ViewModels;

namespace CovidStats
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public sealed partial class App : Application
    {
        protected sealed override void OnStartup(StartupEventArgs e)
        {
            var main = new MainWindow();
            main.DataContext = new MainViewModel();
            main.Show();

            base.OnStartup(e);
        }
    }
}
