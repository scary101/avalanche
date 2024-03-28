using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
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
    public partial class TestPage : Page
    {
        private List<Test> tests = new List<Test>();
        private int numQuest = 0;
        private int trueAns = 0;
        public TestPage()
        {
            InitializeComponent();
            tests = SerDeser.DeserData<Test>("Quest.json");

            UpdateTextBoxAndButtonContent();
        }

        private void UpdateTextBoxAndButtonContent()
        {

            if(numQuest >= tests.Count())
            {
                CheckOutQuest();
            }
            else
            {
                DisTextBox.Text = tests[numQuest].discruption;
                NameTextBox.Text = tests[numQuest].nameQuest;
                ButAnsw1.Content = tests[numQuest].answerFirst;
                ButAnsw2.Content = tests[numQuest].answerSecond;
                ButAnsw3.Content = tests[numQuest].answerThird;
            }
        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            if (tests[numQuest].trueAnswer == TrueAnswer.First)
            {
                trueAns++;
                numQuest++;
            }
            else
            {
                numQuest++;
            }
            UpdateTextBoxAndButtonContent();
        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {
            if (tests[numQuest].trueAnswer == TrueAnswer.Second)
            {
                trueAns++;
                numQuest++;
            }
            else
            {
                numQuest++;
            }
            UpdateTextBoxAndButtonContent();
        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {
            if (tests[numQuest].trueAnswer == TrueAnswer.Third)
            {
                trueAns++;
                numQuest++;
            }
            else
            {
                numQuest++;
            }
            UpdateTextBoxAndButtonContent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CheckOutQuest()
        {
            ButAnsw1.Visibility = Visibility.Hidden;
            ButAnsw2.Visibility = Visibility.Hidden;
            ButAnsw3.Visibility = Visibility.Hidden;
            NameTextBox.Text = "Тест завершен";
            DisTextBox.Text = $"Вы ответили правильно на {trueAns} из {tests.Count} вопросов.";
        }

        private void TextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
