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

namespace P_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, color;
            name = NameBox.Text;
            color = ColorBox.Text;

            if (color == "blue")
            {
                MessageBox.Show($"We have the same color");
            }
            else
            {
                MessageBox.Show($"{name} that is really cool, I would have never thought that!");
            }

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanges_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
