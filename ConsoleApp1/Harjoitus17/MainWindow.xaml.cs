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

namespace Harjoitus17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiöValot = false;
        bool olohuoneenValot = false;
        bool oviLukossa = true;

        public MainWindow()
        {
            InitializeComponent();

            tb_lämpötila.Text = "talon sisälämpötila on " + lämpötila;
            tb_keittiö.Text = keittiöValot.ToString();
            tb_olouhone.Text = olohuoneenValot.ToString();
            btn_ovi.Content = oviLukossa.ToString();
        }

        private void btn_Olohuone_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;
            tb_olouhone.Text = olohuoneenValot.ToString();
        }

        private void btn_Keittiö_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot;
            tb_keittiö.Text = keittiöValot.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //ovi
        {
            oviLukossa = !oviLukossa;
            btn_ovi.Content = oviLukossa.ToString();
        }

        private void txt_termostaatti_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_termostaatti.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_termostaatti.Text = txt_termostaatti.Text.Remove(txt_termostaatti.Text.Length - 1);
            }
            else
            {
                lämpötila = int.Parse(txt_termostaatti.Text);
                tb_lämpötila.Text = "Talon sisälämpötila on " + lämpötila;
            }
        }
    }
}
