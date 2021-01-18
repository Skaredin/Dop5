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
    /// Логика взаимодействия для Z2.xaml
    /// </summary>
    /// 
    partial class Animal
    { 
    public string Name { get; set; }
    public string Property { get; set; }
    }
    public partial class Z2 : Window
    {
        public Z2()
        {
            InitializeComponent();
        }

        private void animalGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Z3 z3 = new Z3();
            z3.Show();
        }
    }
}
