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

namespace WPF_AtviteliSebesseg
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

        private void sliSebesseg_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sebesseg = Convert.ToInt32(sliSebesseg.Value);
            lblSebesseg.Content = sebesseg;
        }

        private void btnSzamitas_Click(object sender, RoutedEventArgs e)
        {
            int mennyiseg = Convert.ToInt32(txtMennyiseg.Text);
            int sebesseg = Convert.ToInt32(sliSebesseg.Value);

            switch (cbMennyisegMertek.SelectedIndex)
            {
                case 1:
                    mennyiseg *= 1000;
                    break;
                case 2:
                    mennyiseg *= 1000000;
                    break;
                case 3:
                    mennyiseg *= 1000000000;
                    break;
            }

            switch (cbSebessegMertek.SelectedIndex)
            {
                case 1:
                    sebesseg *= 1000;
                    break;
                case 2:
                    sebesseg *= 1000000;
                    break;
            }
            TimeSpan ido = TimeSpan.FromSeconds(mennyiseg / sebesseg);
            lblIdo.Content = ido.ToString(@"hh\:mm\:ss");
        }
    }
}
