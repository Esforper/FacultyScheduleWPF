using System.Windows;
using System.Windows.Controls;

namespace FacultyScheduleWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new HomePage());
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new SettingsPage());
        }

        private void DbButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new DatabasePage());
        }

        public void NavigateToSpacePage(string depoAdi)
        {
            SpacePage spacePage = new SpacePage();
            spacePage.DepoAdi = depoAdi;
            MainContent.Navigate(spacePage);
        }
    }
}
