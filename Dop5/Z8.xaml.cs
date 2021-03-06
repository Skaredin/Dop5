﻿using System;
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
    /// Логика взаимодействия для Z8.xaml
    /// </summary>
    public partial class Z8 : Window
    {
        public Z8()
        {
            InitializeComponent();
        }

        private void TextBlock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val)&& e.Text!="-")
            {
                e.Handled = true;
            }
        }

        private void TextBlock_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Space)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Z9 z9 = new Z9();
            z9.Show();
        }
    }
}
