using System.Windows;
using System.Windows.Controls;

namespace FacultyScheduleWPF
{
    public partial class SpacePage : Page
    {
        public string DepoAdi
        {
            get { return (string)GetValue(DepoAdiProperty); }
            set { SetValue(DepoAdiProperty, value); }
        }

        public static readonly DependencyProperty DepoAdiProperty =
            DependencyProperty.Register("DepoAdi", typeof(string), typeof(SpacePage), new PropertyMetadata(string.Empty, OnDepoAdiChanged));

        public SpacePage()
        {
            InitializeComponent();
        }

        private static void OnDepoAdiChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var page = d as SpacePage;
            if (page != null)
            {
                page.DepoAdiTextBlock.Text = e.NewValue.ToString();
            }
        }

        private void Akademisyenler_Click(object sender, RoutedEventArgs e)
        {
            // Akademisyenler sayfasına yönlendirme kodu buraya gelecek
        }

        private void Derslikler_Click(object sender, RoutedEventArgs e)
        {
            // Derslikler sayfasına yönlendirme kodu buraya gelecek
        }

        private void Fakulteler_Click(object sender, RoutedEventArgs e)
        {
            // Fakülteler sayfasına yönlendirme kodu buraya gelecek
        }

        private void DersProgramlari_Click(object sender, RoutedEventArgs e)
        {
            // Ders Programları sayfasına yönlendirme kodu buraya gelecek
        }
    }
}
