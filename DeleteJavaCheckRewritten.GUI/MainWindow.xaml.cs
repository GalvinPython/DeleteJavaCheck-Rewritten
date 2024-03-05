using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeleteJavaCheckRewritten.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DeleteJavaCheckPage deleteJavaCheckPage = new();
            MainFrame.NavigationService.Navigate(deleteJavaCheckPage);
        }

        private void DeleteJavaCheck_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DeleteJavaCheckPage());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AboutPage());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingsPage());
        }
    }
}