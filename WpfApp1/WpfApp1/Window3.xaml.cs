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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            int[] array = new int[Convert.ToInt32(tbLen.Text)];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)//заполняем массив случайными символами
            {
                array[i] = rand.Next(1, 9);
                tb1.Text += Convert.ToString(array[i]);
            }
            int chet = array[0] % 2;
            for (int i = 1; ((i < array.Length) && (chet != array[i] % 2)); ++i)//если четность чередуется, то выполнять
            {
                chet = array[i] % 2;
                if (i == array.Length - 1)
                {
                    tb2.Text = "0";
                }
            }
            chet = array[0] % 2;
            for (int i = 1;i < array.Length; ++i)//если не чередуется, то вывести число, которое нарушае порядок
            {
                if (chet == array[i] % 2)
                { tb2.Text = Convert.ToString(array[i]); break; }
                chet = array[i] % 2;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 win4 = new Window4();
            win4.Show();
        }
    }
}
