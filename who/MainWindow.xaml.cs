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
using static MaterialDesignThemes.Wpf.Theme;

namespace Whooooo
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

        private void CountingButtonNoReg(object sender, RoutedEventArgs e)
        {
            Registred registred = new Registred(Secret);
            registred.Show();
            Close();
        }

        private void CountingButtonReg(object sender, RoutedEventArgs e)
        {
            Secret.Visibility = Visibility.Visible;

            if (Secret.Text == "Фикус")
            {
                Registred registred = new Registred(Secret);
                registred.Show();
                Close();
            }
            else
            {
                Secret.Text = "Ты не знаешь серкет!";
            }

        }

        private void Secret_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

    }
}
