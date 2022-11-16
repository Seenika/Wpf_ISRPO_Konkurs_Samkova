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

namespace Wpf_ISRPO_Konkurs_Samkova
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

        private void DlyUnoshei_Click(object sender, RoutedEventArgs e)
        {
            double un = Convert.ToDouble(chislonormun.Text);

            if (un >= 15)
            {
                MessageBox.Show("Бронза");
            }
            else 
            { 
            
            }

            if (un <=)
        }
    }
}
