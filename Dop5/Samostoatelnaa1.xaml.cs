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

namespace Dop5
{
    /// <summary>
    /// Логика взаимодействия для Samostoatelnaa1.xaml
    /// </summary>
    public partial class Samostoatelnaa1 : Window
    {
        public Samostoatelnaa1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Samostoatelnaa2 samostoatelnaa2 = new Samostoatelnaa2();
            samostoatelnaa2.Show();
        }
    }
}
