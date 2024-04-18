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

namespace KitaevEkzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void massatopliva_Click(object sender, RoutedEventArgs e)
        {
            Toplivo toplivo = new Toplivo();
            toplivo.TP(Convert.ToDouble(Obem.Text), Convert.ToDouble(Plotnost.Text));
        }

        private void Hran_Click(object sender, RoutedEventArgs e)
        {
            Hranilishe hranilishe = new Hranilishe();
            hranilishe.Hran(Convert.ToDouble(ObemHran.Text), Convert.ToDouble(Zapas.Text));
        }

        private void Zapravit_Click(object sender, RoutedEventArgs e)
        {
            
            ZaprovStan zaprovStan = new ZaprovStan();
           zaprovStan.ZS(Convert.ToDouble(Zapravka.Text));
        }

    }

   
    internal class Hranilishe
    {
       
        public void Hran(double ob1, double ob2)
        {
            double HR3;
            HR3 = ob1 - ob2;
            MessageBox.Show("Достпуный объем" + $"{HR3}");
            

        }
        
    }
    internal class ZaprovStan
    {
        public void ZS( double ob2)
        {
            double HR3;
            HR3 = 100 - ob2;
            MessageBox.Show("Достпуный объем" + $"{HR3}");

        }
    }
}
