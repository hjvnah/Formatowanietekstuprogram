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
       
        private void PogrubienieChecked(object sender, RoutedEventArgs e)
        {


            wprtekst.FontWeight = FontWeights.Bold;
        }

        private void PogrubienieUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.Text = "The CheckBox is unchecked.";
        }

        private void PodkreslenieChecked(object sender, RoutedEventArgs e)
        {
            wprtekst.Text = "The CheckBox is checked.";
        }

        private void PodkreslenieUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.Text = "The CheckBox is unchecked.";
        }

        private void KursywaChecked(object sender, RoutedEventArgs e)
        {
            wprtekst.Text = "The CheckBox is checked.";
        }

        private void KursywaUnchecked(object sender, RoutedEventArgs e)
        {
            wprtekst.Text = "The CheckBox is unchecked.";
        }

    }
}