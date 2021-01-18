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
    /// Логика взаимодействия для Z9.xaml
    /// </summary>
    public partial class Z9 : Window
    {
        public Z9()
        {
            InitializeComponent();
            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Help;
            commandBinding.Executed += CommandBinding_Executed;
            Help.CommandBindings.Add(commandBinding);
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        { MessageBox.Show("LOL"); }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Samostoatelnaa1 samostoatelnaa1 = new Samostoatelnaa1();
            samostoatelnaa1.Show();
        }
    }
}
