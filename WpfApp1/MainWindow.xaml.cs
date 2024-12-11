using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "media(*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                me.Source = new Uri(ofd.FileName);
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            me.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            me.Pause();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            me.Stop();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            me.Volume = e.NewValue;
        }
    }
}
