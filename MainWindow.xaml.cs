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

namespace WPF2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void Delegate_Exo2(string str);
        public MainWindow()
        {
        InitializeComponent();
        }
        private void Bouton_LaManu(object sender, RoutedEventArgs e)
        {
        MessageBox.Show("Hello ! Bienvenue dans l'exercice 2 !");
        }
    }
}
