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

namespace P_WPF_Student
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

        
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            Student stud1 = new Student();
            stud1.StudentID = Convert.ToInt32(txtStudentID.Text);
            stud1.FirstName = txtFirstName.Text;
            stud1.LastName = txtLastName.Text;
            stud1.FavoriteColor = txtFavoriteColor.Text;

            string Sentence = stud1.ToString();
            1stStudent.Items.Add(Sentence);

            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFavoriteColor.Text = "";
                
        }
    }
}
