using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dop5
{
    /// <summary>
    /// Логика взаимодействия для Z7Sam.xaml
    /// </summary>
    public partial class Z7Sam : Window
    {
        public Z7Sam()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            
        }

        private void inc_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            
           
        }

        private void Draw_Checked(object sender, RoutedEventArgs e)
        {
            if (inc != null)
            {
                inc.EditingMode = InkCanvasEditingMode.Ink;
            
            }
        }

        private void Erase_Checked(object sender, RoutedEventArgs e)
        {
            if (inc != null)
            {
                inc.EditingMode = InkCanvasEditingMode.EraseByPoint;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Z8 z8 = new Z8();
            z8.Show();
        }
    }
}
