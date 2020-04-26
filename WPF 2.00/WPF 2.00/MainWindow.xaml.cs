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

namespace WPF_2._00
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

        private void btnactivate_Click(object sender, RoutedEventArgs e)
        {
            if (radioeven.IsChecked == true)
            {
                double max = Convert.ToDouble(txtmax.Text);
                
                for (int i = 0; i < max; i++)
                {
                    if (i % 2 == 0)
                    {
                        lstnumbers.Items.Add(i);
                    }
                }
            }
            if (radioodd.IsChecked == true)
            {
                double max = Convert.ToDouble(txtmax.Text);

                for (int i = 1; i < max; i++)
                {
                    if (i % 2 != 0)
                    {
                        lstnumbers.Items.Add(i);
                    }
                }
            }
        }

        
    }
}
            

