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
using H03_Rechteck_Logik;

namespace H03_Rechteck_GUI
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

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBreite.Text.Length > 0 && txtHoehe.Text.Length > 0)
            {
                btnAnzeigen.IsEnabled = true;
            }
            else
            {
                btnAnzeigen.IsEnabled = false;
            }
        }

        private void btnAnzeigen_Click(object sender, RoutedEventArgs e)
        {
            double breite, hoehe = 0;
            MessageBoxResult btnAntwort = new MessageBoxResult();

            bool konvertierung = true;
            bool grenze = true;

            if (!Double.TryParse(txtBreite.Text, out breite) || !Double.TryParse(txtHoehe.Text, out hoehe))
            {
                btnAntwort = MessageBox.Show("Eine der Kenngrößen kann nich umgewandelt werden!", "Konvertierungsfehler", MessageBoxButton.OK, MessageBoxImage.Error);
                konvertierung = false;
            }
            else if (Convert.ToDouble(txtBreite.Text) <= 0 || Convert.ToDouble(txtHoehe.Text) <= 0)
            {
                lblMeldung.Content = $"Ein Wert ist kleiner gleich 0!";
                grenze = false;
            }

            switch (btnAntwort)
            {
                case MessageBoxResult.OK:
                    lblMeldung.Content = "";
                    break;
            }

            if (konvertierung && grenze)
            {
                Rechteck rechteck = new Rechteck(breite, hoehe);

                lblFlaeche.Content = rechteck.GetFlaeche();
                lblUmfang.Content = rechteck.GetUmfang();

                lblMeldung.Content = "";
            }
        }
    }
}
