using System.Windows;
using CovidStats.ViewModels;

namespace CovidStats
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var main = new MainWindow();
            main.DataContext = new MainViewModel();
            main.Show();

            base.OnStartup(e);
        }
    }
}
