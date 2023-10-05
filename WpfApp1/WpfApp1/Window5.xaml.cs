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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                        tbEx.Clear();
                        tb1.Clear();
                        tb2.Clear();
                        if ((Convert.ToInt32(tbM.Text) != 0) && (Convert.ToInt32(tbN.Text) != 0))
                        {
                            int M = Convert.ToInt32(tbM.Text);
                            int N = Convert.ToInt32(tbN.Text);
                            int[,] array = new int[M, N];
                            Random rand = new Random();
                            for (int i = 0; i < M; i++)//Заполняем двумерный массив ччислами от -10 до 10
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    array[i, j] = rand.Next(-10, 10);
                                    tbEx.Text += Convert.ToString(array[i, j] + " ");
                                }
                    tbEx.Text += "\n";
                            }
                            var arr = array.Cast<int>().OrderByDescending(a => a).ToArray();//сортировка по убыванию
                            int c = 0;
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    array[i, j] = arr[c];//Заполняем массив в порядке убывания
                                    tb1.Text += array[i, j] + " ";
                                    c += 1;
                                }
                    tb1.Text += "\n";
                            }
                            tbMAX.Text = Convert.ToString(array[0, 0]);
                            arr = array.Cast<int>().OrderBy(a => a).ToArray();//сортировка по возрастанию
                            c = 0;
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    array[i, j] = arr[c];//Заполняем массив в порядке возрастания
                                    tb2.Text += array[i, j] + " ";
                                    c += 1;
                                }
                            }
                            tbMIN.Text = Convert.ToString(array[0, 0]);
                        }
                    }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
