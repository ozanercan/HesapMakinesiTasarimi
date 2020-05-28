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

namespace HesapMakinesi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Varsayılan renkleri kayıt etmek için kullanılır.
        /// </summary>
        private Brush _arkaPlanRengi;
        private Brush _fontRengi;

        /// <summary>
        /// Mouse'nin üzerine gelince değişecek renkler için kullanılır.
        /// </summary>
        private SolidColorBrush arkaPlanYeniRenk;
        private SolidColorBrush fontYeniRenk;

        /// <summary>
        /// Etkileşime giren labelin bellekte ki değerlerini tutar.
        /// </summary>
        private Label aktifLabel;

        /// <summary>
        /// Ekranda ki sonuç kısmına veri göndermek için kullanılır.
        /// </summary>
        /// <param name="m">Gönderilecek rakam/işlem</param>
        private void YaziGonder(string m)
        {
            textBlock_sonuc.Text += m;
        }

        private void lbl_MouseEnter(object sender, MouseEventArgs e)
        {
            // Etkileşime giren labelin bellekte ki değerini aktifLabel nesnesine aktarır.
            aktifLabel = sender as Label;

            // Etkileşimde olan labelin arka plan ve font rengini yeni renklerle değiştirir.
            aktifLabel.Background = arkaPlanYeniRenk;
            aktifLabel.Foreground = fontYeniRenk;
        }

        private void lbl_MouseLeave(object sender, MouseEventArgs e)
        {
            // Etkileşime giren labelin bellekte ki değerini aktifLabel nesnesine aktarır.
            aktifLabel = sender as Label;

            // Etkileşimde olan labelin arka plan ve font rengini varsayılan renklerle değiştirir.
            aktifLabel.Background = _arkaPlanRengi;
            aktifLabel.Foreground = _fontRengi;
        }

        private void lbl_rakam_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Etkileşime giren labelin bellekte ki değerini aktifLabel nesnesine aktarır.
            aktifLabel = sender as Label;

            // Labelin Content değerini stringe çevirerek ekranda gösterir.
            YaziGonder(aktifLabel.Content.ToString());
        }

        private void lbl_islem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Etkileşime giren labelin bellekte ki değerini aktifLabel nesnesine aktarır.
            aktifLabel = sender as Label;

            // Labelin Content değerini stringe çevirerek ekranda gösterir.
            YaziGonder(aktifLabel.Content.ToString());
        }

        /// <summary>
        /// CE, C ve silme fonksiyonları için oluşturulmuştur.
        /// </summary>
        private void lbl_fonksiyon_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            aktifLabel = sender as Label;

            // Tıklanılan fonksiyon aktifLabel'in Content veya Name'sinden bulunabilir.
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            // Varsayılan renkleri değişkenlere aktarır.
            _arkaPlanRengi = this.Background;
            _fontRengi = this.Foreground;

            // Mouse eventlerine göre değişecek renk nesnelerini oluşturur.
            arkaPlanYeniRenk = new SolidColorBrush(Color.FromArgb(255, 66, 66, 66));
            fontYeniRenk = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }
    }
}
