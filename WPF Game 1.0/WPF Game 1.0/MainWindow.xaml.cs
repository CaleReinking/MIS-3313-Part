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

namespace WPF_Game_1._0
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
        bool Turn = true;
        int count = 0;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (Turn)
            {
                b.Content = "O";
                b.IsEnabled = false;
                lblTurn.Content = "X's turn!";
            }
            else
            {
                b.Content = "X";
                b.IsEnabled = false;
                lblTurn.Content = "O's Turn!";
            }
            Turn = !Turn;
            count++;

            bool there_is_a_winner = false;
            if ((!btntopleft.IsEnabled) && btntopleft.Content == btntopmid.Content && btntopmid.Content == btntopright.Content)
            {
                there_is_a_winner = true;
            }
            else if ((!btnmidleft.IsEnabled) && btnmidleft.Content == btnmid.Content && btnmid.Content == btnmidright.Content)
            {
                there_is_a_winner = true;
            }
            else if ((!btnbtmleft.IsEnabled) && btnbtmleft.Content == btnbtmmid.Content && btnbtmmid.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }

            else if ((!btntopleft.IsEnabled) && btntopleft.Content == btnmidleft.Content && btnmidleft.Content == btnbtmleft.Content)
            {
                    there_is_a_winner = true;
            }
            else if ((!btntopmid.IsEnabled) && btntopmid.Content == btnmid.Content && btnmid.Content == btnbtmmid.Content) 
            {
                there_is_a_winner = true;
            }
            else if ((!btntopright.IsEnabled) && btntopright.Content == btnmidright.Content && btnmidright.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }

            else if ((!btntopleft.IsEnabled) && btntopleft.Content == btnmid.Content && btnmid.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }
            else if ((!btnbtmleft.IsEnabled) && btnbtmleft.Content == btnmid.Content && btnmid.Content == btntopright.Content)
            {
                there_is_a_winner = true;
            }

            if (there_is_a_winner)
            {
                string Winner = "";
                if (Turn)
                {
                    Winner = "X";
                }
                else
                {
                    Winner = "O";
                }

                MessageBox.Show($"{Winner} is the winner!");
                DisableButton();
            }
            if (count == 9)
                MessageBox.Show("Cat! Sorry!");

        }

        private void DisableButton()
        {
            throw new NotImplementedException();
        }

        public void checkWinner()
        {
            bool there_is_a_winner = false;
            if ((!btntopleft.IsEnabled) && btntopleft.Content == btntopmid.Content && btntopmid.Content == btntopright.Content)
            {
                there_is_a_winner = true;
            }
           else if ((!btnmidleft.IsEnabled) && btnmidleft.Content == btnmid.Content && btnmid.Content == btnmidright.Content)
            {
                there_is_a_winner = true;
            }
           else if ((!btnbtmleft.IsEnabled) && btnbtmleft.Content == btnbtmmid.Content && btnbtmmid.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }

           else if ((!btntopleft.IsEnabled) && btntopleft.Content == btnmidleft.Content && btnmidleft.Content == btnbtmleft.Content)
            {
                there_is_a_winner = true;
            }
           else if ((!btntopmid.IsEnabled) && btntopmid.Content == btnmid.Content && btnmid.Content == btnbtmmid.Content)
            {
                there_is_a_winner = true;
            }
           else if ((!btntopright.IsEnabled) && btntopright.Content == btnmidright.Content && btnmidright.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }

           else if ((!btntopleft.IsEnabled) && btntopleft.Content == btnmid.Content && btnmid.Content == btnbtmright.Content)
            {
                there_is_a_winner = true;
            }
            else if ((!btnbtmleft.IsEnabled) && btnbtmleft.Content == btnmid.Content && btnmid.Content == btntopright.Content)
            {
                there_is_a_winner = true;
            }

            if (there_is_a_winner)
            {
                string Winner = "";
                    if (Turn)
                {
                    Winner = "X";
                }
                else
                {
                    Winner = "O";
                }
                MessageBox.Show($"{Winner} is the winner!");
                DisableButton();
            }
            if (count == 9)
                 MessageBox.Show("Cat! Sorry!");
            
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lblTurn.Content = "O's turn!";
        }
       
        private void Disable_Click(object sender, RoutedEventArgs e)
        {
            btntopleft.IsEnabled = true;
            btntopleft.Content = "";

            btntopmid.IsEnabled = true;
            btntopmid.Content = "";

            btntopright.IsEnabled = true;
            btntopright.Content = "";

            btnmidleft.IsEnabled = true;
            btnmidleft.Content = "";

            btnmid.IsEnabled = true;
            btnmid.Content = "";

            btnmidright.IsEnabled = true;
            btnmidright.Content = "";

            btnbtmleft.IsEnabled = true;
            btnbtmleft.Content = "";

            btnbtmmid.IsEnabled = true;
            btnbtmmid.Content = "";

            btnbtmright.IsEnabled = true;
            btnbtmright.Content = "";
        }
    }
}
