using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\W+");
            bool res = int.TryParse(tb1.Text, out var number);
            if ((res == false)&&(regex.IsMatch(tb1.Text) == false))//если не цыфры и не символы, то выполнять
            {
                int count1 = 0;
                string str = tb1.Text;
                string[] words = str.Split(new char[] { ' ' });//разбиваем массив
                for (int i = 0; i < words.Length; i++)
                {
                    string a = words[i];
                    int count = 0;
                    for (int j = 0; j < a.Length; j++)
                    {
                        if ((a[j] == 'А') || (a[j] == 'а'))//проверяем на наличие смволов
                        {
                            count += 1;
                        }
                        if (count == 3)
                        { count1 += 1; }
                    }
                }
                tb2.Text = Convert.ToString(count1);
            }
            else
            { tb1.Text = "Введите строку"; }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.Show();
        }
    }
}
