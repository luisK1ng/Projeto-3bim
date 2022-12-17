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

namespace Projeto3bim
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

        private void Slider_ValueChanged(object sender,RoutedPropertyChangedEventArgs<double> e)
        {
            txtNumContas.Text = slider.Value.ToString();
        }

        private Contas b;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = new Contas();
            b.Iniciar(int.Parse(txtNumContas.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x = b.Contas();
            if (x == -1)
            {
                txtNum.Text = "Fim";
                btnIniciar.IsEnabled = true;
                btnSortear.IsEnabled = false;
            }
            else
            {
                txtNum.Text = x.ToString();
                string s = "";
                foreach (int i in b.Contas())
                    s = s + i + " - ";
                txtAgencia.Text = s;
            }
        }
    }
}