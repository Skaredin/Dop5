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
    /// Логика взаимодействия для Z6.xaml
    /// </summary>
    public partial class Z6 : Window
    {
        public Z6()
        {
            InitializeComponent();
        }

        private void inc_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            string gestures = "";
            foreach (GestureRecognitionResult res in e.GetGestureRecognitionResults()) 
                
                gestures += res.ApplicationGesture.ToString() + "; ";
            gesrName.Text = gestures;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
                list.Items.Add(mode);
            list.SelectedItem = inc.EditingMode;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Z7Sam z7Sam = new Z7Sam();
            z7Sam.Show();
        }
    }
}
