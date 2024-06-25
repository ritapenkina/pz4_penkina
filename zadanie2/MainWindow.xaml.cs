using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace pz2_penkina
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            string b = Convert.ToString(a);
            int a1 = Convert.ToInt32(textBox2.Text);
            string b1 = Convert.ToString(a1);

            //количество цифр в нем
            int lengthh = b.Length; /*Length возвращает число знаков в текущем объекте String*/
            label1.Content = $"Количество цифр: {lengthh}";

            //среднее арифметическое его цифр
            double c = 0.0;
            double sum = 0.0;
            double res = 0.0;
            for (int i = 1; i < b.Length; i++)
            {
                c = a % 10;
                sum += c;
            }
            res = sum / b.Length;
            label2.Content = $"Среднее арифметическое цифр: {res}";

            //сколько раз в нем встречается цифра а
            int n = 0;
            double qwerty;
            for (int j = 1; j < b.Length; j++)
            {
                qwerty = a % 10;
                if (qwerty == a1)
                {
                    n += 1;
                }
            }
            label3.Content = $"Сколько раз встречается цифра {a1}: {n}";

            //сумму его цифр, больше, а

        }

    }
}

