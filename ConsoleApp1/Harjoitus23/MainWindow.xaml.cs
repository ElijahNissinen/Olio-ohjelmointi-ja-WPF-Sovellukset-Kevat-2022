using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kiuas kiuas = new Kiuas();
        public MainWindow()
        {
            InitializeComponent();

            //alustetaan kiuas tietyillä arvoilla
            kiuas.VaihdaLämpötila(10);
            kiuas.VaihdaKosteus(10);
            kiuas.OnkoPäällä = false; //kiuas on alussa false/poissa päältä
        }

        private void btn_LämpötilaUp_Click(object sender, RoutedEventArgs e)
        {
            int UusiLämpötila = kiuas.Lämpötila + 5; //lisätään lämpötilaan 5
            kiuas.VaihdaLämpötila(UusiLämpötila); //kutsutaan kiukaan toimintoa jossa tarkistetaan onko se 10-120 välillä
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString(); //lisätään lämpötila tekstikenttään nykyinen lämpötila
        }

        private void btn_LämpötilaDown_Click(object sender, RoutedEventArgs e)
        {
            int UusiLämpötila = kiuas.Lämpötila - 5; //vähennetään lämpötilasta 5
            kiuas.VaihdaLämpötila(UusiLämpötila); //kutsutaan kiukaan toimintoa jossa tarkistetaan onko se 10-120 välillä
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString(); //lisätään lämpötila tekstikenttään nykyinen lämpötila
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //tämän avulla kosteus textbox ottaa sisään VAIN numeroita, kirjaimia ja muita merkkejä ei voi kirjoittaa
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void input_Kosteus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (input_Kosteus.Text != "") // != tarkoittaa että a EI OLE YHTÄKUIN b
            {
                kiuas.VaihdaKosteus(int.Parse(input_Kosteus.Text));
                tb_Kosteus.Text = kiuas.Kosteus.ToString();
            }
        }
    }
}
