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

namespace Task_wpf
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
        /// <summary>
        /// Функция разделения текста на слова.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
            static string[] SplitText(string text)
        {
            char[] chars = text.ToCharArray();
            int count = 0;
            /// Подсчет количества пробелов в тексте
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ') count++;
            }
            string[] str = new string[count + 1];
            int indexStart = 0;
            int t = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    str[t++] = text.Substring(indexStart, i - indexStart);
                    indexStart = ++i;
                }
                else if (i == text.Length - 1) str[t] = text.Substring(indexStart);
            }      
            return str;
        }

        static string Reverse(string text)
        {
            string[] splitText = SplitText(text);
            string reversString = string.Empty;
            for (int i = splitText.Length - 1; i >= 0; i--)
            {
                reversString += splitText[i] + ' ';
            }
            return reversString;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
                string proposal = txt1.Text;
                string[] newText = SplitText(proposal);
                lb1.ItemsSource = newText;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string revers = Reverse(txt2.Text);
            label_2.Content = revers;
        }
    }

}
  
