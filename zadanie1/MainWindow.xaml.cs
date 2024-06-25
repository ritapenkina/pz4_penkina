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

namespace pz1_penkina
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int j = 1000; j >= 1; j--)
            {
                j--;
                listView1.Items.Add(j);
            }
            int i = 1001;
            while (i >= 1)
            {
                i -= 2;
                listView2.Items.Add(i);
            }
            int b = 1001;
            do
            {
                b--;
                b--;
                listView3.Items.Add(b);
            }
            while (b >= 1);
            {
                b--;
                b--;
                listView3.Items.Add(b);
            }

        }
    }
}
