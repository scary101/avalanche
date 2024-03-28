using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace Whooooo
{
    public partial class EditTestPage : Page
    {

        private List<Test> tests = SerDeser.DeserData<Test>("Quest.json");

        public EditTestPage()
        {
            InitializeComponent();
            QuestTest.ItemsSource = tests;
        }
        private void QuestTest_Unloaded(object sender, RoutedEventArgs e)
        {
            SerDeser.SerData<Test>((List<Test>)QuestTest.ItemsSource, "Quest.json");
        }


        private void QuestTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }



}
