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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool res = int.TryParse(tb1.Text, out var number);
            if (res == true)//Если введены числа, то выполнять
            {
                tb2.Clear();
                double num = Convert.ToDouble(tb1.Text);
                if (num % 4 == 0)
                {
                    if ((num % 100 == 0) && (num % 400 != 0))
                    { tb2.Text = "365 days"; }
                    else
                    { tb2.Text = "366 days"; }
                }
                else
                { tb2.Text = "365 days"; }
            }
            else
            {
                tb1.Text = "Введите число";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }
    }
}
