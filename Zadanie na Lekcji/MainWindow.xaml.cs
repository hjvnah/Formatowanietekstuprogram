using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_na_Lekcji
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
       
        //pogrubienie kiedy zaznaczone
        private void PogrubienieChecked(object sender, RoutedEventArgs e)
        { 
            wprtekst.FontWeight = FontWeights.Bold;
        }

        //pogrubienie kiedy odznaczone
        private void PogrubienieUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.FontWeight = FontWeights.Normal;
        }

        //podkreslenie kiedy zaznaczone
        private void PodkreslenieChecked(object sender, RoutedEventArgs e)
        {
            wprtekst.TextDecorations = TextDecorations.Underline;
        }

        //podkreslenie kiedy odznaczone
        private void PodkreslenieUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.TextDecorations = null;
        }

        //kursywa kiedy zaznaczone
        private void KursywaChecked(object sender, RoutedEventArgs e)
        {
            
            wprtekst.FontStyle = FontStyles.Italic;
        }

        //kursywa kiedy odznaczone
        private void KursywaUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.FontStyle = FontStyles.Normal;
        }

        //slider dla zmiany rozmiaru
        private void zmianarozmiaru(object sender, RoutedPropertyChangedEventArgs<double> e)
        {       
            wprtekst.FontSize = slider.Value;
        }

        //zmiana koloru na zielony
        private void zielonyzaz(object sender, RoutedEventArgs e)
        {
            wprtekst.Foreground = new SolidColorBrush(Colors.LightGreen);
        }

        //zmiana koloru na niebieski
        private void niebieskizaz(object sender, RoutedEventArgs e)
        {
            wprtekst.Foreground = new SolidColorBrush(Colors.LightBlue);
        }

        //zmiana koloru na standardowy
        private void standardowyzaz(object sender, RoutedEventArgs e)
        {
            wprtekst.Foreground = new SolidColorBrush(Colors.Black);
        }

        //zmiana koloru na rozowy
        private void rozowyzaz(object sender, RoutedEventArgs e)
        {
            wprtekst.Foreground = new SolidColorBrush(Colors.LightPink);
        }

        //zmiana koloru na fioletowy
        private void fioletowyzaz(object sender, RoutedEventArgs e)
        {
            wprtekst.Foreground = new SolidColorBrush(Colors.MediumPurple);
        }

       //wysrodkowanie do prawej
        private void prawotxt(object sender, RoutedEventArgs e)
        {
            wprtekst.TextAlignment = System.Windows.TextAlignment.Left;
        }

        //wysrodkowanie do srodka
        private void srodektxt(object sender, RoutedEventArgs e)
        {
            wprtekst.TextAlignment = System.Windows.TextAlignment.Center;
        }

       //wysrodkowanie do lewej
        private void lewotxt(object sender, RoutedEventArgs e)
        {
            wprtekst.TextAlignment = System.Windows.TextAlignment.Right;
        }

       //justowanie
        private void justtxt(object sender, RoutedEventArgs e)
        {
            wprtekst.TextAlignment = System.Windows.TextAlignment.Justify;
        }
    }
}