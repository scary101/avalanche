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
using System.Windows.Shapes;
using who;
using static System.Net.Mime.MediaTypeNames;

namespace Whooooo
{
    public partial class Registred : Window
    {
        public Registred(TextBox Secret)
        {
            InitializeComponent();
            List<Test> tests = SerDeser.DeserData<Test>("Quest.json");
            if (tests.Count() == 0)
            {
                PageFrame.NavigationService.Navigate(new PageTestNull());
            }
            else
            {
                PageFrame.NavigationService.Navigate(new TestPage());
            }
            this.DataContext = Secret;
            CheckSecret(Secret.Text);
        }

        private void ButExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        

        private void ButTest_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new TestPage();
        }

        private void ButEdit_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new EditTestPage();
        }

        private void PageFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void CheckSecret(string secret)
        {
            if (secret == "Фикус")
            {
                ButEdit.IsEnabled = true;
            }
            else
            {
                ButEdit.IsEnabled = false;
            }
        }
    }
}
