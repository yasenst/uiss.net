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
using StudentRepository;
using MyUserLogin;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }



        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please, specify both username and password");
            }
            else
            {
                User user = UserData.isUserPassCorrect(username, password);

                if (user != null)
                {
                    Student student = null;
                    student = StudentValidation.GetStudentDataByUser(user);
                    if (student != null)
                    {
                        StudentPage studentPage = new StudentPage(student);
                        this.NavigationService.Navigate(studentPage);
                    }
                }
            }
        }
    }
}
