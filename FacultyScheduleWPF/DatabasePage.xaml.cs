using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using FacultyScheduleWPF.Models;
namespace FacultyScheduleWPF
{
    public partial class DatabasePage : UserControl
    {
        public ObservableCollection<Depo> Depolar { get; set; }

        public DatabasePage()
        {
            InitializeComponent();
            Depolar = new ObservableCollection<Depo>();
            this.DataContext = this;
        }

        private void YeniDepoEkle_Click(object sender, RoutedEventArgs e)
        {
            var yeniDepo = new Depo { DepoAdi = "Yeni Depo" };
            Depolar.Add(yeniDepo);
        }

        private void DepoSil_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var depo = button.DataContext as Depo;
            Depolar.Remove(depo);
        }

        private void DepoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DepoListBox.SelectedItem != null)
            {
                var selectedDepo = (Depo)DepoListBox.SelectedItem;
                ((MainWindow)Application.Current.MainWindow).NavigateToSpacePage(selectedDepo.DepoAdi);
            }
        }
    }
}
