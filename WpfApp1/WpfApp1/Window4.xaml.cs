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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            int[] array = new int[Convert.ToInt32(tbLen.Text)];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)//заполняем массив случайными числами
            {
                array[i] = rand.Next(1, 9);
                tb1.Text += Convert.ToString(array[i]);
            }
            int max = array[0]; int ind1=0;
            int max1 = array[0]; int ind2=0;
            for (int i = 0; i < array.Length; i++)//ищем два максимальных элемента
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind1 = i;
                }
                else if (array[i] > max1)
                {
                    max1 = array[i];
                    ind2 = i;
                }
            }
            int cont;
            cont = array[ind1];
            array[ind1] = array[ind2];//меняем местами
            array[ind2] = cont;
            for (int i = 0; i < array.Length; i++)//выводим массив
            {
                tb2.Text += Convert.ToString(array[i]);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window5 win5 = new Window5();
            win5.Show();
        }
    }
}
