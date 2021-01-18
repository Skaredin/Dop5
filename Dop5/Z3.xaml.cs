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
    /// Логика взаимодействия для Z3.xaml
    /// </summary>
    public partial class Z3 : Window
    {
        public Z3()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            ((Slider)sender).SelectionEnd = e.NewValue;
        }

        private void C1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? slectedDate = C1.SelectedDate;
            MessageBox.Show(slectedDate.Value.Date.ToShortDateString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Z5 z5 = new Z5();
            z5.Show();
        }
    }
}
